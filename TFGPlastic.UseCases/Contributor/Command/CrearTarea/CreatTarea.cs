using Mapster;
using MediatR;
using TFGPlastic.Core.Entity;
//using TFGPlastic.Infrastructure.FileSystem.DataBase;

namespace TFGPlastic.UseCases.Contributor.Command.CrearTarea
{
    //public class CreatTarea 
    //{

    //    private readonly IReposotoryTareas _reposotory;
    //    private readonly IGestorTarea _gestortareas;
    //    private readonly IGeneratorUid generatorUid;
    //    private readonly IMediator _mediator;
    //    public CreatTarea(IRepositoryTareas repository, IMediator mediator )
    //    {
    //        this._reposotory = repository;
    //        this._mediator = mediator;
    //    }
    //    public async Task<TareaDto> Execute(DateTime dateTime)
    //    {

    //        List<TareaDto> tareasToCompilar = this._gestortareas.GetTareas();

    //        foreach(var tareaDto  in tareasToCompilar)
    //        {
    //            if(tareaStatus == terminada)
    //            {
    //                TareaEntity tarea = this._reposotory.Find(id);

    //                if (tarea != null)
    //                {
    //                    throw new TareaRepetida();
    //                }

    //                tarea = new TareaEntity(id, titulo, descripcion, dateTime);

    //                this._reposotory.save(tarea);
    //                this._mediator.Publish(tarea.pullDomainEvent());

    //            }
    //        }


            

    //     }
    //}
}
