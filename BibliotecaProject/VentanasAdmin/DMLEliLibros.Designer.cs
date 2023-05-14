namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLEliLibros
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
            this.Eliminarbtn = new ObjPersonalizados.ButtonDML();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.AutorTXT = new System.Windows.Forms.Label();
            this.TituloTXT = new System.Windows.Forms.Label();
            this.ISBNLTXT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ISBNTXT = new ObjPersonalizados.TextBoxPers();
            this.label1 = new System.Windows.Forms.Label();
            this.EditorialTXT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Eliminarbtn.FlatAppearance.BorderSize = 0;
            this.Eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbtn.ForeColor = System.Drawing.Color.White;
            this.Eliminarbtn.Location = new System.Drawing.Point(595, 372);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(150, 40);
            this.Eliminarbtn.TabIndex = 56;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = false;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Buscarbtn.Location = new System.Drawing.Point(651, 42);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(94, 32);
            this.Buscarbtn.TabIndex = 55;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = false;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // AutorTXT
            // 
            this.AutorTXT.AutoSize = true;
            this.AutorTXT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutorTXT.Location = new System.Drawing.Point(143, 242);
            this.AutorTXT.Name = "AutorTXT";
            this.AutorTXT.Size = new System.Drawing.Size(24, 32);
            this.AutorTXT.TabIndex = 54;
            this.AutorTXT.Text = "-";
            // 
            // TituloTXT
            // 
            this.TituloTXT.AutoSize = true;
            this.TituloTXT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TituloTXT.Location = new System.Drawing.Point(143, 177);
            this.TituloTXT.Name = "TituloTXT";
            this.TituloTXT.Size = new System.Drawing.Size(24, 32);
            this.TituloTXT.TabIndex = 53;
            this.TituloTXT.Text = "-";
            // 
            // ISBNLTXT
            // 
            this.ISBNLTXT.AutoSize = true;
            this.ISBNLTXT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ISBNLTXT.Location = new System.Drawing.Point(143, 108);
            this.ISBNLTXT.Name = "ISBNLTXT";
            this.ISBNLTXT.Size = new System.Drawing.Size(24, 32);
            this.ISBNLTXT.TabIndex = 52;
            this.ISBNLTXT.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(32, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 51;
            this.label4.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(32, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 50;
            this.label3.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "ISBN:";
            // 
            // ISBNTXT
            // 
            this.ISBNTXT.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ISBNTXT.colorBorde = System.Drawing.Color.Empty;
            this.ISBNTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.ISBNTXT.Location = new System.Drawing.Point(330, 38);
            this.ISBNTXT.Name = "ISBNTXT";
            this.ISBNTXT.Padding = new System.Windows.Forms.Padding(7);
            this.ISBNTXT.passCaracter = false;
            this.ISBNTXT.Size = new System.Drawing.Size(245, 36);
            this.ISBNTXT.soloLetras = false;
            this.ISBNTXT.soloNumeros = false;
            this.ISBNTXT.subrayadoEstilo = false;
            this.ISBNTXT.TabIndex = 48;
            this.ISBNTXT.tamanoBorde = 0;
            this.ISBNTXT.textBoxBackColor = System.Drawing.SystemColors.Control;
            this.ISBNTXT.textBoxFontColor = System.Drawing.SystemColors.WindowText;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 36);
            this.label1.TabIndex = 47;
            this.label1.Text = "ISBN de libro a buscar:";
            // 
            // EditorialTXT
            // 
            this.EditorialTXT.AutoSize = true;
            this.EditorialTXT.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditorialTXT.Location = new System.Drawing.Point(143, 304);
            this.EditorialTXT.Name = "EditorialTXT";
            this.EditorialTXT.Size = new System.Drawing.Size(24, 32);
            this.EditorialTXT.TabIndex = 58;
            this.EditorialTXT.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(32, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 32);
            this.label6.TabIndex = 57;
            this.label6.Text = "Editorial:";
            // 
            // DMLEliLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditorialTXT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.AutorTXT);
            this.Controls.Add(this.TituloTXT);
            this.Controls.Add(this.ISBNLTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ISBNTXT);
            this.Controls.Add(this.label1);
            this.Name = "DMLEliLibros";
            this.Text = "DMLEliLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ObjPersonalizados.ButtonDML Eliminarbtn;
        private Button Buscarbtn;
        private Label AutorTXT;
        private Label TituloTXT;
        private Label ISBNLTXT;
        private Label label4;
        private Label label3;
        private Label label2;
        private ObjPersonalizados.TextBoxPers ISBNTXT;
        private Label label1;
        private Label EditorialTXT;
        private Label label6;
    }
}