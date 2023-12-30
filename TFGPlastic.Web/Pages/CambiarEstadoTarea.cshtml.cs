using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TFGPlastic.Core.Enum;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;

namespace TFGPlastic.Web.Pages
{
    public class CambiarEstadoTarea : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMediator _mediator;

        public TareaDto Tarea { get; set; }
        [BindProperty]
        public Guid tareaId { get; set; }
        [BindProperty]
        public EstadosTarea EstadoTarea { get; set; }

        
        public CambiarEstadoTarea(ILogger<IndexModel> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
       
        public async Task<IActionResult> OnPostAsync()
        {
            if (tareaId != null)
            {
                CambiarEstadoTareaCommand createTareaCommand = new CambiarEstadoTareaCommand(
                    this.tareaId, this.EstadoTarea
                    );

                Tarea = await _mediator.Send(createTareaCommand);

                return Page();
            }
            return RedirectToPage(); //Redirige a la misma página. Puedes cambiar la redirección si es necesario.
        }
    }
}