using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Veshion_Git
{
     class Internet
    {
        public static bool OK()
        {
			try
			{
                Dns.GetHostEntry("github.com");
                return true;
			}
			catch (Exception)
			{
                return false;
			}
        }
    }
}
