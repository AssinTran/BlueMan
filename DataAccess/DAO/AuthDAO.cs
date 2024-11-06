using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace DataAccess.DAO
{
    public class AuthDAO : Connector<AuthDAO>
    {
        public async Task<bool> Login(string username, string password)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(password);
            Account? acc = await DB.Accounts.FindAsync(username, hash);
            if (acc == null) return false;

            return true;
        }

        public async Task<bool> Register(Account acc, User user)
        {
            if (acc == null && user == null) return false;

            acc.Password = BCrypt.Net.BCrypt.HashPassword(acc.Password);
            if (acc.Role == null)
            {
                acc.Username = user.Phone;
            }

            acc.Id = new GenerateID("Account").Value;
            user.Id = new GenerateID("User").Value;

            await DB.Users.AddAsync(user);
            await DB.Accounts.AddAsync(acc);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UnBanAccount(string accID)
        {
            if (accID == null) return false;

            Account? account = await DB.Accounts.FindAsync(accID);
            if (account == null) return false;
            var temp = account;

            account.Accept = true;
            DB.Entry(temp).CurrentValues.SetValues(account);
            await DB.SaveChangesAsync();

            return true;
        }
        
        public async Task<bool> BanAccount(string accID)
        {
            if (accID == null) return false;

            Account? account = await DB.Accounts.FindAsync(accID);
            if (account == null) return false;
            var temp = account;

            account.Accept = false;
            DB.Entry(temp).CurrentValues.SetValues(account);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> ChangePassword(string id, string newPass)
        {
            if (newPass == null) return false;

            Account? acc = await DB.Accounts.FindAsync(id);
            if (acc == null) return false;

            var temp = acc;
            acc.Password = BCrypt.Net.BCrypt.HashPassword(newPass);
            DB.Entry(temp).CurrentValues.SetValues(acc);
            await DB.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteAccount(string id)
        {
            Account? acc = await DB.Accounts.FindAsync(id);
            if (acc == null) return false;

            DB.Accounts.Remove(acc);
            await DB.SaveChangesAsync();

            return true;
        }
    }
}
