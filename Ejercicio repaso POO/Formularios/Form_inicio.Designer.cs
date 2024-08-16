namespace Ejercicio_repaso_POO.Formularios
{
    partial class Form_inicio
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
            cb_opc = new ComboBox();
            label1 = new Label();
            btn_aceptar = new Button();
            btn_cerrar = new Button();
            SuspendLayout();
            // 
            // cb_opc
            // 
            cb_opc.FormattingEnabled = true;
            cb_opc.Location = new Point(12, 49);
            cb_opc.Name = "cb_opc";
            cb_opc.Size = new Size(124, 23);
            cb_opc.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 1;
            label1.Text = "Selección de opciones";
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(12, 105);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Location = new Point(188, 105);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(75, 23);
            btn_cerrar.TabIndex = 3;
            btn_cerrar.Text = "Cerrar";
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // Form_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 140);
            Controls.Add(btn_cerrar);
            Controls.Add(btn_aceptar);
            Controls.Add(label1);
            Controls.Add(cb_opc);
            Name = "Form_inicio";
            Text = "Form_inicio";
            Load += Form_inicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_opc;
        private Label label1;
        private Button btn_aceptar;
        private Button btn_cerrar;
    }
}