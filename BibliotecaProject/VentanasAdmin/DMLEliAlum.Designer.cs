namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLEliAlum
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
            label1 = new Label();
            CodigoAlumTXT = new ObjPersonalizados.TextBoxPers();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CodigAlumTXT = new Label();
            NameAlumTXT = new Label();
            EmailAlumTXT = new Label();
            Buscarbtn = new Button();
            Eliminar = new ObjPersonalizados.ButtonDML();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(338, 36);
            label1.TabIndex = 37;
            label1.Text = "Código de Alumno a buscar:";
            // 
            // CodigoAlumTXT
            // 
            CodigoAlumTXT.BackColor = Color.DarkSlateGray;
            CodigoAlumTXT.colorBorde = Color.Empty;
            CodigoAlumTXT.ForeColor = Color.FromArgb(26, 30, 41);
            CodigoAlumTXT.Location = new Point(383, 24);
            CodigoAlumTXT.Name = "CodigoAlumTXT";
            CodigoAlumTXT.Padding = new Padding(7);
            CodigoAlumTXT.passCaracter = false;
            CodigoAlumTXT.Size = new Size(245, 36);
            CodigoAlumTXT.soloLetras = false;
            CodigoAlumTXT.soloNumeros = false;
            CodigoAlumTXT.subrayadoEstilo = false;
            CodigoAlumTXT.TabIndex = 38;
            CodigoAlumTXT.tamanoBorde = 0;
            CodigoAlumTXT.textBoxBackColor = SystemColors.Control;
            CodigoAlumTXT.textBoxFontColor = SystemColors.WindowText;
            CodigoAlumTXT.Load += CodigoAlumTXT_Load;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(25, 157);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 39;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(25, 226);
            label3.Name = "label3";
            label3.Size = new Size(107, 32);
            label3.TabIndex = 40;
            label3.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(25, 291);
            label4.Name = "label4";
            label4.Size = new Size(91, 32);
            label4.TabIndex = 41;
            label4.Text = "Correo:";
            // 
            // CodigAlumTXT
            // 
            CodigAlumTXT.AutoSize = true;
            CodigAlumTXT.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CodigAlumTXT.Location = new Point(127, 157);
            CodigAlumTXT.Name = "CodigAlumTXT";
            CodigAlumTXT.Size = new Size(24, 32);
            CodigAlumTXT.TabIndex = 42;
            CodigAlumTXT.Text = "-";
            // 
            // NameAlumTXT
            // 
            NameAlumTXT.AutoSize = true;
            NameAlumTXT.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            NameAlumTXT.Location = new Point(138, 226);
            NameAlumTXT.Name = "NameAlumTXT";
            NameAlumTXT.Size = new Size(24, 32);
            NameAlumTXT.TabIndex = 43;
            NameAlumTXT.Text = "-";
            // 
            // EmailAlumTXT
            // 
            EmailAlumTXT.AutoSize = true;
            EmailAlumTXT.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            EmailAlumTXT.Location = new Point(122, 291);
            EmailAlumTXT.Name = "EmailAlumTXT";
            EmailAlumTXT.Size = new Size(24, 32);
            EmailAlumTXT.TabIndex = 44;
            EmailAlumTXT.Text = "-";
            // 
            // Buscarbtn
            // 
            Buscarbtn.BackColor = SystemColors.GradientInactiveCaption;
            Buscarbtn.Location = new Point(655, 28);
            Buscarbtn.Name = "Buscarbtn";
            Buscarbtn.Size = new Size(94, 32);
            Buscarbtn.TabIndex = 45;
            Buscarbtn.Text = "Buscar";
            Buscarbtn.UseVisualStyleBackColor = false;
            Buscarbtn.Click += Buscarbtn_Click;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(128, 128, 255);
            Eliminar.FlatAppearance.BorderSize = 0;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.ForeColor = Color.White;
            Eliminar.Location = new Point(575, 358);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(150, 40);
            Eliminar.TabIndex = 46;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // DMLEliAlum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Eliminar);
            Controls.Add(Buscarbtn);
            Controls.Add(EmailAlumTXT);
            Controls.Add(NameAlumTXT);
            Controls.Add(CodigAlumTXT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CodigoAlumTXT);
            Controls.Add(label1);
            Name = "DMLEliAlum";
            Text = "DMLEliAlum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ObjPersonalizados.TextBoxPers CodigoAlumTXT;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label CodigAlumTXT;
        private Label NameAlumTXT;
        private Label EmailAlumTXT;
        private Button Buscarbtn;
        private ObjPersonalizados.ButtonDML Eliminar;
    }
}