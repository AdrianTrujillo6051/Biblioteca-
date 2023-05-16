namespace BibliotecaProject.VentanasUsers
{
    partial class EntradaSalidacs
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
            closeBTN = new ObjPersonalizados.CircleButton();
            Formulario = new Panel();
            panelForm = new Panel();
            label3 = new Label();
            BTNSalida = new ObjPersonalizados.CircleButton();
            TXTCodSali = new ObjPersonalizados.TextBoxDML();
            label4 = new Label();
            label9 = new Label();
            BTNEntrada = new ObjPersonalizados.CircleButton();
            TXTCodEntrada = new ObjPersonalizados.TextBoxDML();
            label1 = new Label();
            panelInfo = new Panel();
            label7 = new Label();
            Formulario.SuspendLayout();
            panelForm.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
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
            closeBTN.Location = new Point(1039, 2);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new Size(40, 40);
            closeBTN.TabIndex = 23;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = false;
            closeBTN.Click += closeBTN_Click;
            // 
            // Formulario
            // 
            Formulario.Anchor = AnchorStyles.Top;
            Formulario.BorderStyle = BorderStyle.FixedSingle;
            Formulario.Controls.Add(panelForm);
            Formulario.Controls.Add(panelInfo);
            Formulario.Location = new Point(109, 47);
            Formulario.Name = "Formulario";
            Formulario.Size = new Size(971, 355);
            Formulario.TabIndex = 22;
            // 
            // panelForm
            // 
            panelForm.AutoScroll = true;
            panelForm.BackColor = SystemColors.Control;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(BTNSalida);
            panelForm.Controls.Add(TXTCodSali);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(label9);
            panelForm.Controls.Add(BTNEntrada);
            panelForm.Controls.Add(TXTCodEntrada);
            panelForm.Controls.Add(label1);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 102);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(969, 251);
            panelForm.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(19, 45, 70);
            label3.Location = new Point(576, 2);
            label3.Name = "label3";
            label3.Size = new Size(138, 50);
            label3.TabIndex = 21;
            label3.Text = "Salida:";
            // 
            // BTNSalida
            // 
            BTNSalida.Admin = false;
            BTNSalida.BackColor = Color.FromArgb(19, 45, 70);
            BTNSalida.borderColor = Color.Empty;
            BTNSalida.borderRadius = 40;
            BTNSalida.borderSize = 0;
            BTNSalida.FlatAppearance.BorderSize = 0;
            BTNSalida.FlatStyle = FlatStyle.Flat;
            BTNSalida.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNSalida.ForeColor = Color.WhiteSmoke;
            BTNSalida.Image = Properties.Resources.okk;
            BTNSalida.Location = new Point(767, 128);
            BTNSalida.Name = "BTNSalida";
            BTNSalida.Size = new Size(150, 40);
            BTNSalida.TabIndex = 20;
            BTNSalida.Text = "   Ok";
            BTNSalida.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNSalida.UseVisualStyleBackColor = false;
            BTNSalida.Click += BTNSalida_Click;
            // 
            // TXTCodSali
            // 
            TXTCodSali.BackColor = Color.Transparent;
            TXTCodSali.ForeColor = Color.FromArgb(26, 30, 41);
            TXTCodSali.Location = new Point(682, 68);
            TXTCodSali.Name = "TXTCodSali";
            TXTCodSali.Padding = new Padding(7);
            TXTCodSali.passCaracter = false;
            TXTCodSali.Size = new Size(250, 36);
            TXTCodSali.soloLetras = false;
            TXTCodSali.soloNumeros = true;
            TXTCodSali.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(580, 68);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 19;
            label4.Text = "Código:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(19, 45, 70);
            label9.Location = new Point(-1, 2);
            label9.Name = "label9";
            label9.Size = new Size(166, 50);
            label9.TabIndex = 17;
            label9.Text = "Entrada:";
            // 
            // BTNEntrada
            // 
            BTNEntrada.Admin = false;
            BTNEntrada.BackColor = Color.FromArgb(19, 45, 70);
            BTNEntrada.borderColor = Color.Empty;
            BTNEntrada.borderRadius = 40;
            BTNEntrada.borderSize = 0;
            BTNEntrada.FlatAppearance.BorderSize = 0;
            BTNEntrada.FlatStyle = FlatStyle.Flat;
            BTNEntrada.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNEntrada.ForeColor = Color.WhiteSmoke;
            BTNEntrada.Image = Properties.Resources.okk;
            BTNEntrada.Location = new Point(190, 128);
            BTNEntrada.Name = "BTNEntrada";
            BTNEntrada.Size = new Size(150, 40);
            BTNEntrada.TabIndex = 15;
            BTNEntrada.Text = "   Ok";
            BTNEntrada.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTNEntrada.UseVisualStyleBackColor = false;
            BTNEntrada.Click += BTNEntrada_Click;
            // 
            // TXTCodEntrada
            // 
            TXTCodEntrada.BackColor = Color.Transparent;
            TXTCodEntrada.ForeColor = Color.FromArgb(26, 30, 41);
            TXTCodEntrada.Location = new Point(105, 68);
            TXTCodEntrada.Name = "TXTCodEntrada";
            TXTCodEntrada.Padding = new Padding(7);
            TXTCodEntrada.passCaracter = false;
            TXTCodEntrada.Size = new Size(250, 36);
            TXTCodEntrada.soloLetras = false;
            TXTCodEntrada.soloNumeros = true;
            TXTCodEntrada.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 68);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 5;
            label1.Text = "Código:";
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(19, 45, 70);
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(label7);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(969, 102);
            panelInfo.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(11, -1);
            label7.Name = "label7";
            label7.Size = new Size(515, 90);
            label7.TabIndex = 11;
            label7.Text = "Entradas y salidas de biblioteca\r\n           (Solo alumnos)";
            // 
            // EntradaSalidacs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 533);
            Controls.Add(closeBTN);
            Controls.Add(Formulario);
            Name = "EntradaSalidacs";
            Text = "EntradaSalidacs";
            Formulario.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ObjPersonalizados.CircleButton closeBTN;
        private Panel Formulario;
        private Panel panelForm;
        private Label label9;
        private ObjPersonalizados.CircleButton BTNEntrada;
        private ObjPersonalizados.TextBoxDML TXTCodEntrada;
        private Label label1;
        private Panel panelInfo;
        private Label label7;
        private Label label3;
        private ObjPersonalizados.CircleButton BTNSalida;
        private ObjPersonalizados.TextBoxDML TXTCodSali;
        private Label label4;
    }
}