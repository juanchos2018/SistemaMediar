using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class ClsWebParametros
    {
        private static string _WebServer;
        public static string WebServer
        {
            get
            {
                return _WebServer;
            }
            set
            {
                _WebServer = value;
            }
        }
    }
}
