using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Connector<T> where T : class, new()
    {
        private static T? _instance;
        private static readonly object _lock = new object();
        public BlueManContext DB { get; set; }
        public Connector()
        {
            DB = new();
        }
        public static T Instance
        {
            get
            {
                lock (_lock)
                {
                    return _instance ?? new();
                }
            }
        }
    }
}
