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

namespace Ejercicio_repaso_POO.Formularios
{
    public partial class Form_clientes : Form
    {
        string variable = "";
        CListas clase_listas = new CListas();
       
        public Form_clientes()
        {
            InitializeComponent();
            MODO_LISTA();
            textBox6.Enabled = false;
        }

        private void Form_clientes_Load(object sender, EventArgs e)
        {

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
            dataGridView1.DataSource = clase_listas.Lclientes;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            variable = "A";

            MODO_CARGA();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            CClientes clientes = new CClientes();

            #region VALIDACIONES

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingrese correctamente numero de DNI del cliente", "ERROR");
                return;
            }

            if (textBox1.Text.Length > 8)
            {
                MessageBox.Show("El numero de DNI ingresado es demasiado largo, ingrese un numero de DNI posible.\n\nEJ:46495234", "ERROR");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese correctamente el nombre del cliente", "ERROR");
                return;
            }
            //\n
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Ingrese correctamente el telefono del cliente", "ERROR");
                return;
            }

            if (textBox3.Text.Length > 11)
            {
                MessageBox.Show("El numero de telefono ingresado es demasiado largo, ingrese un numero de telefono posible.\n\nEJ:(341)37310223", "ERROR");
                return;
            }

            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Ingrese correctamente el email del cliente", "ERROR");
                return;
            }

            DateTime fecha;

            if (!DateTime.TryParse(textBox5.Text, out fecha))
            {
                MessageBox.Show("Ingrese correctamente la fecha de nacimiento del cliente, EJ: 24/03/05", "ERROR");
                return;
            }

            int edad = ObtenerEdad();

            if (edad < 18)
            {
                MessageBox.Show("Error en la fecha de nacimiento, el cliente debe ser mayor de 18 años", "ERROR");
                return;
            }

            #endregion

            if (variable == "A")
            {
                clientes.DNI = textBox1.Text.Insert(2, ".").Insert(6, ".");
                clientes.NOMBRE = textBox2.Text;
                clientes.TELEFONO = textBox3.Text;
                clientes.EMAIL = textBox4.Text;
                clientes.FECHA = fecha;

                clase_listas.Lclientes.Add(clientes);
            }

            ARMA_GRILLA();
            MODO_LISTA();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        public int ObtenerEdad()
        {

            int edad = DateTime.Now.Year - Convert.ToDateTime(textBox5.Text).Year;

            if (DateTime.Now.Month < Convert.ToDateTime(textBox5.Text).Month)
            {
                edad -= 1;
            }
            else if (DateTime.Now.Month == Convert.ToDateTime(textBox5.Text).Month && DateTime.Now.Day < Convert.ToDateTime(textBox5.Text).Day)
            {
                edad -= 1;
            }

            return edad;


        }
    }
}
