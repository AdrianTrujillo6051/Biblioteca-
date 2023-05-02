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
            this.components = new System.ComponentModel.Container();
            this.Formulario = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.BTNReturn = new ObjPersonalizados.CircleButton();
            this.TXTRETIsbn = new ObjPersonalizados.TextBoxDML();
            this.label11 = new System.Windows.Forms.Label();
            this.TXTRETCod = new ObjPersonalizados.TextBoxDML();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BTNEnviar = new ObjPersonalizados.CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTFecha = new ObjPersonalizados.TextBoxDML();
            this.TXTCodAlm = new ObjPersonalizados.TextBoxDML();
            this.TXTCodAdm = new ObjPersonalizados.TextBoxDML();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTIsbn = new ObjPersonalizados.TextBoxDML();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblalumn = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.closeBTN = new ObjPersonalizados.CircleButton();
            this.Formulario.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorForm)).BeginInit();
            this.SuspendLayout();
            // 
            // Formulario
            // 
            this.Formulario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Formulario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Formulario.Controls.Add(this.panelForm);
            this.Formulario.Controls.Add(this.panelInfo);
            this.Formulario.Location = new System.Drawing.Point(214, 50);
            this.Formulario.Name = "Formulario";
            this.Formulario.Size = new System.Drawing.Size(533, 391);
            this.Formulario.TabIndex = 0;
            // 
            // panelForm
            // 
            this.panelForm.AutoScroll = true;
            this.panelForm.BackColor = System.Drawing.SystemColors.Control;
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.BTNReturn);
            this.panelForm.Controls.Add(this.TXTRETIsbn);
            this.panelForm.Controls.Add(this.label11);
            this.panelForm.Controls.Add(this.TXTRETCod);
            this.panelForm.Controls.Add(this.label10);
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.label9);
            this.panelForm.Controls.Add(this.BTNEnviar);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.TXTFecha);
            this.panelForm.Controls.Add(this.TXTCodAlm);
            this.panelForm.Controls.Add(this.TXTCodAdm);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.TXTIsbn);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Controls.Add(this.lblalumn);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 92);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(531, 297);
            this.panelForm.TabIndex = 1;
            // 
            // BTNReturn
            // 
            this.BTNReturn.Admin = false;
            this.BTNReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BTNReturn.borderColor = System.Drawing.Color.Empty;
            this.BTNReturn.borderRadius = 40;
            this.BTNReturn.borderSize = 0;
            this.BTNReturn.FlatAppearance.BorderSize = 0;
            this.BTNReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNReturn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BTNReturn.Image = global::BibliotecaProject.Properties.Resources.okk;
            this.BTNReturn.Location = new System.Drawing.Point(329, 691);
            this.BTNReturn.Name = "BTNReturn";
            this.BTNReturn.Size = new System.Drawing.Size(150, 40);
            this.BTNReturn.TabIndex = 23;
            this.BTNReturn.Text = "   Ok";
            this.BTNReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNReturn.UseVisualStyleBackColor = false;
            // 
            // TXTRETIsbn
            // 
            this.TXTRETIsbn.BackColor = System.Drawing.Color.Transparent;
            this.TXTRETIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.TXTRETIsbn.Location = new System.Drawing.Point(229, 635);
            this.TXTRETIsbn.Name = "TXTRETIsbn";
            this.TXTRETIsbn.Padding = new System.Windows.Forms.Padding(7);
            this.TXTRETIsbn.passCaracter = false;
            this.TXTRETIsbn.Size = new System.Drawing.Size(250, 36);
            this.TXTRETIsbn.soloLetras = false;
            this.TXTRETIsbn.soloNumeros = true;
            this.TXTRETIsbn.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(153, 639);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 32);
            this.label11.TabIndex = 22;
            this.label11.Text = "ISBN:";
            // 
            // TXTRETCod
            // 
            this.TXTRETCod.BackColor = System.Drawing.Color.Transparent;
            this.TXTRETCod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.TXTRETCod.Location = new System.Drawing.Point(229, 578);
            this.TXTRETCod.Name = "TXTRETCod";
            this.TXTRETCod.Padding = new System.Windows.Forms.Padding(7);
            this.TXTRETCod.passCaracter = false;
            this.TXTRETCod.Size = new System.Drawing.Size(250, 36);
            this.TXTRETCod.soloLetras = false;
            this.TXTRETCod.soloNumeros = true;
            this.TXTRETCod.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(127, 582);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.label8.Location = new System.Drawing.Point(11, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 50);
            this.label8.TabIndex = 18;
            this.label8.Text = "Devolver";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.label9.Location = new System.Drawing.Point(-1, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 50);
            this.label9.TabIndex = 17;
            this.label9.Text = "Prestar";
            // 
            // BTNEnviar
            // 
            this.BTNEnviar.Admin = false;
            this.BTNEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.BTNEnviar.borderColor = System.Drawing.Color.Empty;
            this.BTNEnviar.borderRadius = 40;
            this.BTNEnviar.borderSize = 0;
            this.BTNEnviar.FlatAppearance.BorderSize = 0;
            this.BTNEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEnviar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTNEnviar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BTNEnviar.Image = global::BibliotecaProject.Properties.Resources.okk;
            this.BTNEnviar.Location = new System.Drawing.Point(329, 449);
            this.BTNEnviar.Name = "BTNEnviar";
            this.BTNEnviar.Size = new System.Drawing.Size(150, 40);
            this.BTNEnviar.TabIndex = 15;
            this.BTNEnviar.Text = "   Ok";
            this.BTNEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNEnviar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Libro";
            // 
            // TXTFecha
            // 
            this.TXTFecha.BackColor = System.Drawing.Color.Transparent;
            this.TXTFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.TXTFecha.Location = new System.Drawing.Point(229, 361);
            this.TXTFecha.Name = "TXTFecha";
            this.TXTFecha.Padding = new System.Windows.Forms.Padding(7);
            this.TXTFecha.passCaracter = false;
            this.TXTFecha.Size = new System.Drawing.Size(250, 36);
            this.TXTFecha.soloLetras = false;
            this.TXTFecha.soloNumeros = false;
            this.TXTFecha.TabIndex = 13;
            // 
            // TXTCodAlm
            // 
            this.TXTCodAlm.BackColor = System.Drawing.Color.Transparent;
            this.TXTCodAlm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.TXTCodAlm.Location = new System.Drawing.Point(229, 202);
            this.TXTCodAlm.Name = "TXTCodAlm";
            this.TXTCodAlm.Padding = new System.Windows.Forms.Padding(7);
            this.TXTCodAlm.passCaracter = false;
            this.TXTCodAlm.Size = new System.Drawing.Size(250, 36);
            this.TXTCodAlm.soloLetras = false;
            this.TXTCodAlm.soloNumeros = true;
            this.TXTCodAlm.TabIndex = 7;
            // 
            // TXTCodAdm
            // 
            this.TXTCodAdm.BackColor = System.Drawing.Color.Transparent;
            this.TXTCodAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.TXTCodAdm.Location = new System.Drawing.Point(229, 305);
            this.TXTCodAdm.Name = "TXTCodAdm";
            this.TXTCodAdm.Padding = new System.Windows.Forms.Padding(7);
            this.TXTCodAdm.passCaracter = false;
            this.TXTCodAdm.Size = new System.Drawing.Size(250, 36);
            this.TXTCodAdm.soloLetras = false;
            this.TXTCodAdm.soloNumeros = true;
            this.TXTCodAdm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 40);
            this.label3.TabIndex = 12;
            this.label3.Text = "Prestamo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(127, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(142, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fecha:";
            // 
            // TXTIsbn
            // 
            this.TXTIsbn.BackColor = System.Drawing.Color.Transparent;
            this.TXTIsbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.TXTIsbn.Location = new System.Drawing.Point(229, 109);
            this.TXTIsbn.Name = "TXTIsbn";
            this.TXTIsbn.Padding = new System.Windows.Forms.Padding(7);
            this.TXTIsbn.passCaracter = false;
            this.TXTIsbn.Size = new System.Drawing.Size(250, 36);
            this.TXTIsbn.soloLetras = false;
            this.TXTIsbn.soloNumeros = true;
            this.TXTIsbn.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Código admin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(153, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "ISBN:";
            // 
            // lblalumn
            // 
            this.lblalumn.AutoSize = true;
            this.lblalumn.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblalumn.Location = new System.Drawing.Point(50, 153);
            this.lblalumn.Name = "lblalumn";
            this.lblalumn.Size = new System.Drawing.Size(129, 40);
            this.lblalumn.TabIndex = 9;
            this.lblalumn.Text = "Alumno";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(45)))), ((int)(((byte)(70)))));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.pictureBox1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(531, 92);
            this.panelInfo.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(11, -1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 90);
            this.label7.TabIndex = 11;
            this.label7.Text = "Prestar y devolver\r\nlibros\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BibliotecaProject.Properties.Resources.bookIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(427, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorForm
            // 
            this.errorForm.ContainerControl = this;
            // 
            // closeBTN
            // 
            this.closeBTN.Admin = false;
            this.closeBTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.closeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(41)))));
            this.closeBTN.borderColor = System.Drawing.Color.Empty;
            this.closeBTN.borderRadius = 40;
            this.closeBTN.borderSize = 0;
            this.closeBTN.FlatAppearance.BorderSize = 0;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeBTN.ForeColor = System.Drawing.SystemColors.Control;
            this.closeBTN.Location = new System.Drawing.Point(707, 4);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(40, 40);
            this.closeBTN.TabIndex = 21;
            this.closeBTN.Text = "X";
            this.closeBTN.UseVisualStyleBackColor = false;
            // 
            // LibrosPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(937, 744);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.Formulario);
            this.Name = "LibrosPrestamos";
            this.Text = "LibrosPrestamos";
            this.Formulario.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorForm)).EndInit();
            this.ResumeLayout(false);

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