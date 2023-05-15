namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLCubi
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
            label1 = new Label();
            lb2 = new Label();
            lb3 = new Label();
            txtIDCubi = new ObjPersonalizados.TextBoxDML();
            btGuardar = new ObjPersonalizados.ButtonDML();
            pictureBox1 = new PictureBox();
            txtAsientos = new ObjPersonalizados.TextBoxDML();
            cbDispo = new ComboBox();
            errorFormulario = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorFormulario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(83, 96);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 9;
            label1.Text = "ID de Cúbiculo";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb2.Location = new Point(83, 184);
            lb2.Name = "lb2";
            lb2.Size = new Size(104, 32);
            lb2.TabIndex = 10;
            lb2.Text = "Asientos";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb3.Location = new Point(83, 287);
            lb3.Name = "lb3";
            lb3.Size = new Size(167, 32);
            lb3.TabIndex = 12;
            lb3.Text = "Disponibilidad";
            // 
            // txtIDCubi
            // 
            txtIDCubi.BackColor = Color.Transparent;
            txtIDCubi.ForeColor = Color.FromArgb(26, 30, 41);
            txtIDCubi.Location = new Point(309, 96);
            txtIDCubi.Name = "txtIDCubi";
            txtIDCubi.Padding = new Padding(7);
            txtIDCubi.passCaracter = false;
            txtIDCubi.Size = new Size(235, 36);
            txtIDCubi.soloLetras = false;
            txtIDCubi.soloNumeros = true;
            txtIDCubi.TabIndex = 13;
            // 
            // btGuardar
            // 
            btGuardar.BackColor = Color.FromArgb(106, 110, 121);
            btGuardar.FlatAppearance.BorderSize = 0;
            btGuardar.FlatStyle = FlatStyle.Flat;
            btGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btGuardar.ForeColor = Color.White;
            btGuardar.Image = Properties.Resources.yes;
            btGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btGuardar.Location = new Point(309, 417);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(235, 39);
            btGuardar.TabIndex = 16;
            btGuardar.Text = "     Guardar";
            btGuardar.UseVisualStyleBackColor = false;
            btGuardar.Click += btGuardar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cubiculo;
            pictureBox1.Location = new Point(756, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(304, 290);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtAsientos
            // 
            txtAsientos.BackColor = Color.Transparent;
            txtAsientos.ForeColor = Color.FromArgb(26, 30, 41);
            txtAsientos.Location = new Point(309, 184);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Padding = new Padding(7);
            txtAsientos.passCaracter = false;
            txtAsientos.Size = new Size(235, 36);
            txtAsientos.soloLetras = false;
            txtAsientos.soloNumeros = true;
            txtAsientos.TabIndex = 19;
            // 
            // cbDispo
            // 
            cbDispo.BackColor = SystemColors.InactiveCaption;
            cbDispo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbDispo.FormattingEnabled = true;
            cbDispo.Items.AddRange(new object[] { "Disponible", "No Disponible" });
            cbDispo.Location = new Point(309, 286);
            cbDispo.Name = "cbDispo";
            cbDispo.Size = new Size(235, 33);
            cbDispo.TabIndex = 21;
            cbDispo.SelectedIndexChanged += cbDispo_SelectedIndexChanged;
            // 
            // errorFormulario
            // 
            errorFormulario.ContainerControl = this;
            // 
            // DMLCubi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 580);
            Controls.Add(cbDispo);
            Controls.Add(txtAsientos);
            Controls.Add(pictureBox1);
            Controls.Add(btGuardar);
            Controls.Add(txtIDCubi);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(label1);
            Name = "DMLCubi";
            Text = "DMLCubi";
            Load += DMLCubi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorFormulario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb2;
        private Label lb3;
        private ObjPersonalizados.TextBoxDML txtIDCubi;
        private ObjPersonalizados.ButtonDML btGuardar;
        private PictureBox pictureBox1;
        private ObjPersonalizados.TextBoxDML txtAsientos;
        private ComboBox cbDispo;
        private ErrorProvider errorFormulario;
    }
}