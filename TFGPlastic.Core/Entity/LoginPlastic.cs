using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TFGPlastic.Core.Entity
{
    public class LoginPlastic
    {

        public static string login(String usuario, String pass) {
            //Boolean log = false;

            string filePath = "C:\\Users\\nicolas.simarro\\Desktop\\TFGPLASTICWEBNICOLAS\\TFGPlastic.Web\\TFGPlastic.Core\\login.txt";
            string content = "";
            try
            {
                // Lee todo el contenido del archivo
                string contenido = File.ReadAllText(filePath);

                content = contenido;
            }
            catch (IOException e)
            {
                // Manejar excepciones de IO, como cuando el archivo no existe
                Console.WriteLine($"Error al leer el archivo: {e.Message}");
            }
            return content;
        }
    }
}
