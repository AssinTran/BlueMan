using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface ICartRepo
    {
        Task<List<Cart>> ListCartUser(string userId);
        Task<Cart?> GetCart(string cId);
        Task<bool> AddCart(Cart cart);
        Task<bool> Delete(string cId);
        Task<bool> Update(Cart cart);
    }
}
