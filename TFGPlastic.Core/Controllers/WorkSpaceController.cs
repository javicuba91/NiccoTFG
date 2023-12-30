using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFGPlastic.Core.Entity;

namespace TFGPlastic.Core.Controllers
{
    public class WorkSpaceController : ControllerBase
    {

        public async Task<IActionResult> WorkSpaceCreate(string nombre, string ruta)
        {
            if (nombre != null && ruta != null)
            {
                ConexionPlastic.WorkSpaceCreate(nombre, ruta);
            }

            return RedirectToPage("/WorkSpace");
        }
               
        public async Task<IActionResult> Eliminar(string nombre)
        {
            if (nombre != null)
            {
                ConexionPlastic.Eliminar(nombre);
                return RedirectToPage("/WorkSpace");
            }

            return RedirectToPage("/Index");
        }


    }
}
