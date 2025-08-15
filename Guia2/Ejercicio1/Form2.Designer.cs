namespace Ejercicio1
{
    partial class Form2
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
            Nombre = new Label();
            label2 = new Label();
            tbNombre = new TextBox();
            tbDNI = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(65, 42);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 110);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(246, 42);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 2;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(246, 107);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(125, 27);
            tbDNI.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(65, 176);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(119, 29);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(246, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 237);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tbDNI);
            Controls.Add(tbNombre);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label label2;
        private TextBox textBox2;
        public TextBox tbNombre;
        public TextBox tbDNI;
        public Button btnAceptar;
        public Button btnCancelar;
    }
}