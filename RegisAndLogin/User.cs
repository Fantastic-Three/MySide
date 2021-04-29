using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myside2
{
    class User
    {
        string email;
        string name;
        string password;

        public string theEmail
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public string theName
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string thePassword
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

    }
}
