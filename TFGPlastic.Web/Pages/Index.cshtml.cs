using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TFGPlastic.UseCases.Contributor.Command.Order;
using TFGPlastic.Web.Utils;

namespace TFGPlastic.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OrderDto Order { get; set; }
        [BindProperty]
        public string Name { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
        }

        public void OnGet()
        {
            //if (!AuthenticatedUser.HasPermission(_httpContextAccessor.HttpContext, "algun_permiso"))
            //{
            //    return RedirectToPage();
            //}
        }
        public async Task<IActionResult> OnPostSubmitName()
        {
            if (AuthenticatedUser.IsAuthenticated(_httpContextAccessor.HttpContext))
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    CreateOrderCommand createOrderCommand = new CreateOrderCommand(Name);
                    Order = await _mediator.Send(createOrderCommand);


                    return Page();
                }

                // Aquí puedes agregar el código para manejar el nombre.
                // Por ejemplo, guardarlo en una base de datos, etc.

                return RedirectToPage();
            }
            else
            {
                return RedirectToPage("/Login");
            }// Redirige a la misma página. Puedes cambiar la redirección si es necesario.
        }

    }
}