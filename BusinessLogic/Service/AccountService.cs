using BusinessLogic.IService;
using Models;
using Repository.IRepo;
using Repository.Repo;

namespace BusinessLogic.Service
{
    public class AccountService : IAccountService
    {
        private IAccountRepo repo;

        public AccountService()
        {
            repo = new AccountRepo();
        }

        public async Task<bool> BanAccount(string accID) => await repo.BanAccount(accID);

        public async Task<bool> ChangePassword(string accId, string newPassword) => await repo.ChangePassword(accId, newPassword);

        public async Task<bool> DeleteAccount(string accID) => await repo.DeleteAccount(accID);

        public async Task<bool> Login(string username, string password) => await repo.Login(username, password);

        public async Task<bool> Register(Account account, User user) => await repo.Register(account, user);

        public async Task<bool> UnbanAccount(string accID) => await repo.UnbanAccount(accID);
    }
}
