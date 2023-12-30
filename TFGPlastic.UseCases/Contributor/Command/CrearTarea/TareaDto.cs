using TFGPlastic.Core.Enum;

namespace TFGPlastic.UseCases.Contributor.Command.CrearTarea
{
    public class TareaDto
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public TFGPlastic.Core.Enum.EstadosTarea Estado { get; set; }
    }
}