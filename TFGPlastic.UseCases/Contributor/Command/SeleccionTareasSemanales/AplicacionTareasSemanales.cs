using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.UseCases.Contributor.Command.SeleccionTareasSemanales
{
    internal class AplicacionTareasSemanales
    {
        static void Main()
        {
            List<representarTareas> weeklyTasks = new List<representarTareas>
        {
            new representarTareas { Name = "Tarea 1", IsSelected = false },
            new representarTareas { Name = "Tarea 2", IsSelected = false },
            new representarTareas { Name = "Tarea 3", IsSelected = false },
            // Agregar más tareas según sea necesario
        };

            Console.WriteLine("Tareas semanales disponibles:");

            for (int i = 0; i < weeklyTasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {weeklyTasks[i].Name}");
            }

            Console.WriteLine("Selecciona las tareas que deseas realizar (separadas por comas):");
            string input = Console.ReadLine();
            string[] selectedTaskIndices = input.Split(',');

            foreach (string index in selectedTaskIndices)
            {
                if (int.TryParse(index, out int taskIndex) && taskIndex > 0 && taskIndex <= weeklyTasks.Count)
                {
                    weeklyTasks[taskIndex - 1].IsSelected = true;
                }
            }

            Console.WriteLine("Tareas seleccionadas:");

            foreach (var task in weeklyTasks)
            {
                if (task.IsSelected)
                {
                    Console.WriteLine(task.Name);
                    //Realiza la integración, compilación y publicación de la tarea aquí
                }
            }

            Console.WriteLine("Proceso de selección y acciones completado.");
        }
    }
}
