using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TFGPlastic.Core.Controllers
{
    public class RegistroController : ControllerBase
    {

        public async Task<IActionResult> RegistroUsuario(string nombre, string email, string usuario, string pass) {

            // Especifica la ruta completa o relativa del archivo
            string rutaArchivo = "C:\\Users\\nicolas.simarro\\Desktop\\TFGPLASTICWEBNICOLAS\\TFGPlastic.Web\\TFGPlastic.Core\\usuarios.txt";

            // Abre el archivo para escribir (si no existe, se crea; si existe, se sobrescribe)
            using (StreamWriter escritor = new StreamWriter(rutaArchivo,true))
            {
                // Escribe líneas en el archivo
                escritor.WriteLine(nombre+";"+email+";"+usuario+";"+pass);
            }

            return RedirectToPage("/Login");

        }

    }
}
