using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Veshion_Git
{
    class Updater
    {
        
        public void CheckUpdate()
        {
            using (WebClient client = new WebClient())
            {
                if(Internet.OK())
                {
                    Console.WriteLine("Есть инет");
                }
                else
                {
                    Console.WriteLine("Нет инета");
                }
            }
        }
    }
}
