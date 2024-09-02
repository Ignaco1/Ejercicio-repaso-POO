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
        public static int ContOD = 0;
        public static int ContOE = 0;

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

        public static string CodigoOperacion(string operacion)
        {
            if (operacion == "Extracción")
            {
                return "#OE" + ContOE.ToString("D3");
            }
            else if (operacion == "Deposito")
            {
                return "#OD" + ContOD.ToString("D3");
            }

            return operacion;
        }

        public static void SumarContOpe(string codigo)
        {
            if (codigo == "Extracción")
            {
                ContOE += 1;
            }
            else if (codigo == "Deposito")
            {
                ContOD += 1;

            }
        }
    }
}
