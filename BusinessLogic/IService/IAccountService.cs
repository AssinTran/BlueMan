using Models;

namespace BusinessLogic.IService
{
    public interface IAccountService
    {
        Task<bool> Login(string username, string password);
        Task<bool> Register(Account account, User user);
        Task<bool> BanAccount(string accID);
        Task<bool> UnbanAccount(string accID);
        Task<bool> ChangePassword(string accId, string newPassword);
        Task<bool> DeleteAccount(string accID);
    }
}
