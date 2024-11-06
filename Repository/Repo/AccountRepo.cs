using DataAccess.DAO;
using Models;
using Repository.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repo
{
    public class AccountRepo : IAccountRepo
    {
        private AuthDAO dao;

        public AccountRepo()
        {
            dao = new();
        }

        public async Task<bool> BanAccount(string accID) => await dao.BanAccount(accID);

        public async Task<bool> ChangePassword(string accId, string newPassword) => await dao.ChangePassword(accId, newPassword);

        public async Task<bool> DeleteAccount(string accID) => await dao.DeleteAccount(accID);

        public async Task<bool> Login(string username, string password) => await dao.Login(username, password);

        public async Task<bool> Register(Account account, User user) => await dao.Register(account, user);

        public async Task<bool> UnbanAccount(string accID) => await dao.UnBanAccount(accID);
    }
}
