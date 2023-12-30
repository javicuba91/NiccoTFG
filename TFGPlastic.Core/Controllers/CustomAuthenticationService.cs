using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.Core.Controllers
{
    public class CustomAuthenticationService : ICustomAuthenticationService
    {
        public Task<bool> LoginUser(string username, string password)
        {
            // Implementa tu lógica de autenticación personalizada aquí
            // Retorna true si la autenticación es exitosa, de lo contrario, false
            return Task.FromResult(username == "nicolas.simarro" && password == "Nicosima_111");
        }
    }

}
