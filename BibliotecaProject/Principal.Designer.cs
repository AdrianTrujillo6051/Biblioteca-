namespace BibliotecaProject
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PanelSubventanas = new Panel();
            Reloj = new System.Windows.Forms.Timer(components);
            PanelNavegacion = new Panel();
            PanelLayout = new Panel();
            BTNLibrosPrest = new ObjPersonalizados.CircleButton();
            BTNEntrSalid = new ObjPersonalizados.CircleButton();
            BTNGenteEnBib = new ObjPersonalizados.CircleButton();
            BTNPrestCub = new ObjPersonalizados.CircleButton();
            BTNRegistros = new ObjPersonalizados.CircleButton();
            PanelInfo = new Panel();
            UserLBL = new Label();
            FechaLBL = new Label();
            HoraLBL = new Label();
            BTNPrestamos = new ObjPersonalizados.CircleButton();
            PanelNavegacion.SuspendLayout();
            PanelLayout.SuspendLayout();
            PanelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // PanelSubventanas
            // 
            PanelSubventanas.Dock = DockStyle.Fill;
            PanelSubventanas.Location = new Point(0, 175);
            PanelSubventanas.Name = "PanelSubventanas";
            PanelSubventanas.Size = new Size(1464, 478);
            PanelSubventanas.TabIndex = 1;
            // 
            // Reloj
            // 
            Reloj.Enabled = true;
            Reloj.Tick += Reloj_Tick;
            // 
            // PanelNavegacion
            // 
            PanelNavegacion.BackColor = Color.FromArgb(26, 30, 41);
            PanelNavegacion.Controls.Add(PanelLayout);
            PanelNavegacion.Controls.Add(PanelInfo);
            PanelNavegacion.Dock = DockStyle.Top;
            PanelNavegacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PanelNavegacion.Location = new Point(0, 0);
            PanelNavegacion.Name = "PanelNavegacion";
            PanelNavegacion.Size = new Size(1464, 175);
            PanelNavegacion.TabIndex = 0;
            // 
            // PanelLayout
            // 
            PanelLayout.AutoScroll = true;
            PanelLayout.Controls.Add(BTNPrestamos);
            PanelLayout.Controls.Add(BTNLibrosPrest);
            PanelLayout.Controls.Add(BTNEntrSalid);
            PanelLayout.Controls.Add(BTNGenteEnBib);
            PanelLayout.Controls.Add(BTNPrestCub);
            PanelLayout.Controls.Add(BTNRegistros);
            PanelLayout.Dock = DockStyle.Fill;
            PanelLayout.Location = new Point(334, 0);
            PanelLayout.Name = "PanelLayout";
            PanelLayout.Size = new Size(1130, 175);
            PanelLayout.TabIndex = 2;
            // 
            // BTNLibrosPrest
            // 
            BTNLibrosPrest.Admin = false;
            BTNLibrosPrest.BackColor = Color.FromArgb(200, 234, 252);
            BTNLibrosPrest.BackgroundImage = Properties.Resources.important;
            BTNLibrosPrest.BackgroundImageLayout = ImageLayout.Stretch;
            BTNLibrosPrest.borderColor = Color.Transparent;
            BTNLibrosPrest.borderRadius = 48;
            BTNLibrosPrest.borderSize = 5;
            BTNLibrosPrest.FlatAppearance.BorderSize = 0;
            BTNLibrosPrest.FlatStyle = FlatStyle.Flat;
            BTNLibrosPrest.ForeColor = Color.White;
            BTNLibrosPrest.Location = new Point(234, 12);
            BTNLibrosPrest.Name = "BTNLibrosPrest";
            BTNLibrosPrest.Size = new Size(51, 63);
            BTNLibrosPrest.TabIndex = 7;
            BTNLibrosPrest.UseVisualStyleBackColor = false;
            BTNLibrosPrest.Click += BTNLibrosPrest_Click;
            // 
            // BTNEntrSalid
            // 
            BTNEntrSalid.Admin = false;
            BTNEntrSalid.BackColor = Color.FromArgb(200, 234, 252);
            BTNEntrSalid.BackgroundImage = Properties.Resources.important;
            BTNEntrSalid.BackgroundImageLayout = ImageLayout.Stretch;
            BTNEntrSalid.borderColor = Color.Transparent;
            BTNEntrSalid.borderRadius = 48;
            BTNEntrSalid.borderSize = 5;
            BTNEntrSalid.FlatAppearance.BorderSize = 0;
            BTNEntrSalid.FlatStyle = FlatStyle.Flat;
            BTNEntrSalid.ForeColor = Color.White;
            BTNEntrSalid.Location = new Point(177, 12);
            BTNEntrSalid.Name = "BTNEntrSalid";
            BTNEntrSalid.Size = new Size(51, 63);
            BTNEntrSalid.TabIndex = 6;
            BTNEntrSalid.UseVisualStyleBackColor = false;
            // 
            // BTNGenteEnBib
            // 
            BTNGenteEnBib.Admin = true;
            BTNGenteEnBib.BackColor = Color.FromArgb(200, 234, 252);
            BTNGenteEnBib.BackgroundImage = Properties.Resources.close;
            BTNGenteEnBib.BackgroundImageLayout = ImageLayout.Stretch;
            BTNGenteEnBib.borderColor = Color.Transparent;
            BTNGenteEnBib.borderRadius = 48;
            BTNGenteEnBib.borderSize = 5;
            BTNGenteEnBib.FlatAppearance.BorderSize = 0;
            BTNGenteEnBib.FlatStyle = FlatStyle.Flat;
            BTNGenteEnBib.ForeColor = Color.White;
            BTNGenteEnBib.Location = new Point(120, 12);
            BTNGenteEnBib.Name = "BTNGenteEnBib";
            BTNGenteEnBib.Size = new Size(51, 63);
            BTNGenteEnBib.TabIndex = 5;
            BTNGenteEnBib.UseVisualStyleBackColor = false;
            // 
            // BTNPrestCub
            // 
            BTNPrestCub.Admin = false;
            BTNPrestCub.BackColor = Color.FromArgb(200, 234, 252);
            BTNPrestCub.BackgroundImage = Properties.Resources.smile;
            BTNPrestCub.BackgroundImageLayout = ImageLayout.Stretch;
            BTNPrestCub.borderColor = Color.Transparent;
            BTNPrestCub.borderRadius = 48;
            BTNPrestCub.borderSize = 5;
            BTNPrestCub.FlatAppearance.BorderSize = 0;
            BTNPrestCub.FlatStyle = FlatStyle.Flat;
            BTNPrestCub.ForeColor = Color.White;
            BTNPrestCub.Location = new Point(63, 12);
            BTNPrestCub.Name = "BTNPrestCub";
            BTNPrestCub.Size = new Size(51, 63);
            BTNPrestCub.TabIndex = 4;
            BTNPrestCub.UseVisualStyleBackColor = false;
            BTNPrestCub.Click += BTNPrestCub_Click;
            // 
            // BTNRegistros
            // 
            BTNRegistros.Admin = true;
            BTNRegistros.BackColor = Color.FromArgb(200, 234, 252);
            BTNRegistros.BackgroundImage = Properties.Resources.close;
            BTNRegistros.BackgroundImageLayout = ImageLayout.Stretch;
            BTNRegistros.borderColor = Color.Transparent;
            BTNRegistros.borderRadius = 48;
            BTNRegistros.borderSize = 5;
            BTNRegistros.FlatAppearance.BorderSize = 0;
            BTNRegistros.FlatStyle = FlatStyle.Flat;
            BTNRegistros.ForeColor = Color.White;
            BTNRegistros.Location = new Point(6, 12);
            BTNRegistros.Name = "BTNRegistros";
            BTNRegistros.Padding = new Padding(7);
            BTNRegistros.Size = new Size(51, 63);
            BTNRegistros.TabIndex = 2;
            BTNRegistros.UseVisualStyleBackColor = false;
            BTNRegistros.Click += BTNRegistros_Click;
            // 
            // PanelInfo
            // 
            PanelInfo.Controls.Add(UserLBL);
            PanelInfo.Controls.Add(FechaLBL);
            PanelInfo.Controls.Add(HoraLBL);
            PanelInfo.Dock = DockStyle.Left;
            PanelInfo.Location = new Point(0, 0);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.Size = new Size(334, 175);
            PanelInfo.TabIndex = 1;
            // 
            // UserLBL
            // 
            UserLBL.AutoSize = true;
            UserLBL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserLBL.ForeColor = Color.White;
            UserLBL.Location = new Point(3, 111);
            UserLBL.Name = "UserLBL";
            UserLBL.Size = new Size(204, 30);
            UserLBL.TabIndex = 2;
            UserLBL.Text = "Dia de los pendejos";
            // 
            // FechaLBL
            // 
            FechaLBL.AutoSize = true;
            FechaLBL.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            FechaLBL.ForeColor = Color.FromArgb(200, 234, 252);
            FechaLBL.Location = new Point(3, 65);
            FechaLBL.Name = "FechaLBL";
            FechaLBL.Size = new Size(267, 37);
            FechaLBL.TabIndex = 1;
            FechaLBL.Text = "Dia de los pendejos";
            // 
            // HoraLBL
            // 
            HoraLBL.AutoSize = true;
            HoraLBL.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            HoraLBL.ForeColor = Color.FromArgb(200, 234, 252);
            HoraLBL.Location = new Point(0, 0);
            HoraLBL.Name = "HoraLBL";
            HoraLBL.Size = new Size(125, 65);
            HoraLBL.TabIndex = 0;
            HoraLBL.Text = "5:02";
            // 
            // BTNPrestamos
            // 
            BTNPrestamos.Admin = false;
            BTNPrestamos.BackColor = Color.FromArgb(200, 234, 252);
            BTNPrestamos.BackgroundImage = Properties.Resources.ok1;
            BTNPrestamos.BackgroundImageLayout = ImageLayout.Stretch;
            BTNPrestamos.borderColor = Color.Transparent;
            BTNPrestamos.borderRadius = 48;
            BTNPrestamos.borderSize = 5;
            BTNPrestamos.FlatAppearance.BorderSize = 0;
            BTNPrestamos.FlatStyle = FlatStyle.Flat;
            BTNPrestamos.ForeColor = Color.White;
            BTNPrestamos.Location = new Point(291, 12);
            BTNPrestamos.Name = "BTNPrestamos";
            BTNPrestamos.Size = new Size(51, 63);
            BTNPrestamos.TabIndex = 8;
            BTNPrestamos.UseVisualStyleBackColor = false;
            BTNPrestamos.Click += BTNPrestamos_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 653);
            Controls.Add(PanelSubventanas);
            Controls.Add(PanelNavegacion);
            Name = "Principal";
            Text = ":)";
            PanelNavegacion.ResumeLayout(false);
            PanelLayout.ResumeLayout(false);
            PanelInfo.ResumeLayout(false);
            PanelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PanelSubventanas;
        private System.Windows.Forms.Timer Reloj;
        private Panel PanelNavegacion;
        private Panel PanelInfo;
        private Label HoraLBL;
        private Panel PanelLayout;
        private ObjPersonalizados.CircleButton BTNRegistros;
        private ObjPersonalizados.CircleButton BTNPrestCub;
        private ObjPersonalizados.CircleButton BTNGenteEnBib;
        private ObjPersonalizados.CircleButton BTNEntrSalid;
        private ObjPersonalizados.CircleButton BTNLibrosPrest;
        private Label FechaLBL;
        private Label UserLBL;
        private ObjPersonalizados.CircleButton BTNPrestamos;
    }
}