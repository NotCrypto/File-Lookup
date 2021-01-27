using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    class Login
    {
        private readonly string _us = "root";
        private readonly string _pw = "root";

        private readonly string us;
        private readonly string pw;

        public Login(string us, string pw)
        {
            this.us = us;
            this.pw = pw;
        }

        public bool isSuccess()
        {
            return us ==_us && pw == _pw;
        }

        public bool isPassword()
        {
            return pw == _pw;
        }
    }
}
