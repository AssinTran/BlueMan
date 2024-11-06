using Models;

namespace BusinessLogic.IService
{
    public interface IUserService
    {
        Task<bool> Update(User user);
    }
}
