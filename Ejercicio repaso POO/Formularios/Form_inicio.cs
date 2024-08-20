using Ejercicio_repaso_POO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Ejercicio_repaso_POO.Formularios
{
    public partial class Form_inicio : Form
    {
        CListas ListasCompartidas = new CListas();
        Form_clientes formCli;
        Form_cuentas formCue;
        public Form_inicio()
        {
            InitializeComponent();
            formCli = new Form_clientes(ListasCompartidas);
            formCue = new Form_cuentas(ListasCompartidas);
        }

        private void Form_inicio_Load(object sender, EventArgs e)
        {
            cb_opc.Items.Add("Ver clientes");
            cb_opc.Items.Add("Ver cuentas");
            cb_opc.Items.Add("Ver operaciónes");
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (cb_opc.SelectedItem == "Ver clientes")
            {
                formCli.Show();
            }
            else
            {
                formCue.Show();
            }

            cb_opc.Text = "";
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
