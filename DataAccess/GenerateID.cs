using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GenerateID
    {
        private string _host = "blueman";
        private DateTime _currentTime;

        public GenerateID(string table)
        {
            this._currentTime = DateTime.Now;
            string temp = this._currentTime + this._host + table;
            this.Value = GenerateId(temp);
        }

        private string GenerateId(string temp)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                //chuyen chuoi thanh mang byte
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(temp));
                //chuyen mang byte thanh dang hex
                StringBuilder rs = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    rs.Append(bytes[i].ToString("x2"));
                }
                // Tra ve chuoi 32 ky tu dau tien
                return rs.ToString().Substring(0, 32);
            }
        }

        public string Value { get; set; }

    }
}
