using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_repaso_POO.Clases
{
    public class CCuentas
    {
        public string CODIGO {  get; set; }

        public void ObtenerCod(string vari)
        {
            CODIGO = CCodigos.Codigo(vari);
        }

        public string TIPO { get; set; }

        public string DNI { get; set; }

        public string NOMBRE { get; set; }

        public double SALDO { get; set; }

        
    }
}
