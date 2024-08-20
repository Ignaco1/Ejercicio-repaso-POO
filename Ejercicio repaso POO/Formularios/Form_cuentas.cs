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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio_repaso_POO.Formularios
{
    public partial class Form_cuentas : Form
    {
        string variable;
        CListas clase_listas;
        int indice;

        public Form_cuentas(CListas listas)
        {
            InitializeComponent();
            clase_listas = listas;

            MODO_LISTA();
            textBox4.Enabled = false;
            textBox1.Enabled = false;
        }

        private void Form_cuentas_Load(object sender, EventArgs e)
        {
            cb_tipo.Items.Add("Cuenta corriente");
            cb_tipo.Items.Add("Caja de ahorro");
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
            dataGridView1.DataSource = clase_listas.Lcuentas;
        }
        
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            variable = "A";
            MODO_CARGA();
            
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            cb_tipo.Enabled = false;

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una de las cuentas");
                return;
            }

            variable = "M";
            CCuentas cuenta2 = clase_listas.Lcuentas[indice];

            textBox1.Text = cuenta2.CODIGO;
            cb_tipo.Text = cuenta2.TIPO;
            textBox2.Text = cuenta2.DNI.Replace(".", "");
            textBox3.Text = cuenta2.NOMBRE;
            textBox4.Text = Convert.ToString(cuenta2.SALDO);

            MODO_CARGA();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una de las cuentas");
                return;
            }

            CCuentas cuenta3 = clase_listas.Lcuentas[indice];

            DialogResult respuesta = MessageBox.Show("Esta seguro que deseea eliminar la cuenta:\n\nTipo: " + cuenta3.TIPO + "\n\nDNI: " + cuenta3.DNI + "\n\nNombre: " + cuenta3.NOMBRE + "\n\nSaldo = " + cuenta3.SALDO, "AVISO", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                clase_listas.Lcuentas.Remove(cuenta3);
            }

            ARMA_GRILLA();
        }

        public void LIMPIAR()
        {
            textBox1.Text = "";
            cb_tipo.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private bool ValidaDniYNombre()
        {
            string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");
            string nombre = textBox3.Text.Trim();

            foreach (CClientes cliente in clase_listas.Lclientes)
            {
                if (cliente.DNI == dni && cliente.NOMBRE.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private bool Validacaja()
        {
            string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");
            string tipo = cb_tipo.Text.Trim();

            foreach (CCuentas cuentas in clase_listas.Lcuentas)
            {
                if (cuentas.DNI == dni && cuentas.TIPO.Equals(tipo, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private bool ValidaCuentaCorriente()
        {
            string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");
            string tipo = cb_tipo.Text.Trim();

            foreach (CCuentas cuentas in clase_listas.Lcuentas)
            {
                if (cuentas.DNI == dni && cuentas.TIPO.Equals(tipo, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            CCuentas cuenta = new CCuentas();

            #region VALIDACIONES

            if (string.IsNullOrEmpty(cb_tipo.Text))
            {
                MessageBox.Show("Seleccione correctamente un tipo de cuenta", "ERROR");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese correctamente el numero de DNI del titular la de la cuenta\n\nEJ:43495009", "ERROR");
                return;
            }

            if (textBox2.Text.Length < 8)
            {
                MessageBox.Show("El numero de DNI ingresado es demasiado corto, ingrese un numero de DNI posible.\n\nEJ:46495234", "ERROR");
                return;
            }

            if (textBox2.Text.Length > 8)
            {
                MessageBox.Show("El numero de DNI ingresado es demasiado largo, ingrese un numero de DNI posible.\n\nEJ:46495234", "ERROR");
                return;
            }

            if (variable == "A")
            {
                if (!ValidaDniYNombre())
                {
                    MessageBox.Show("Este cliente no se encuentra registrado en el sistema.\n\nPara poder continuar, el cliente debe ser registrado", "ERROR");
                    return;
                }

                if (cb_tipo.Text == "Caja de ahorro")
                {
                    if (Validacaja())
                    {
                        MessageBox.Show("Este cliente ya tiene una caja de ahorro registrada a su nombre.\n\nSolo es posible tener una cuenta de cada tipo por persona.", "ERROR");
                        return;
                    }
                }
                else if (cb_tipo.Text == "Cuenta corriente")
                {
                    if (ValidaCuentaCorriente())
                    {
                        MessageBox.Show("Este cliente ya tiene una cuenta corriente registrada a su nombre.\n\nSolo es posible tener una cuenta de cada tipo por persona.", "ERROR");
                        return;
                    }
                }
            }


            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Ingrese correctamente el nombre del titular de la cuenta", "ERROR");
                return;
            }

            bool ValidaLetras()
            {
                return textBox3.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
            }

            if(!ValidaLetras())
            {
                MessageBox.Show("Ingrese correctamente el nombre del titular de la cuenta.\n\nEste solo debe contener letras", "ERROR");
                return;
            }

            #endregion

            if (variable == "A")
            {
                if (cb_tipo.Text == "Caja de ahorro")
                {
                    cuenta = new CCaja_de_ahorro();
                }
                else if (cb_tipo.Text == "Cuenta corriente")
                {
                    cuenta = new CCuenta_corriente();
                }

                CCodigos.SumarCont(cb_tipo.Text);

                cuenta.ObtenerCod(cb_tipo.Text);
                cuenta.TIPO = cb_tipo.Text;
                cuenta.DNI = textBox2.Text.Insert(2, ".").Insert(6, ".");
                cuenta.NOMBRE = textBox3.Text;

                clase_listas.Lcuentas.Add(cuenta);
            }

            if (variable == "M")
            {
                cuenta = clase_listas.Lcuentas[indice];
                CARGA(cuenta);             
            }

            ARMA_GRILLA();
            MODO_LISTA();
            LIMPIAR();
            cb_tipo.Enabled = true;
        }

        public void CARGA(CCuentas cuenta)
        {
            cuenta.CODIGO = textBox1.Text;
            cuenta.TIPO = cb_tipo.Text;
            cuenta.DNI = textBox2.Text.Insert(2,".").Insert(6, ".");
            cuenta.NOMBRE = textBox3.Text;
            cuenta.SALDO = Convert.ToDouble(textBox4.Text);
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cb_tipo.Enabled = true;
            MODO_LISTA();
            LIMPIAR();

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una de las cuentas");
                return; 
            }

            indice = dataGridView1.CurrentRow.Index;
            
        }
    }
}
