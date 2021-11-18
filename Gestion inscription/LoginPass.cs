using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_inscription
{
    class LoginPass
    {
        private static string varLog = "";

        public static string varlog
        {
            get { return varLog; }
            set { varLog = value; }
        }
        private static string varpass = "";

        public static string varlpass
        {
            get { return varpass; }
            set { varpass = value; }
        }
    }
}
