using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;
using TFGPlastic.UseCases.Contributor.Queries.GetTarea;

namespace TFGPlastic.Web.Pages
{
    public class VerDetalleTarea : PageModel
    {
        private readonly IMediator _mediator;


        public TareaDto Tarea;
        public string Mensaje { get; private set; }
        [BindProperty]
        public Guid TareaId { get; set; }

        public VerDetalleTarea(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> OnPostAsync()
        {

            var query = new GetTareaQuery { Id = TareaId };
            var tarea = await _mediator.Send(query);

            if (tarea == null)
            {
                return RedirectToPage("/Error");
            }

            this.Tarea = tarea;

            return Page(); 
        }
    }
}