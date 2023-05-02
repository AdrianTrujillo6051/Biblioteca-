namespace BibliotecaProject.VentanasUsers
{
    partial class Prestamos
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
            panelFondo = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            PrestamosInfo = new DataGridView();
            panel1 = new Panel();
            BuscarBTN = new ObjPersonalizados.ButtonDML();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            TXTCod = new ObjPersonalizados.TextBoxPers();
            closeBTN = new ObjPersonalizados.CircleButton();
            panelFondo.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PrestamosInfo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.Controls.Add(panel2);
            panelFondo.Controls.Add(panel1);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(905, 516);
            panelFondo.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(428, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 516);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(PrestamosInfo);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(477, 516);
            panel3.TabIndex = 0;
            // 
            // PrestamosInfo
            // 
            PrestamosInfo.BackgroundColor = SystemColors.Control;
            PrestamosInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PrestamosInfo.Dock = DockStyle.Fill;
            PrestamosInfo.Location = new Point(0, 0);
            PrestamosInfo.Name = "PrestamosInfo";
            PrestamosInfo.RowTemplate.Height = 25;
            PrestamosInfo.Size = new Size(477, 516);
            PrestamosInfo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 45, 70);
            panel1.Controls.Add(closeBTN);
            panel1.Controls.Add(BuscarBTN);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TXTCod);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 516);
            panel1.TabIndex = 0;
            // 
            // BuscarBTN
            // 
            BuscarBTN.BackColor = Color.FromArgb(106, 110, 121);
            BuscarBTN.FlatAppearance.BorderSize = 0;
            BuscarBTN.FlatStyle = FlatStyle.Flat;
            BuscarBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BuscarBTN.ForeColor = Color.White;
            BuscarBTN.Location = new Point(244, 169);
            BuscarBTN.Name = "BuscarBTN";
            BuscarBTN.Size = new Size(150, 40);
            BuscarBTN.TabIndex = 23;
            BuscarBTN.Text = "Buscar";
            BuscarBTN.UseVisualStyleBackColor = false;
            BuscarBTN.Click += BuscarBTN_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.important;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-1, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(26, 85);
            label1.Name = "label1";
            label1.Size = new Size(386, 21);
            label1.TabIndex = 15;
            label1.Text = "Para buscar un prestamo ingrese el código del alumno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(283, 45);
            label3.TabIndex = 14;
            label3.Text = "Buscar prestamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(0, 113);
            label2.Name = "label2";
            label2.Size = new Size(215, 32);
            label2.TabIndex = 13;
            label2.Text = "Código estudiante:";
            // 
            // TXTCod
            // 
            TXTCod.BackColor = Color.Transparent;
            TXTCod.colorBorde = SystemColors.Control;
            TXTCod.ForeColor = Color.FromArgb(26, 30, 41);
            TXTCod.Location = new Point(212, 109);
            TXTCod.Name = "TXTCod";
            TXTCod.Padding = new Padding(7);
            TXTCod.passCaracter = false;
            TXTCod.Size = new Size(182, 36);
            TXTCod.soloLetras = false;
            TXTCod.soloNumeros = true;
            TXTCod.subrayadoEstilo = true;
            TXTCod.TabIndex = 12;
            TXTCod.tamanoBorde = 3;
            TXTCod.textBoxBackColor = Color.FromArgb(19, 45, 70);
            TXTCod.textBoxFontColor = SystemColors.Window;
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
            closeBTN.Location = new Point(372, 15);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new Size(40, 40);
            closeBTN.TabIndex = 24;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = false;
            closeBTN.Click += closeBTN_Click;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 516);
            Controls.Add(panelFondo);
            Name = "Prestamos";
            Text = "Prestamos";
            panelFondo.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PrestamosInfo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFondo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView PrestamosInfo;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private ObjPersonalizados.TextBoxPers TXTCod;
        private ObjPersonalizados.ButtonDML BuscarBTN;
        private ObjPersonalizados.CircleButton closeBTN;
    }
}