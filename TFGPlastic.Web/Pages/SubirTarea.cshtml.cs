using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TFGPlastic.Core.Enum;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;
using TFGPlastic.Web.Utils;

namespace TFGPlastic.Web.Pages
{

    public class SubirTarea : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public TareaDto Tarea;

        [BindProperty]
        public string Titulo { get; set; }
        [BindProperty]
        public string Descripcion { get; set; }
        [BindProperty]
        public DateTime FechaPublicacion { get; set; }
        public string Mensaje { get; private set; }
      

        public SubirTarea(ILogger<IndexModel> logger, IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
        } 

        public async Task<IActionResult> OnPostAsync()
        {
            if (AuthenticatedUser.IsAuthenticated(_httpContextAccessor.HttpContext))
            {
                if (!string.IsNullOrEmpty(Titulo) && !string.IsNullOrEmpty(Descripcion))
                {
                    CreatTareaCommand createTareaCommand = new CreatTareaCommand(
                        this.Titulo,
                        this.Descripcion,
                        this.FechaPublicacion);

                    Tarea = await _mediator.Send(createTareaCommand);

                    return Page();
                }
                return RedirectToPage(); //Redirige a la misma página. Puedes cambiar la redirección si es necesario.
            }
            else { 
                return RedirectToPage("/Login");
            }
        }
    }
}