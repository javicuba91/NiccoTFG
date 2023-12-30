using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TFGPlastic.Core.Entity;
using TFGPlastic.Core.Entity.User.User;

namespace TFGPlastic.Core.Controllers;

public class LoginController : ControllerBase
{
    private readonly ICustomAuthenticationService _customAuthService;
    public LoginController(ICustomAuthenticationService customAuthService)
    {
        _customAuthService = customAuthService;
    }

    public async Task<IActionResult> LoginUser(string username, string password)
    {
        
        bool isAuthenticated = comprobarUsuario(username, password);

        if (isAuthenticated)
        {
            UsuarioEntity usuario = buscarUsuario(username, password);

            var claims = new[]
            {
                    new Claim(ClaimTypes.Name, usuario.UserName),
                    new Claim("username", usuario.UserName),
                    new Claim("nombre", usuario.Name),

                };

            var claimsIdentity = new ClaimsIdentity(claims, "login");


            var principal = new ClaimsPrincipal(claimsIdentity);


            await HttpContext.SignInAsync(principal);


            return RedirectToPage("/WorkSpace");
        }

       
        return RedirectToPage("/LoginError");
    }

    public Boolean comprobarUsuario(string username, string password)
    {
        bool result = false;

        if (buscarUsuario(username, password) != null) {
            result = true;
        }


        return result;
    }

    public UsuarioEntity buscarUsuario(string username, string password) {
        UsuarioEntity usuario = null;

        string rutaArchivo = "C:\\Users\\nicolas.simarro\\Desktop\\TFGPLASTICWEBNICOLAS\\TFGPlastic.Web\\TFGPlastic.Core\\usuarios.txt";

        using (StreamReader lector = new StreamReader(rutaArchivo))
        {
            while (!lector.EndOfStream)
            {
                string linea = lector.ReadLine();
                string[] lineas = linea.Split(";");

                if (lineas.Length == 4 && lineas[2].Equals(username) && lineas[3].Equals(password))
                {
                    usuario = new UsuarioEntity(lineas[0], lineas[1], lineas[2], lineas[3]);
                }

            }
        }

        return usuario;
    }

    [HttpGet]
    public async Task<IActionResult> Salir()
    {
        
        await HttpContext.SignOutAsync();

         
        return RedirectToPage("/Login");
    }

}
