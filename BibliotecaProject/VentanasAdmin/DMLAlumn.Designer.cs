namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLAlumn
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
            SaveAlBtn = new ObjPersonalizados.ButtonDML();
            label1 = new Label();
            textBoxdml1 = new ObjPersonalizados.TextBoxDML();
            label2 = new Label();
            textBoxdml2 = new ObjPersonalizados.TextBoxDML();
            label3 = new Label();
            textBoxdml3 = new ObjPersonalizados.TextBoxDML();
            SuspendLayout();
            // 
            // SaveAlBtn
            // 
            SaveAlBtn.BackColor = Color.FromArgb(106, 110, 121);
            SaveAlBtn.FlatAppearance.BorderSize = 0;
            SaveAlBtn.FlatStyle = FlatStyle.Flat;
            SaveAlBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveAlBtn.ForeColor = Color.White;
            SaveAlBtn.Image = Properties.Resources.yes;
            SaveAlBtn.ImageAlign = ContentAlignment.MiddleLeft;
            SaveAlBtn.Location = new Point(270, 257);
            SaveAlBtn.Name = "SaveAlBtn";
            SaveAlBtn.Size = new Size(150, 40);
            SaveAlBtn.TabIndex = 5;
            SaveAlBtn.Text = "     Guardar";
            SaveAlBtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(68, 47);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 4;
            label1.Text = "Código:";
            // 
            // textBoxdml1
            // 
            textBoxdml1.BackColor = Color.Transparent;
            textBoxdml1.ForeColor = Color.FromArgb(26, 30, 41);
            textBoxdml1.Location = new Point(170, 43);
            textBoxdml1.Name = "textBoxdml1";
            textBoxdml1.Padding = new Padding(7);
            textBoxdml1.passCaracter = false;
            textBoxdml1.Size = new Size(250, 36);
            textBoxdml1.soloLetras = false;
            textBoxdml1.soloNumeros = true;
            textBoxdml1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 89);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 7;
            label2.Text = "Nombre:";
            // 
            // textBoxdml2
            // 
            textBoxdml2.BackColor = Color.Transparent;
            textBoxdml2.ForeColor = Color.FromArgb(26, 30, 41);
            textBoxdml2.Location = new Point(170, 85);
            textBoxdml2.Name = "textBoxdml2";
            textBoxdml2.Padding = new Padding(7);
            textBoxdml2.passCaracter = false;
            textBoxdml2.Size = new Size(250, 36);
            textBoxdml2.soloLetras = false;
            textBoxdml2.soloNumeros = true;
            textBoxdml2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 131);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 9;
            label3.Text = "Cumpleaños:\r\n";
            // 
            // textBoxdml3
            // 
            textBoxdml3.BackColor = Color.Transparent;
            textBoxdml3.ForeColor = Color.FromArgb(26, 30, 41);
            textBoxdml3.Location = new Point(170, 127);
            textBoxdml3.Name = "textBoxdml3";
            textBoxdml3.Padding = new Padding(7);
            textBoxdml3.passCaracter = false;
            textBoxdml3.Size = new Size(250, 36);
            textBoxdml3.soloLetras = false;
            textBoxdml3.soloNumeros = true;
            textBoxdml3.TabIndex = 8;
            // 
            // DMLAlumn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBoxdml3);
            Controls.Add(label2);
            Controls.Add(textBoxdml2);
            Controls.Add(SaveAlBtn);
            Controls.Add(label1);
            Controls.Add(textBoxdml1);
            Name = "DMLAlumn";
            Text = "DMLAlumn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ObjPersonalizados.ButtonDML SaveAlBtn;
        private Label label1;
        private ObjPersonalizados.TextBoxDML textBoxdml1;
        private Label label2;
        private ObjPersonalizados.TextBoxDML textBoxdml2;
        private Label label3;
        private ObjPersonalizados.TextBoxDML textBoxdml3;
    }
}