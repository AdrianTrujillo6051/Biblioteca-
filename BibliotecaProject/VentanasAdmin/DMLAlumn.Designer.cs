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
            components = new System.ComponentModel.Container();
            label4 = new Label();
            correoAlumnoTXT = new ObjPersonalizados.TextBoxDML();
            label5 = new Label();
            label6 = new Label();
            NSSAlumnoTXT = new ObjPersonalizados.TextBoxDML();
            label3 = new Label();
            label2 = new Label();
            nombreAlumnoTXT = new ObjPersonalizados.TextBoxDML();
            SaveAlBtn = new ObjPersonalizados.ButtonDML();
            label1 = new Label();
            codigoAlumnoTXT = new ObjPersonalizados.TextBoxDML();
            telefonoAlumnoTXT = new ObjPersonalizados.TextBoxDML();
            pictureBox1 = new PictureBox();
            errorPA = new ErrorProvider(components);
            datexd = new DateTimePicker();
            lblFecha = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorPA).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 256);
            label4.Name = "label4";
            label4.Size = new Size(227, 32);
            label4.TabIndex = 50;
            label4.Text = "Correo Institucional:\r\n";
            // 
            // correoAlumnoTXT
            // 
            correoAlumnoTXT.BackColor = Color.Transparent;
            correoAlumnoTXT.ForeColor = Color.FromArgb(26, 30, 41);
            correoAlumnoTXT.Location = new Point(311, 252);
            correoAlumnoTXT.Name = "correoAlumnoTXT";
            correoAlumnoTXT.Padding = new Padding(7);
            correoAlumnoTXT.passCaracter = false;
            correoAlumnoTXT.Size = new Size(271, 36);
            correoAlumnoTXT.soloLetras = false;
            correoAlumnoTXT.soloNumeros = false;
            correoAlumnoTXT.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(193, 210);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 48;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(242, 167);
            label6.Name = "label6";
            label6.Size = new Size(63, 32);
            label6.TabIndex = 46;
            label6.Text = "NSS:";
            // 
            // NSSAlumnoTXT
            // 
            NSSAlumnoTXT.BackColor = Color.Transparent;
            NSSAlumnoTXT.ForeColor = Color.FromArgb(26, 30, 41);
            NSSAlumnoTXT.Location = new Point(311, 163);
            NSSAlumnoTXT.Name = "NSSAlumnoTXT";
            NSSAlumnoTXT.Padding = new Padding(7);
            NSSAlumnoTXT.passCaracter = false;
            NSSAlumnoTXT.Size = new Size(271, 36);
            NSSAlumnoTXT.soloLetras = false;
            NSSAlumnoTXT.soloNumeros = true;
            NSSAlumnoTXT.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(153, 125);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 41;
            label3.Text = "Cumpleaños:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(198, 79);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 39;
            label2.Text = "Nombre:";
            // 
            // nombreAlumnoTXT
            // 
            nombreAlumnoTXT.BackColor = Color.Transparent;
            nombreAlumnoTXT.ForeColor = Color.FromArgb(26, 30, 41);
            nombreAlumnoTXT.Location = new Point(311, 79);
            nombreAlumnoTXT.Name = "nombreAlumnoTXT";
            nombreAlumnoTXT.Padding = new Padding(7);
            nombreAlumnoTXT.passCaracter = false;
            nombreAlumnoTXT.Size = new Size(271, 36);
            nombreAlumnoTXT.soloLetras = true;
            nombreAlumnoTXT.soloNumeros = false;
            nombreAlumnoTXT.TabIndex = 38;
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
            SaveAlBtn.Location = new Point(329, 333);
            SaveAlBtn.Name = "SaveAlBtn";
            SaveAlBtn.Size = new Size(150, 40);
            SaveAlBtn.TabIndex = 37;
            SaveAlBtn.Text = "     Guardar";
            SaveAlBtn.UseVisualStyleBackColor = false;
            SaveAlBtn.Click += SaveAlBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 37);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 36;
            label1.Text = "Código:";
            // 
            // codigoAlumnoTXT
            // 
            codigoAlumnoTXT.BackColor = Color.Transparent;
            codigoAlumnoTXT.ForeColor = Color.FromArgb(26, 30, 41);
            codigoAlumnoTXT.Location = new Point(311, 37);
            codigoAlumnoTXT.Name = "codigoAlumnoTXT";
            codigoAlumnoTXT.Padding = new Padding(7);
            codigoAlumnoTXT.passCaracter = false;
            codigoAlumnoTXT.Size = new Size(271, 36);
            codigoAlumnoTXT.soloLetras = false;
            codigoAlumnoTXT.soloNumeros = true;
            codigoAlumnoTXT.TabIndex = 35;
            codigoAlumnoTXT.Load += codigoAlumnoTXT_Load;
            // 
            // telefonoAlumnoTXT
            // 
            telefonoAlumnoTXT.BackColor = Color.Transparent;
            telefonoAlumnoTXT.ForeColor = Color.FromArgb(26, 30, 41);
            telefonoAlumnoTXT.Location = new Point(311, 210);
            telefonoAlumnoTXT.Name = "telefonoAlumnoTXT";
            telefonoAlumnoTXT.Padding = new Padding(7);
            telefonoAlumnoTXT.passCaracter = false;
            telefonoAlumnoTXT.Size = new Size(271, 36);
            telefonoAlumnoTXT.soloLetras = false;
            telefonoAlumnoTXT.soloNumeros = false;
            telefonoAlumnoTXT.TabIndex = 51;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.alumn;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(652, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 193);
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // errorPA
            // 
            errorPA.ContainerControl = this;
            // 
            // datexd
            // 
            datexd.CustomFormat = "yyyy-MM-dd";
            datexd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            datexd.Format = DateTimePickerFormat.Custom;
            datexd.Location = new Point(311, 134);
            datexd.Name = "datexd";
            datexd.Size = new Size(298, 39);
            datexd.TabIndex = 73;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(707, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(22, 15);
            lblFecha.TabIndex = 90;
            lblFecha.Text = "XD";
            lblFecha.Visible = false;
            // 
            // DMLAlumn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(916, 422);
            Controls.Add(lblFecha);
            Controls.Add(datexd);
            Controls.Add(pictureBox1);
            Controls.Add(telefonoAlumnoTXT);
            Controls.Add(label4);
            Controls.Add(correoAlumnoTXT);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(NSSAlumnoTXT);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(nombreAlumnoTXT);
            Controls.Add(SaveAlBtn);
            Controls.Add(label1);
            Controls.Add(codigoAlumnoTXT);
            Name = "DMLAlumn";
            Text = "DMLAlumn";
            Load += DMLAlumn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorPA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private ObjPersonalizados.TextBoxDML correoAlumnoTXT;
        private Label label5;
        private Label label6;
        private ObjPersonalizados.TextBoxDML NSSAlumnoTXT;
        private Label label3;
        private Label label2;
        private ObjPersonalizados.TextBoxDML nombreAlumnoTXT;
        private ObjPersonalizados.ButtonDML SaveAlBtn;
        private Label label1;
        private ObjPersonalizados.TextBoxDML codigoAlumnoTXT;
        private ObjPersonalizados.TextBoxDML telefonoAlumnoTXT;
        private PictureBox pictureBox1;
        private ErrorProvider Validacion;
        private ErrorProvider validar;
        private ErrorProvider valialum;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorPA;
        private DateTimePicker datexd;
        private Label lblFecha;
    }
}