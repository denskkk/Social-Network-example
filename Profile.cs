using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook
{
    public class Profile
    {
        private string id;
        private string email;

        public Profile(string id, string email)
        {
            this.id = id;
            this.email = email;
        }

        public string GetId() => id;

        public string GetEmail() => email;
    }


}
