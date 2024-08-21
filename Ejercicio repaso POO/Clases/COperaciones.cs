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

        public string TIPO_CUENTA { get; set; }

        public string FECHA
        {
            get
            {
                DateTime hoy = DateTime.Now;
                return hoy.ToString("dd/MM/yyyy");
            }
        }

        public string TIPO_OPERACION { get; set; }

        public double IMPORTE { get; set; }

        
    }
}
