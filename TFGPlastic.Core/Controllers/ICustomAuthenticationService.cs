using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.Core.Controllers
{
    public interface ICustomAuthenticationService
    {
        Task<bool> LoginUser(string username, string password);
    }
}
