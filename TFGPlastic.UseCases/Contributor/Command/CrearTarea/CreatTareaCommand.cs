using MediatR;

namespace TFGPlastic.UseCases.Contributor.Command.CrearTarea
{
    public class CreatTareaCommand : IRequest<TareaDto>
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public CreatTareaCommand(string titulo, string descripcion, DateTime fechaPublicacion)
        {
            this.Titulo = titulo;
            this.Descripcion = descripcion;
            this.FechaPublicacion = fechaPublicacion;
        }
    }
}


