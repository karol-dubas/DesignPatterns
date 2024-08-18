using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Configuration
    {
        public string ConnectionString { get; set; }
        public int TextSize { get; set; }

        private static Configuration _instance;
        private static readonly object asyncLock = new();

        private Configuration() { }

        public static Configuration GetInstance()
        {
            lock (asyncLock)
            {
                if (_instance is null)
                {
                    _instance = new Configuration();
                }
            }

            return _instance;
        }
    }
}
