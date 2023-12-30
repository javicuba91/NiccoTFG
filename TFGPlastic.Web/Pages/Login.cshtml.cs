using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using TFGPlastic.Web.Utils;
using Microsoft.EntityFrameworkCore;
using TFGPlastic.Core.Entity.User.User;
using TFGPlastic.UseCases.Contributor.Command.LogIn;
using MediatR;
using TFGPlastic.Core.Entity;
using TFGPlastic.Infrastructure.DataBase;
using Microsoft.AspNetCore.Authentication;

namespace TFGPlastic.Web.Pages
{
    public class LoginModel:PageModel
    {
        private readonly IMediator _mediator;
        [BindProperty]

        public string Username { get; set; }
        [BindProperty]
        public string Password { get; private set; }
        public bool IsLoggedIn { get; set; }

        private IHttpContextAccessor _httpContextAccessor;

        public bool LoginFailed { get; set; }

        public LoginModel(IHttpContextAccessor httpContextAccessor,  IMediator mediator)
        {

            LoginFailed = false;
            IsLoggedIn = false;
            _httpContextAccessor = httpContextAccessor;
            _mediator = mediator;
            
        }
       
        public IActionResult OnPostAsync()
        {
            if ( ValidarUsuario().Result)
            {
                _httpContextAccessor.HttpContext.Session.SetString(ConstantsTFG.AUTHETICATION_COOKIE, ConstantsTFG.AUTHETICATION_TRUE);
                return RedirectToPage("/WorkSpace");
                // Autenticación exitosa
            }
            _httpContextAccessor.HttpContext.Session.SetString(ConstantsTFG.AUTHETICATION_COOKIE, ConstantsTFG.AUTHETICATION_FALSE);
            return RedirectToPage("/Login");
            // Autenticación fallida
        }

        private async Task<bool>  ValidarUsuario()
        {
            var command = new ValidarUsuarioCommand ("nicolas.simarro",  "Nicosima_111" );
            // Consulta la base de datos para verificar si existe un usuario con el nombre de usuario proporcionado y la contraseña
            try
            {
                return await _mediator.Send(command);

            }catch(Exception ex) {
                return false;
            }
        }

        [HttpPost]
        public IActionResult LoginUser(string username, string password)
        {
            return RedirectToPage("/WorkSpace"); ;
        }

        private bool EsUsuarioValido(string username, string password)
        {
            return username == "usuario" && password == "contraseña";
        }

        [AllowAnonymous]
        public IActionResult Salir() {
            HttpContext.SignOutAsync();

            // Redirigir a la página de inicio u otra página deseada
            return RedirectToPage("/Index");
        }
    }
}
