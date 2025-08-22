namespace Ejercicio2
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            tbDNI = new TextBox();
            tbNombre = new TextBox();
            label2 = new Label();
            Nombre = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(216, 172);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 29);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(35, 172);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(119, 29);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // tbDNI
            // 
            tbDNI.Location = new Point(216, 103);
            tbDNI.Name = "tbDNI";
            tbDNI.Size = new Size(125, 27);
            tbDNI.TabIndex = 9;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(216, 38);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(125, 27);
            tbNombre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 106);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 7;
            label2.Text = "DNI";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(35, 38);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 6;
            Nombre.Text = "Nombre";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 219);
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

        public Button btnCancelar;
        public Button btnAceptar;
        public TextBox tbDNI;
        public TextBox tbNombre;
        private Label label2;
        private Label Nombre;
    }
}