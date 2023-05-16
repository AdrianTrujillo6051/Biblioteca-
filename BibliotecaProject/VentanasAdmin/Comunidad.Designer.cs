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
            izquierda = new Panel();
            AlumnosDGV = new DataGridView();
            derecha = new Panel();
            AdministrativosDGV = new DataGridView();
            panelInfo = new Panel();
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            Formulario.SuspendLayout();
            panelForm.SuspendLayout();
            izquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AlumnosDGV).BeginInit();
            derecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdministrativosDGV).BeginInit();
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
            Formulario.Size = new Size(971, 542);
            Formulario.TabIndex = 24;
            // 
            // panelForm
            // 
            panelForm.AutoScroll = true;
            panelForm.BackColor = SystemColors.Control;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(izquierda);
            panelForm.Controls.Add(derecha);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 102);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(969, 438);
            panelForm.TabIndex = 1;
            // 
            // izquierda
            // 
            izquierda.Controls.Add(AlumnosDGV);
            izquierda.Dock = DockStyle.Fill;
            izquierda.Location = new Point(0, 0);
            izquierda.Name = "izquierda";
            izquierda.Size = new Size(510, 436);
            izquierda.TabIndex = 2;
            // 
            // AlumnosDGV
            // 
            AlumnosDGV.BackgroundColor = SystemColors.Control;
            AlumnosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AlumnosDGV.Dock = DockStyle.Fill;
            AlumnosDGV.Location = new Point(0, 0);
            AlumnosDGV.Name = "AlumnosDGV";
            AlumnosDGV.RowTemplate.Height = 25;
            AlumnosDGV.Size = new Size(510, 436);
            AlumnosDGV.TabIndex = 0;
            // 
            // derecha
            // 
            derecha.Controls.Add(AdministrativosDGV);
            derecha.Dock = DockStyle.Right;
            derecha.Location = new Point(510, 0);
            derecha.Name = "derecha";
            derecha.Size = new Size(457, 436);
            derecha.TabIndex = 1;
            // 
            // AdministrativosDGV
            // 
            AdministrativosDGV.BackgroundColor = SystemColors.Control;
            AdministrativosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdministrativosDGV.Dock = DockStyle.Fill;
            AdministrativosDGV.Location = new Point(0, 0);
            AdministrativosDGV.Name = "AdministrativosDGV";
            AdministrativosDGV.RowTemplate.Height = 25;
            AdministrativosDGV.Size = new Size(457, 436);
            AdministrativosDGV.TabIndex = 0;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.FromArgb(19, 45, 70);
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(label1);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(label7);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(969, 102);
            panelInfo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(528, 68);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 14;
            label1.Text = "Administrativos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 68);
            label2.Name = "label2";
            label2.Size = new Size(95, 30);
            label2.TabIndex = 13;
            label2.Text = "Alumnos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(12, 0);
            label7.Name = "label7";
            label7.Size = new Size(437, 45);
            label7.TabIndex = 11;
            label7.Text = "Usuarios de la biblioteca :)\r\n";
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
            izquierda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AlumnosDGV).EndInit();
            derecha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AdministrativosDGV).EndInit();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ObjPersonalizados.CircleButton closeBTN;
        private Panel Formulario;
        private Panel panelForm;
        private DataGridView AlumnosDGV;
        private Panel panelInfo;
        private Label label7;
        private Panel izquierda;
        private Panel derecha;
        private DataGridView AdministrativosDGV;
        private Label label1;
        private Label label2;
    }
}