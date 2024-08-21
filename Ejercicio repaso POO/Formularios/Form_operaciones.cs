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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_repaso_POO.Formularios
{
    public partial class Form_operaciones : Form
    {
        CListas clase_listas;
        public Form_operaciones(CListas listas)
        {
            InitializeComponent();

            clase_listas = listas;
            MODO_LISTA();
            textBox1.Enabled = false;
        }

        private void Form_operaciones_Load(object sender, EventArgs e)
        {
            cb_tipo.Items.Add("Extracción");
            cb_tipo.Items.Add("Deposito");
        }

        public void MODO_CARGA()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        public void MODO_LISTA()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        public void ARMA_GRILLA()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clase_listas.Loperaciones;
        }

        public void LIMPIAR()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "//";
            cb_tipo.Text = "";
            textBox4.Text = "";
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_ope_Click(object sender, EventArgs e)
        {
            MODO_CARGA();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            COperaciones operaciones = new COperaciones();

            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese correctamente el numero de DNI del cliente que realizara la transacción.\n\nEJ:43495009", "ERROR");
                return;
            }

            if (textBox2.Text.Length < 7)
            {
                MessageBox.Show("El numero de DNI ingresado es demasiado corto, ingrese un numero de DNI posible.\n\nEJ:46495234", "ERROR");
                return;
            }

            if (textBox2.Text.Length > 8)
            {
                MessageBox.Show("El numero de DNI ingresado es demasiado largo, ingrese un numero de DNI posible.\n\nEJ:46495234", "ERROR");
                return;
            }

            bool ValidaDNI()
            {
                string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");

                foreach (CClientes cliente in clase_listas.Lclientes)
                {
                    if (cliente.DNI == dni)
                    {
                        return true;
                    }
                }

                return false;
            }

            if (!ValidaDNI())
            {
                MessageBox.Show("Este cliente no se encuentra registrado en el sistema.\n\nPara poder continuar, el cliente debe ser registrado", "ERROR");
                return;
            }
            #endregion
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MODO_LISTA();
        }
    }
}
