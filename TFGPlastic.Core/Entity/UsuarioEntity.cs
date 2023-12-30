using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TFGPlastic.Core.Entity.User.User
{
        public class UsuarioEntity
        {
            public string Name { get; private set; }
            public string Email { get; private set; }
            public string UserName { get; private set; }
            public string Password { get; private set; }

            public UsuarioEntity(string name,string email, string username, string pass) {
            this.Name = name;
            this.Email = email;
            this.UserName = username;
            this.Password = pass;
            }
       
        }
}


