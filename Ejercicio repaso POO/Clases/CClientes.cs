using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_repaso_POO.Clases
{
    public class CClientes
    {
        public int CODIGO { get; set; }

        public string DNI { get; set; }

        public string NOMBRE { get; set; }

        public int TELEFONO { get; set; }

        public string EMAIL { get; set; }

        public DateTime FECHA { get; set; }

        public int EDAD
        {
            get
            {
                return ObtenerEdad();
            }
        }

        public int ObtenerEdad()
        {

            int edad = DateTime.Now.Year - FECHA.Year;

            if (DateTime.Now.Month < FECHA.Month)
            {
                edad-=1;
            }
            else if (DateTime.Now.Month == FECHA.Month && DateTime.Now.Day < FECHA.Day)
            {
                edad-=1;
            }

            return edad;


        }

    }
}   
