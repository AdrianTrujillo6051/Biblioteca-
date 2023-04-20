namespace BibliotecaProject
{
    partial class ReposoForm
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
            Logo = new PictureBox();
            TXT1 = new ObjPersonalizados.TextBoxDML();
            textBoxPers1 = new ObjPersonalizados.TextBoxPers();
            buttondml1 = new ObjPersonalizados.ButtonDML();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.Top;
            Logo.BackgroundImage = Properties.Resources.UDGLogoBlack;
            Logo.BackgroundImageLayout = ImageLayout.Stretch;
            Logo.Location = new Point(237, 129);
            Logo.Name = "Logo";
            Logo.Size = new Size(314, 318);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // TXT1
            // 
            TXT1.BackColor = Color.Transparent;
            TXT1.ForeColor = Color.FromArgb(26, 30, 41);
            TXT1.Location = new Point(380, 40);
            TXT1.Name = "TXT1";
            TXT1.Padding = new Padding(7);
            TXT1.passCaracter = true;
            TXT1.Size = new Size(250, 36);
            TXT1.TabIndex = 1;
            // 
            // textBoxPers1
            // 
            textBoxPers1.BackColor = Color.Transparent;
            textBoxPers1.colorBorde = Color.FromArgb(0, 64, 0);
            textBoxPers1.ForeColor = Color.FromArgb(26, 30, 41);
            textBoxPers1.Location = new Point(376, 85);
            textBoxPers1.Name = "textBoxPers1";
            textBoxPers1.Padding = new Padding(7);
            textBoxPers1.passCaracter = true;
            textBoxPers1.Size = new Size(250, 36);
            textBoxPers1.subrayadoEstilo = true;
            textBoxPers1.TabIndex = 2;
            textBoxPers1.tamanoBorde = 9;
            // 
            // buttondml1
            // 
            buttondml1.BackColor = Color.FromArgb(106, 110, 121);
            buttondml1.FlatAppearance.BorderSize = 0;
            buttondml1.FlatStyle = FlatStyle.Flat;
            buttondml1.ForeColor = Color.White;
            buttondml1.Location = new Point(12, 40);
            buttondml1.Name = "buttondml1";
            buttondml1.Size = new Size(224, 55);
            buttondml1.TabIndex = 3;
            buttondml1.Text = "buttondml1";
            buttondml1.UseVisualStyleBackColor = false;
            buttondml1.Click += buttondml1_Click;
            // 
            // ReposoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttondml1);
            Controls.Add(textBoxPers1);
            Controls.Add(TXT1);
            Controls.Add(Logo);
            Name = "ReposoForm";
            Text = "ReposoForm";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Logo;
        private ObjPersonalizados.TextBoxDML TXT1;
        private ObjPersonalizados.TextBoxPers textBoxPers1;
        private ObjPersonalizados.ButtonDML buttondml1;
    }
}