using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepo
{
    public interface IAccountRepo
    {
        Task<bool> Login(string username, string password);
        Task<bool> Register(Account account, User user);
        Task<bool> BanAccount(string accID);
        Task<bool> UnbanAccount(string accID);
        Task<bool> ChangePassword(string accId, string newPassword);
        Task<bool> DeleteAccount(string accID);
    }
}
