﻿using System;
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
    public partial class Form_cuentas : Form
    {
        string variable;
        
        public Form_cuentas()
        {
            InitializeComponent();
            MODO_LISTA();
            textBox3.Enabled = false;
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            variable = "A";
            MODO_CARGA();
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
