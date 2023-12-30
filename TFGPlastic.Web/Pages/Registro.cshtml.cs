using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TFGPlastic.Web.Pages
{
    public class RegistroModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Usuario { get; set; }

        [BindProperty]
        public string Contraseña { get; private set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
            
            if (ModelState.IsValid)
            {
                RedirectToPage("/Login");
            }
        }
    }
}
