namespace Ejercicio_repaso_POO.Formularios
{
    partial class Form_clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btn_volver = new Button();
            btn_eliminar = new Button();
            btn_mod = new Button();
            btn_agregar = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_volver);
            groupBox1.Controls.Add(btn_eliminar);
            groupBox1.Controls.Add(btn_mod);
            groupBox1.Controls.Add(btn_agregar);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(897, 401);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de clientes";
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(752, 366);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(139, 29);
            btn_volver.TabIndex = 4;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(342, 366);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(139, 29);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar cliente";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_mod
            // 
            btn_mod.Location = new Point(175, 366);
            btn_mod.Name = "btn_mod";
            btn_mod.Size = new Size(139, 29);
            btn_mod.TabIndex = 2;
            btn_mod.Text = "Modificar cliente";
            btn_mod.UseVisualStyleBackColor = true;
            btn_mod.Click += btn_mod_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(6, 366);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(139, 29);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar cliente";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(885, 324);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_cancelar);
            groupBox2.Controls.Add(btn_guardar);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(915, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(301, 401);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Carga de datos";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(199, 349);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(96, 33);
            btn_cancelar.TabIndex = 12;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(6, 349);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(96, 33);
            btn_guardar.TabIndex = 11;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(157, 222);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(116, 23);
            textBox6.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(157, 187);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(116, 23);
            textBox5.TabIndex = 10;
            textBox5.Text = "//";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(157, 151);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(116, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(157, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(116, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(157, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(116, 23);
            textBox2.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 225);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 6;
            label6.Text = "Edad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 190);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 5;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 154);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 114);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 76);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // Form_clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 425);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_clientes";
            Text = "Form_clientes";
            Load += Form_clientes_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btn_agregar;
        private Button btn_volver;
        private Button btn_eliminar;
        private Button btn_mod;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Button btn_guardar;
        private Button btn_cancelar;
    }
}