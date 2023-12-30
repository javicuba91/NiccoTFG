using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.Core.CustomExceptions;
using TFGPlastic.Core.Enum;

namespace TFGPlastic.Core.Entity
{
    public class TareaEntity
    {
        private const int DIAS_MINIMOS_PREVIOS = 7;
        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descripcion { get; private set; }
        public DateTime FechaPublicacion { get; private set; }
        public EstadosTarea Estado { get; private set; }
        public TareaEntity(string titulo, string descripcion, DateTime fechaPublicacion)
        {

            this.Id = Guid.NewGuid();
            this.Titulo = titulo;
            this.Descripcion = descripcion;
           
            if (ValidarPublicacion(fechaPublicacion))
            {
                this.FechaPublicacion = fechaPublicacion;
            }
            this.CompilarTarea();
        }

        private bool ValidarPublicacion(DateTime fechaPublicacion)
        {
            TimeSpan diferencia = fechaPublicacion - DateTime.Now;

            if (diferencia.Days < DIAS_MINIMOS_PREVIOS)
            {
                throw new TiempoInferiorAlRequeridoException($"La fecha introducida es {DIAS_MINIMOS_PREVIOS - diferencia.Days} antes de lo requierdo");
            }
            return true;
        }
        public void PublicarTarea()
        {
            this.Estado = EstadosTarea.Publicado;
        }

        public void IntegrarTarea()
        {

            this.Estado = EstadosTarea.Integrado;

        }

        public void CompilarTarea()
        {

            this.Estado = EstadosTarea .Compilado;

        }

    }

}
