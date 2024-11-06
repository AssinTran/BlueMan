using BusinessLogic.IService;
using Models;
using Repository.IRepo;
using Repository.Repo;

namespace BusinessLogic.Service
{
    public class UserService : IUserService
    {
        private IUserRepo repo;
        public UserService()
        {
            repo = new UserRepo();
        }
        public async Task<bool> Update(User user) => await repo.Update(user);
    }
}
