﻿using System;
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
            Loperaciones = new List<COperaciones>();

        }

        public List<CClientes> Lclientes { get; set; }
        public List<CCuentas> Lcuentas { get; set; }
        public List<COperaciones> Loperaciones { get; set; }
    }
}
