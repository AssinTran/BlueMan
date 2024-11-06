using DataAccess.DAO;
using Models;
using Repository.IRepo;

namespace Repository.Repo
{
    public class UserRepo : IUserRepo
    {
        private UserDAO dao;
        public UserRepo()
        {
            dao = new();
        }
        public async Task<bool> Update(User user) => await dao.Update(user);
    }
}
