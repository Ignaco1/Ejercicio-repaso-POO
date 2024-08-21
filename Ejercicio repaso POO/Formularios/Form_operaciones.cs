using Ejercicio_repaso_POO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_repaso_POO.Formularios
{
    public partial class Form_operaciones : Form
    {
        CListas clase_listas;
        double importeEX = 50000;
        double importeEXD = -55000;
        public Form_operaciones(CListas listas)
        {
            InitializeComponent();

            clase_listas = listas;
            MODO_LISTA();
            textBox1.Enabled = false;
        }

        private void Form_operaciones_Load(object sender, EventArgs e)
        {
            cb_tipo_ope.Items.Add("Extracción");
            cb_tipo_ope.Items.Add("Deposito");
            cb_tipo_cue.Items.Add("Cuenta corriente");
            cb_tipo_cue.Items.Add("Caja de ahorro");
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
            cb_tipo_ope.Text = "";
            cb_tipo_cue.Text = "";
            textBox3.Text = "";
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

            bool ValidaCuenta()
            {
                string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");

                foreach (CCuentas cuentas in clase_listas.Lcuentas)
                {
                    if (cuentas.DNI == dni)
                    {
                        return true;
                    }
                }

                return false;
            }

            if (!ValidaCuenta())
            {
                MessageBox.Show("Este cliente no posee una cuenta registrada en el sistema.\n\nPara poder continuar, el cliente debe adquirir una cuenta.", "ERROR");
                return;
            }

            bool ValidaDNIyCC()
            {
                string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");
                string cuenta = cb_tipo_cue.Text;

                foreach (CCuentas cuentas in clase_listas.Lcuentas)
                {
                    if (cuentas.DNI == dni && cuentas.TIPO.Equals(cuenta, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }

                return false;
            }

            bool ValidaDNIyCDA()
            {
                string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");
                string cuenta = cb_tipo_cue.Text;

                foreach (CCuentas cuentas in clase_listas.Lcuentas)
                {
                    if (cuentas.DNI == dni && cuentas.TIPO.Equals(cuenta, StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                }

                return false;
            }

            if (cb_tipo_cue.Text == "Cuenta corriente")
            {
                if (!ValidaDNIyCC())
                {
                    MessageBox.Show("Este cliente no posee una cuenta corrinte registrada en el sistema.\n\nPara poder continuar, el cliente debe adquirir una cuenta corriente.", "ERROR");
                    return;
                }
            }
            
            else if (cb_tipo_cue.Text == "Caja de ahorro")
            {
                if (!ValidaDNIyCDA())
                {
                    MessageBox.Show("Este cliente no posee una caja de ahorro registrada en el sistema.\n\nPara poder continuar, el cliente debe adquirir una caja de ahorro.", "ERROR");
                    return;
                }
            }
            
            if (cb_tipo_cue.Text == "Caja de ahorro" && cb_tipo_ope.Text == "Extracción")
            {
                string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");
                string cuenta = cb_tipo_cue.Text;

                foreach (CCuentas cuentas in clase_listas.Lcuentas)
                {
                    if (cuentas.DNI == dni && cuentas.TIPO.Equals(cuenta, StringComparison.OrdinalIgnoreCase))
                    {
                        double saldo = cuentas.SALDO;
                        double importe = Convert.ToDouble(textBox3.Text);
                        double cantidad = saldo - importe;

                        MessageBox.Show($"Saldo {saldo}, importe: {importe}");
                        MessageBox.Show($"total: {cantidad}");

                        if (cuentas.SALDO == 0)
                        {
                            MessageBox.Show("Usted no posee saldo suficiente para realizar una extracción.\n\nSaldo de la cuenta = $ " + cuentas.SALDO);
                            return;
                        }
                        else if (cantidad < 0)
                        {
                            MessageBox.Show("Usted no posee saldo suficiente para realizar esta extracción.\n\nSaldo de la cuenta = $ " + cuentas.SALDO);
                            return;
                        }
                        else if (Convert.ToDouble(textBox3.Text) > importeEX)
                        {
                            MessageBox.Show("No es posible realizar esta operación.\n\nEsta operacion supera el monto maximo permitido por extracción.\n\nmonto maximo permitido por extracción = $ " + importeEX);
                            return;
                        }
                    }
                }
            }

            if (cb_tipo_cue.Text == "Cuenta corriente" && cb_tipo_ope.Text == "Extracción")
            {
                string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");
                string cuenta = cb_tipo_cue.Text;

                foreach (CCuentas cuentas in clase_listas.Lcuentas)
                {
                    if (cuentas.DNI == dni && cuentas.TIPO.Equals(cuenta, StringComparison.OrdinalIgnoreCase))
                    {
                        double saldo = cuentas.SALDO;
                        double importe = Convert.ToDouble(textBox3.Text);
                        double cantidad = saldo - importe;

                        if (cantidad < importeEXD)
                        {
                            MessageBox.Show("No es posible realizar esta operación.\n\nEsta operacion supera el límite de extracción en descubierto.\n\nlímite maximo de extracción en descubierto = $ " + importeEXD);
                            return;
                        }
                    }
                }
            }
            #endregion

            CCodigos.SumarContOpe(cb_tipo_ope.Text);
            
            operaciones.CODIGO = CCodigos.CodigoOperacion(cb_tipo_ope.Text);
            operaciones.DNI = textBox2.Text;
            operaciones.TIPO_CUENTA = cb_tipo_cue.Text;
            operaciones.TIPO_OPERACION = cb_tipo_ope.Text;
            operaciones.IMPORTE = Convert.ToDouble(textBox3.Text);

            clase_listas.Loperaciones.Add(operaciones);

            foreach (CCuentas cuentas in clase_listas.Lcuentas)
            {
                string dni = textBox2.Text.Insert(2, ".").Insert(6, ".");
                string cuenta = cb_tipo_cue.Text;

                if (cuentas.DNI == dni && cuentas.TIPO.Equals(cuenta, StringComparison.OrdinalIgnoreCase))
                {
                    if (cb_tipo_ope.Text == "Extracción")
                    {
                        cuentas.SALDO = cuentas.SALDO - operaciones.IMPORTE;
                    }
                    else if (cb_tipo_ope.Text == "Deposito")
                    {
                        cuentas.SALDO = cuentas.SALDO + operaciones.IMPORTE;
                    }
                }
            }

            ARMA_GRILLA();
            MODO_LISTA();
            LIMPIAR();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            MODO_LISTA();
            LIMPIAR();
        }
    }
}
