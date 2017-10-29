using System;
using System.Collections.Generic;
using System.Text;

namespace AddStop.Models
{
    class User
    {
        private string _login;

        public string login
        {
            get { return _login; }
            set { _login = value; }
        }

        private string _password;

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
