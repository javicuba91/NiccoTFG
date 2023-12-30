using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;
using TFGPlastic.UseCases.Contributor.Command.CompileProyects;
using TFGPlastic.UseCases.Contributor.Command.CrearTarea;
using TFGPlastic.UseCases.Contributor.Queries.GetTarea;

namespace TFGPlastic.Web.Pages
{
    public class CompilarProyectos : PageModel
    {
        private readonly IMediator _mediator;


        public string PathCompiledProyects { get; private set; }
        [BindProperty]
        public string CompilePath { get; set; }

        public CompilarProyectos(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var query = new CompileProyectCommand { PathToCompile = CompilePath };
            var PathCompiledProyects = await _mediator.Send(query);

            if (string.IsNullOrEmpty(PathCompiledProyects))
            {
                // Manejo de error o redirección si la tarea no se encuentra.
                return RedirectToPage("/Error");
            }

            // Realiza alguna lógica adicional con la tarea, si es necesario.

            return Page(); //Redirige a la misma página. Puedes cambiar la redirección si es necesario.
        }
    }
}