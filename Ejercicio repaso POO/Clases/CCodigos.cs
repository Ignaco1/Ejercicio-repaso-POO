using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_repaso_POO.Clases
{
    public class CCodigos
    {
        public static int ContCC = 0;
        public static int ContCA = 0;

        public static string Codigo(string codigo)
        {         
            if (codigo == "Cuenta corriente")
            {
                return "#CC" + ContCC.ToString("D3");
            }
            else if (codigo == "Caja de ahorro")
            {
                return "#CA" + ContCA.ToString("D3");
            }           

            return codigo;
        }

        public static void SumarCont(string codigo)
        {
            if (codigo == "Cuenta corriente")
            {
                ContCC += 1;
            }
            else if (codigo == "Caja de ahorro")
            {
                ContCA += 1;

            }
        }
    }
}
