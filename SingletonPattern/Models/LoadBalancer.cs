using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Models
{
    using System.Collections;
    class LoadBalancer
    {
        private static readonly LoadBalancer instance = new LoadBalancer();

        private ArrayList serverList = null;

        private LoadBalancer()
        {
            serverList = new ArrayList();
        }

        public static LoadBalancer GetInstance()
        {
            return instance;
        }

        public void AddServer(string server)
        {
            serverList.Add(server);
        }

        public void Remove(string server)
        {
            serverList.Remove(server);
        }

        public string GetServer()
        {
            Random random = new Random();
            int i = random.Next(serverList.Count);
            return serverList[i].ToString();
        }

    }
}
