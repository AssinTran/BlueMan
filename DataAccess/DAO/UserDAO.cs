using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DataAccess.DAO
{
    public class UserDAO : Connector<UserDAO>
    {
        public async Task<bool> Update(User user)
        {
            if (user == null) return false;

            User? u = await DB.Users.FindAsync(user.Id);
            if (u == null) return false;

            DB.Entry(u).CurrentValues.SetValues(user);
            await DB.SaveChangesAsync();

            return true;
        }

    }
}
