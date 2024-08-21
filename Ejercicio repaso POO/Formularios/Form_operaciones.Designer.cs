namespace Ejercicio_repaso_POO.Formularios
{
    partial class Form_operaciones
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
            btn_ope = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            btn_cancelar = new Button();
            btn_guardar = new Button();
            cb_tipo = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_volver);
            groupBox1.Controls.Add(btn_ope);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(849, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listado de operaciones";
            // 
            // btn_volver
            // 
            btn_volver.Location = new Point(704, 382);
            btn_volver.Name = "btn_volver";
            btn_volver.Size = new Size(139, 29);
            btn_volver.TabIndex = 3;
            btn_volver.Text = "Volver";
            btn_volver.UseVisualStyleBackColor = true;
            btn_volver.Click += btn_volver_Click;
            // 
            // btn_ope
            // 
            btn_ope.Location = new Point(17, 382);
            btn_ope.Name = "btn_ope";
            btn_ope.Size = new Size(139, 29);
            btn_ope.TabIndex = 2;
            btn_ope.Text = "Realizar operación";
            btn_ope.UseVisualStyleBackColor = true;
            btn_ope.Click += btn_ope_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(837, 339);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_cancelar);
            groupBox2.Controls.Add(btn_guardar);
            groupBox2.Controls.Add(cb_tipo);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(867, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Carga de datos";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(236, 380);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(96, 33);
            btn_cancelar.TabIndex = 13;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(6, 380);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(96, 33);
            btn_guardar.TabIndex = 12;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // cb_tipo
            // 
            cb_tipo.FormattingEnabled = true;
            cb_tipo.Location = new Point(172, 137);
            cb_tipo.Name = "cb_tipo";
            cb_tipo.Size = new Size(121, 23);
            cb_tipo.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 171);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(172, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 23);
            textBox3.TabIndex = 7;
            textBox3.Text = "//";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(172, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(109, 23);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 174);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 4;
            label5.Text = "Importe de operación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 140);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo de operación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de operación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI del dueño";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo de operación";
            // 
            // Form_operaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form_operaciones";
            Text = "Form_operaciones";
            Load += Form_operaciones_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btn_volver;
        private Button btn_ope;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label5;
        private ComboBox cb_tipo;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button btn_guardar;
        private Button btn_cancelar;
    }
}