using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class CartDAO : Connector<CartDAO>
    {
        public async Task<List<Cart>> ListCartUser(string userId)
        {
            return await DB.Carts.Where(c => c.UserId.Equals(userId)).ToListAsync();
        }

        public async Task<Cart?> GetCart(string cid)
        {
            return await DB.Carts.FindAsync(cid);
        }

        public async Task<bool> AddCart(Cart cart)
        {
            if (cart == null) return false;

            cart.Id = new GenerateID("Cart").Value;
            DB.Carts.Add(cart);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Update(Cart cart)
        {
            if (cart == null) return false;
            Cart? c = await GetCart(cart.Id);
            if (c == null) return false;

            DB.Entry(c).CurrentValues.SetValues(cart);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Delete(string cid)
        {
            Cart? c = await GetCart(cid);
            if (c == null) return false;

            DB.Carts.Remove(c);
            await DB.SaveChangesAsync();

            return true;
        }
    }
}
