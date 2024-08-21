using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_repaso_POO.Clases
{
    public class COperaciones
    {
        public string CODIGO { get; set; }

        public void ObtenerCod(string vari)
        {
            CODIGO = CCodigos.CodigoOperacion(vari);
        }

        public string DNI { get; set; }

        public DateTime FECHA { get; set; }

        public string TIPO { get; set; }

        public double IMPORTE { get; set; }

        
    }
}
