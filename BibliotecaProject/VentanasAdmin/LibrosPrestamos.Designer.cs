namespace BibliotecaProject.VentanasUsers
{
    partial class LibrosPrestamos
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
            Formulario = new Panel();
            panelForm = new Panel();
            BTNReturn = new ObjPersonalizados.CircleButton();
            TXTRETIsbn = new ObjPersonalizados.TextBoxDML();
            label11 = new Label();
            TXTRETCod = new ObjPersonalizados.TextBoxDML();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            BTNEnviar = new ObjPersonalizados.CircleButton();
            label2 = new Label();
            TXTFecha = new ObjPersonalizados.TextBoxDML();
            TXTCodAlm = new ObjPersonalizados.TextBoxDML();
            TXTCodAdm = new ObjPersonalizados.TextBoxDML();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            TXTIsbn = new ObjPersonalizados.TextBoxDML();
            label5 = new Label();
            label1 = new Label();
            lblalumn = new Label();
            panelInfo = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            errorForm = new ErrorProvider(components);
            closeBTN = new ObjPersonalizados.CircleButton();
            Formulario.SuspendLayout();
            panelForm.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorForm).BeginInit();
            SuspendLayout();
            // 
            // Formulario
            // 
            Formulario.Anchor = AnchorStyles.Top;
            Formulario.BorderStyle = BorderStyle.FixedSingle;
            Formulario.Controls.Add(panelForm);
            Formulario.Controls.Add(panelInfo);
            Formulario.Location = new Point(214, 50);
            Formulario.Name = "Formulario";
            Formulario.Size = new Size(533, 596);
            Formulario.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.AutoScroll = true;
            panelForm.BackColor = SystemColors.Control;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(BTNReturn);
            panelForm.Controls.Add(TXTRETIsbn);
            panelForm.Controls.Add(label11);
            panelForm.Controls.Add(TXTRETCod);
            panelForm.Controls.Add(label10);
            panelForm.Controls.Add(label8);
            panelForm.Controls.Add(label9);
            panelForm.Controls.Add(BTNEnviar);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(TXTFecha);
            panelForm.Controls.Add(TXTCodAlm);
            panelForm.Controls.Add(TXTCodAdm);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(TXTIsbn);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(lblalumn);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 92);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(531, 502);
            panelForm.TabIndex = 1;
            // 
            // BTNReturn
            // 
            BTNReturn.Admin = false;
            BTNReturn.BackColor = Color.FromArgb(19, 45, 70);
            BTNReturn.borderColor = Color.Empty;
            BTNReturn.borderRadius = 40;
            BTNReturn.borderSize = 0;
            BTNReturn.FlatAppearance.BorderSize = 0;
            BTNReturn.FlatStyle = FlatStyle.Flat;
            BTNReturn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNReturn.ForeColor = Color.WhiteSmoke;
            BTNReturn.Image = Properties.Resources.okk;
            BTNReturn.Location = new Point(329, 691);
            BTNReturn.Name = "BTNReturn";
            BTNReturn.Size = new Size(150, 40);
            BTNReturn.TabIndex = 23;
            BTNReturn.Text = "   Ok";
            BTNReturn.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNReturn.UseVisualStyleBackColor = false;
            BTNReturn.Click += BTNReturn_Click_1;
            // 
            // TXTRETIsbn
            // 
            TXTRETIsbn.BackColor = Color.Transparent;
            TXTRETIsbn.ForeColor = Color.FromArgb(26, 30, 41);
            TXTRETIsbn.Location = new Point(229, 635);
            TXTRETIsbn.Name = "TXTRETIsbn";
            TXTRETIsbn.Padding = new Padding(7);
            TXTRETIsbn.passCaracter = false;
            TXTRETIsbn.Size = new Size(250, 36);
            TXTRETIsbn.soloLetras = false;
            TXTRETIsbn.soloNumeros = true;
            TXTRETIsbn.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(153, 639);
            label11.Name = "label11";
            label11.Size = new Size(70, 32);
            label11.TabIndex = 22;
            label11.Text = "ISBN:";
            // 
            // TXTRETCod
            // 
            TXTRETCod.BackColor = Color.Transparent;
            TXTRETCod.ForeColor = Color.FromArgb(26, 30, 41);
            TXTRETCod.Location = new Point(229, 578);
            TXTRETCod.Name = "TXTRETCod";
            TXTRETCod.Padding = new Padding(7);
            TXTRETCod.passCaracter = false;
            TXTRETCod.Size = new Size(250, 36);
            TXTRETCod.soloLetras = false;
            TXTRETCod.soloNumeros = true;
            TXTRETCod.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(127, 582);
            label10.Name = "label10";
            label10.Size = new Size(96, 32);
            label10.TabIndex = 20;
            label10.Text = "Código:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(19, 45, 70);
            label8.Location = new Point(11, 521);
            label8.Name = "label8";
            label8.Size = new Size(178, 50);
            label8.TabIndex = 18;
            label8.Text = "Devolver";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(19, 45, 70);
            label9.Location = new Point(-1, 2);
            label9.Name = "label9";
            label9.Size = new Size(145, 50);
            label9.TabIndex = 17;
            label9.Text = "Prestar";
            // 
            // BTNEnviar
            // 
            BTNEnviar.Admin = false;
            BTNEnviar.BackColor = Color.FromArgb(19, 45, 70);
            BTNEnviar.borderColor = Color.Empty;
            BTNEnviar.borderRadius = 40;
            BTNEnviar.borderSize = 0;
            BTNEnviar.FlatAppearance.BorderSize = 0;
            BTNEnviar.FlatStyle = FlatStyle.Flat;
            BTNEnviar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNEnviar.ForeColor = Color.WhiteSmoke;
            BTNEnviar.Image = Properties.Resources.okk;
            BTNEnviar.Location = new Point(329, 449);
            BTNEnviar.Name = "BTNEnviar";
            BTNEnviar.Size = new Size(150, 40);
            BTNEnviar.TabIndex = 15;
            BTNEnviar.Text = "   Ok";
            BTNEnviar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNEnviar.UseVisualStyleBackColor = false;
            BTNEnviar.Click += BTNEnviar_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(50, 66);
            label2.Name = "label2";
            label2.Size = new Size(91, 40);
            label2.TabIndex = 6;
            label2.Text = "Libro";
            // 
            // TXTFecha
            // 
            TXTFecha.BackColor = Color.Transparent;
            TXTFecha.ForeColor = Color.FromArgb(26, 30, 41);
            TXTFecha.Location = new Point(229, 361);
            TXTFecha.Name = "TXTFecha";
            TXTFecha.Padding = new Padding(7);
            TXTFecha.passCaracter = false;
            TXTFecha.Size = new Size(250, 36);
            TXTFecha.soloLetras = false;
            TXTFecha.soloNumeros = false;
            TXTFecha.TabIndex = 13;
            // 
            // TXTCodAlm
            // 
            TXTCodAlm.BackColor = Color.Transparent;
            TXTCodAlm.ForeColor = Color.FromArgb(26, 30, 41);
            TXTCodAlm.Location = new Point(229, 202);
            TXTCodAlm.Name = "TXTCodAlm";
            TXTCodAlm.Padding = new Padding(7);
            TXTCodAlm.passCaracter = false;
            TXTCodAlm.Size = new Size(250, 36);
            TXTCodAlm.soloLetras = false;
            TXTCodAlm.soloNumeros = true;
            TXTCodAlm.TabIndex = 7;
            // 
            // TXTCodAdm
            // 
            TXTCodAdm.BackColor = Color.Transparent;
            TXTCodAdm.ForeColor = Color.FromArgb(26, 30, 41);
            TXTCodAdm.Location = new Point(229, 305);
            TXTCodAdm.Name = "TXTCodAdm";
            TXTCodAdm.Padding = new Padding(7);
            TXTCodAdm.passCaracter = false;
            TXTCodAdm.Size = new Size(250, 36);
            TXTCodAdm.soloLetras = false;
            TXTCodAdm.soloNumeros = true;
            TXTCodAdm.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(45, 254);
            label3.Name = "label3";
            label3.Size = new Size(154, 40);
            label3.TabIndex = 12;
            label3.Text = "Prestamo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(127, 206);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 8;
            label4.Text = "Código:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(142, 365);
            label6.Name = "label6";
            label6.Size = new Size(81, 32);
            label6.TabIndex = 14;
            label6.Text = "Fecha:";
            // 
            // TXTIsbn
            // 
            TXTIsbn.BackColor = Color.Transparent;
            TXTIsbn.ForeColor = Color.FromArgb(26, 30, 41);
            TXTIsbn.Location = new Point(229, 109);
            TXTIsbn.Name = "TXTIsbn";
            TXTIsbn.Padding = new Padding(7);
            TXTIsbn.passCaracter = false;
            TXTIsbn.Size = new Size(250, 36);
            TXTIsbn.soloLetras = false;
            TXTIsbn.soloNumeros = true;
            TXTIsbn.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(53, 309);
            label5.Name = "label5";
            label5.Size = new Size(170, 32);
            label5.TabIndex = 11;
            label5.Text = "Código admin:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(153, 113);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 5;
            label1.Text = "ISBN:";
            // 
            // lblalumn
            // 
            lblalumn.AutoSize = true;
            lblalumn.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblalumn.Location = new Point(50, 153);
            lblalumn.Name = "lblalumn";
            lblalumn.Size = new Size(129, 40);
            lblalumn.TabIndex = 9;
            lblalumn.Text = "Alumno";
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(19, 45, 70);
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(label7);
            panelInfo.Controls.Add(pictureBox1);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(531, 92);
            panelInfo.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(11, -1);
            label7.Name = "label7";
            label7.Size = new Size(305, 90);
            label7.TabIndex = 11;
            label7.Text = "Prestar y devolver\r\nlibros\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bookIcon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(427, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 83);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // errorForm
            // 
            errorForm.ContainerControl = this;
            // 
            // closeBTN
            // 
            closeBTN.Admin = false;
            closeBTN.Anchor = AnchorStyles.Top;
            closeBTN.BackColor = Color.FromArgb(26, 30, 41);
            closeBTN.borderColor = Color.Empty;
            closeBTN.borderRadius = 40;
            closeBTN.borderSize = 0;
            closeBTN.FlatAppearance.BorderSize = 0;
            closeBTN.FlatStyle = FlatStyle.Flat;
            closeBTN.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            closeBTN.ForeColor = SystemColors.Control;
            closeBTN.Location = new Point(707, 4);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new Size(40, 40);
            closeBTN.TabIndex = 21;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = false;
            closeBTN.Click += closeBTN_Click_1;
            // 
            // LibrosPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(937, 744);
            Controls.Add(closeBTN);
            Controls.Add(Formulario);
            Name = "LibrosPrestamos";
            Text = "LibrosPrestamos";
            Formulario.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Formulario;
        private ObjPersonalizados.TextBoxDML TXTIsbn;
        private ObjPersonalizados.CircleButton BTNEnviar;
        private Label label6;
        private ObjPersonalizados.TextBoxDML TXTFecha;
        private Label label3;
        private Label label5;
        private ObjPersonalizados.TextBoxDML TXTCodAdm;
        private Label lblalumn;
        private Label label4;
        private ObjPersonalizados.TextBoxDML TXTCodAlm;
        private Label label2;
        private Label label1;
        private Panel panelInfo;
        private Panel panelForm;
        private PictureBox pictureBox1;
        private Label label7;
        private ErrorProvider errorForm;
        private ObjPersonalizados.CircleButton BTNReturn;
        private ObjPersonalizados.TextBoxDML TXTRETIsbn;
        private Label label11;
        private ObjPersonalizados.TextBoxDML TXTRETCod;
        private Label label10;
        private Label label8;
        private Label label9;
        private ObjPersonalizados.CircleButton closeBTN;
    }
}