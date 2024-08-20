using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_repaso_POO.Clases
{
    public class CListas
    {
        public CListas()
        {
            Lclientes = new List<CClientes>();
            Lcuentas = new List<CCuentas>();
            Lcaja = new List<CCaja_de_ahorro>();
            Lcc = new List<CCuenta_corriente>();
        }

        public List<CClientes> Lclientes { get; set; }
        public List<CCuentas> Lcuentas { get; set; }
        public List<CCaja_de_ahorro> Lcaja { get; set; }
        public List<CCuenta_corriente> Lcc { get; set; }
    }
}
