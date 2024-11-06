using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IOrderRepo
    {
        Task<List<Order>> HistoryOrder(string userID);
        Task<List<Order>> AcceptedOrder(string userID);
        Task<List<Order>> ReceivedOrder(string userID);
        Task<List<Order>> DeliveredOrder(string userID);
        Task<List<Order>> ListOrders();
        Task<bool> AddOrder(Order order);
        Task<Order?> GetOrder(string orderID);
        Task<bool> DeleteOrder(string orderID);
        Task<bool> AcceptOrder(string orderID);
        Task<bool> ReceiveOrder(string orderID);
        Task<bool> DeliverOrder(string orderID);
    }
}
