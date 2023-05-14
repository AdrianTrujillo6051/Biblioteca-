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
            this.label1 = new System.Windows.Forms.Label();
            this.CodigoAlumTXT = new ObjPersonalizados.TextBoxPers();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigAlumTXT = new System.Windows.Forms.Label();
            this.NameAlumTXT = new System.Windows.Forms.Label();
            this.EmailAlumTXT = new System.Windows.Forms.Label();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.Eliminar = new ObjPersonalizados.ButtonDML();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Código de Alumno a buscar:";
            // 
            // CodigoAlumTXT
            // 
            this.CodigoAlumTXT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CodigoAlumTXT.colorBorde = System.Drawing.Color.Empty;
            this.CodigoAlumTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.CodigoAlumTXT.Location = new System.Drawing.Point(383, 24);
            this.CodigoAlumTXT.Name = "CodigoAlumTXT";
            this.CodigoAlumTXT.Padding = new System.Windows.Forms.Padding(7);
            this.CodigoAlumTXT.passCaracter = false;
            this.CodigoAlumTXT.Size = new System.Drawing.Size(245, 36);
            this.CodigoAlumTXT.soloLetras = false;
            this.CodigoAlumTXT.soloNumeros = false;
            this.CodigoAlumTXT.subrayadoEstilo = false;
            this.CodigoAlumTXT.TabIndex = 38;
            this.CodigoAlumTXT.tamanoBorde = 0;
            this.CodigoAlumTXT.textBoxBackColor = System.Drawing.SystemColors.Control;
            this.CodigoAlumTXT.textBoxFontColor = System.Drawing.SystemColors.WindowText;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(25, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(25, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 32);
            this.label3.TabIndex = 40;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(25, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Correo:";
            // 
            // CodigAlumTXT
            // 
            this.CodigAlumTXT.AutoSize = true;
            this.CodigAlumTXT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodigAlumTXT.Location = new System.Drawing.Point(127, 157);
            this.CodigAlumTXT.Name = "CodigAlumTXT";
            this.CodigAlumTXT.Size = new System.Drawing.Size(24, 32);
            this.CodigAlumTXT.TabIndex = 42;
            this.CodigAlumTXT.Text = "-";
            // 
            // NameAlumTXT
            // 
            this.NameAlumTXT.AutoSize = true;
            this.NameAlumTXT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameAlumTXT.Location = new System.Drawing.Point(138, 226);
            this.NameAlumTXT.Name = "NameAlumTXT";
            this.NameAlumTXT.Size = new System.Drawing.Size(24, 32);
            this.NameAlumTXT.TabIndex = 43;
            this.NameAlumTXT.Text = "-";
            // 
            // EmailAlumTXT
            // 
            this.EmailAlumTXT.AutoSize = true;
            this.EmailAlumTXT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailAlumTXT.Location = new System.Drawing.Point(122, 291);
            this.EmailAlumTXT.Name = "EmailAlumTXT";
            this.EmailAlumTXT.Size = new System.Drawing.Size(24, 32);
            this.EmailAlumTXT.TabIndex = 44;
            this.EmailAlumTXT.Text = "-";
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Buscarbtn.Location = new System.Drawing.Point(655, 28);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(94, 32);
            this.Buscarbtn.TabIndex = 45;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = false;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.ForeColor = System.Drawing.Color.White;
            this.Eliminar.Location = new System.Drawing.Point(575, 358);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(150, 40);
            this.Eliminar.TabIndex = 46;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // DMLEliAlum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.EmailAlumTXT);
            this.Controls.Add(this.NameAlumTXT);
            this.Controls.Add(this.CodigAlumTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodigoAlumTXT);
            this.Controls.Add(this.label1);
            this.Name = "DMLEliAlum";
            this.Text = "DMLEliAlum";
            this.ResumeLayout(false);
            this.PerformLayout();

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