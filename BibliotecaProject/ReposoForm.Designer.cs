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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReposoForm));
            reloj = new System.Windows.Forms.Timer(components);
            frontPageImg = new PictureBox();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblDescrrpcion = new Label();
            ((System.ComponentModel.ISupportInitialize)frontPageImg).BeginInit();
            SuspendLayout();
            // 
            // reloj
            // 
            reloj.Enabled = true;
            reloj.Interval = 15000;
            reloj.Tick += reloj_Tick;
            // 
            // frontPageImg
            // 
            frontPageImg.Anchor = AnchorStyles.Top;
            frontPageImg.BackgroundImage = Properties.Resources.book2;
            frontPageImg.BackgroundImageLayout = ImageLayout.Stretch;
            frontPageImg.Location = new Point(143, 58);
            frontPageImg.Name = "frontPageImg";
            frontPageImg.Size = new Size(385, 576);
            frontPageImg.TabIndex = 2;
            frontPageImg.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(26, 30, 41);
            lblTitulo.Location = new Point(624, 58);
            lblTitulo.MaximumSize = new Size(350, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(252, 100);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Cien años de soledad";
            // 
            // lblAutor
            // 
            lblAutor.Anchor = AnchorStyles.Top;
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAutor.Location = new Point(624, 194);
            lblAutor.MaximumSize = new Size(390, 0);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(262, 32);
            lblAutor.TabIndex = 4;
            lblAutor.Text = "Gabriel García Márquez";
            // 
            // lblDescrrpcion
            // 
            lblDescrrpcion.Anchor = AnchorStyles.Top;
            lblDescrrpcion.AutoSize = true;
            lblDescrrpcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescrrpcion.ForeColor = Color.FromArgb(106, 110, 121);
            lblDescrrpcion.Location = new Point(624, 270);
            lblDescrrpcion.MaximumSize = new Size(390, 0);
            lblDescrrpcion.Name = "lblDescrrpcion";
            lblDescrrpcion.Size = new Size(388, 189);
            lblDescrrpcion.TabIndex = 5;
            lblDescrrpcion.Text = resources.GetString("lblDescrrpcion.Text");
            // 
            // ReposoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 637);
            Controls.Add(lblDescrrpcion);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(frontPageImg);
            Name = "ReposoForm";
            Text = "ReposoForm";
            ((System.ComponentModel.ISupportInitialize)frontPageImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer reloj;
        private PictureBox frontPageImg;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblDescrrpcion;
    }
}