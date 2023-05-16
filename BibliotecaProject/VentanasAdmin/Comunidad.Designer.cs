namespace BibliotecaProject.VentanasAdmin
{
    partial class Comunidad
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
            panelInfo = new Panel();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            Formulario.SuspendLayout();
            panelForm.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            closeBTN.Location = new Point(1037, 12);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new Size(40, 40);
            closeBTN.TabIndex = 25;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = false;
            // 
            // Formulario
            // 
            Formulario.Anchor = AnchorStyles.Top;
            Formulario.BorderStyle = BorderStyle.FixedSingle;
            Formulario.Controls.Add(panelForm);
            Formulario.Controls.Add(panelInfo);
            Formulario.Location = new Point(107, 57);
            Formulario.Name = "Formulario";
            Formulario.Size = new Size(971, 355);
            Formulario.TabIndex = 24;
            // 
            // panelForm
            // 
            panelForm.AutoScroll = true;
            panelForm.BackColor = SystemColors.Control;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(dataGridView1);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 102);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(969, 251);
            panelForm.TabIndex = 1;
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
            label7.Size = new Size(351, 45);
            label7.TabIndex = 11;
            label7.Text = "Gente en biblioteca :)\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(252, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(297, 143);
            dataGridView1.TabIndex = 0;
            // 
            // Comunidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 611);
            Controls.Add(closeBTN);
            Controls.Add(Formulario);
            Name = "Comunidad";
            Text = "Comunidad";
            Formulario.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ObjPersonalizados.CircleButton closeBTN;
        private Panel Formulario;
        private Panel panelForm;
        private DataGridView dataGridView1;
        private Panel panelInfo;
        private Label label7;
    }
}