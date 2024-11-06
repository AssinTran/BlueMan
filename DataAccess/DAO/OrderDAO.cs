using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO : Connector<OrderDAO>
    {
        public async Task<List<Order>> HistoryOrder(string userId)
        {
            return await DB.Orders.Where(u => u.UserId == userId).ToListAsync();
        }

        public async Task<List<Order>> AcceptedOrders(string id)
        {
            return await DB.Orders.Where(o => o.UserId == id && o.Status.Contains("accepted")).ToListAsync();
        }

        public async Task<List<Order>> ReceivedOrders(string id)
        {
            return await DB.Orders.Where(o => o.UserId.Equals(id) && o.Status.Contains("received")).ToListAsync();
        }

        public async Task<List<Order>> DeliveredOrders(string id)
        {
            return await DB.Orders.Where(o => o.UserId.Equals(id) && o.Status.Equals("delivered")).ToListAsync();
        }

        public async Task<List<Order>> ListOrders()
        {
            return await DB.Orders.ToListAsync();
        }

        public async Task<bool> AddOrder(Order order)
        {
            if (order == null) return false;

            order.Id = new GenerateID("Order").Value;
            DB.Orders.Add(order);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<Order?> GetOrder(string id)
        {
            return await DB.Orders.FindAsync(id);
        }

        public async Task<bool> DeleteOrder(string id)
        {
            Order? o = await GetOrder(id);
            if (o == null) return false;

            DB.Orders.Remove(o);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AcceptOrder(string id)
        {
            Order? o = await GetOrder(id);
            if (o == null) return false;

            var temp = o;
            o.Status = "accepted";
            DB.Entry(temp).CurrentValues.SetValues(o);
            await DB.SaveChangesAsync();

            return true;
        }
        public async Task<bool> ReceiveOrder(string id)
        {
            Order? o = await GetOrder(id);
            if (o == null) return false;

            var temp = o;
            o.Status = "received";
            DB.Entry(temp).CurrentValues.SetValues(o);
            await DB.SaveChangesAsync();

            return true;
        }
        public async Task<bool> DeliverOrder(string id)
        {
            Order? o = await GetOrder(id);
            if (o == null) return false;

            var temp = o;
            o.Status = "delivered";
            DB.Entry(temp).CurrentValues.SetValues(o);
            await DB.SaveChangesAsync();

            return true;
        }
    }
}
