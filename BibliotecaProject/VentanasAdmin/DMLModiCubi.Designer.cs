namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLModiCubi
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
            btActualizar = new ObjPersonalizados.ButtonDML();
            txtBuscarCodigo = new TextBox();
            Cubículo = new Label();
            btBuscar = new ObjPersonalizados.CircleButton();
            lb3 = new Label();
            lb2 = new Label();
            label1 = new Label();
            txtid = new TextBox();
            txtAsientos = new TextBox();
            cbDispo = new ComboBox();
            SuspendLayout();
            // 
            // btActualizar
            // 
            btActualizar.BackColor = Color.FromArgb(106, 110, 121);
            btActualizar.FlatAppearance.BorderSize = 0;
            btActualizar.FlatStyle = FlatStyle.Flat;
            btActualizar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btActualizar.ForeColor = Color.White;
            btActualizar.Image = Properties.Resources.yes;
            btActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btActualizar.Location = new Point(258, 383);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(150, 40);
            btActualizar.TabIndex = 59;
            btActualizar.Text = "       Actualizar";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Visible = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.BackColor = SystemColors.ActiveCaption;
            txtBuscarCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCodigo.Location = new Point(234, 25);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.RightToLeft = RightToLeft.No;
            txtBuscarCodigo.Size = new Size(267, 39);
            txtBuscarCodigo.TabIndex = 72;
            // 
            // Cubículo
            // 
            Cubículo.AutoSize = true;
            Cubículo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Cubículo.Location = new Point(81, 32);
            Cubículo.Name = "Cubículo";
            Cubículo.Size = new Size(108, 32);
            Cubículo.TabIndex = 73;
            Cubículo.Text = "Cubículo";
            // 
            // btBuscar
            // 
            btBuscar.Admin = false;
            btBuscar.BackColor = Color.White;
            btBuscar.BackgroundImage = Properties.Resources.lupa;
            btBuscar.borderColor = Color.Empty;
            btBuscar.borderRadius = 62;
            btBuscar.borderSize = 0;
            btBuscar.FlatAppearance.BorderSize = 0;
            btBuscar.FlatStyle = FlatStyle.Flat;
            btBuscar.ForeColor = Color.White;
            btBuscar.Location = new Point(518, 12);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(65, 64);
            btBuscar.TabIndex = 74;
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb3.Location = new Point(81, 304);
            lb3.Name = "lb3";
            lb3.Size = new Size(167, 32);
            lb3.TabIndex = 77;
            lb3.Text = "Disponibilidad";
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb2.Location = new Point(81, 201);
            lb2.Name = "lb2";
            lb2.Size = new Size(104, 32);
            lb2.TabIndex = 76;
            lb2.Text = "Asientos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(81, 113);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 75;
            label1.Text = "ID de Cúbiculo";
            // 
            // txtid
            // 
            txtid.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtid.Location = new Point(285, 106);
            txtid.Name = "txtid";
            txtid.Size = new Size(298, 39);
            txtid.TabIndex = 78;
            txtid.Visible = false;
            // 
            // txtAsientos
            // 
            txtAsientos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAsientos.Location = new Point(285, 194);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(298, 39);
            txtAsientos.TabIndex = 79;
            txtAsientos.Visible = false;
            // 
            // cbDispo
            // 
            cbDispo.BackColor = SystemColors.InactiveCaption;
            cbDispo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbDispo.FormattingEnabled = true;
            cbDispo.Items.AddRange(new object[] { "Disponible", "No Disponible" });
            cbDispo.Location = new Point(285, 303);
            cbDispo.Name = "cbDispo";
            cbDispo.Size = new Size(235, 33);
            cbDispo.TabIndex = 80;
            cbDispo.Visible = false;
            // 
            // DMLModiCubi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbDispo);
            Controls.Add(txtAsientos);
            Controls.Add(txtid);
            Controls.Add(lb3);
            Controls.Add(lb2);
            Controls.Add(label1);
            Controls.Add(btBuscar);
            Controls.Add(Cubículo);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(btActualizar);
            Name = "DMLModiCubi";
            Text = "DMLModiCubi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ObjPersonalizados.ButtonDML btActualizar;
        private TextBox txtBuscarCodigo;
        private Label Cubículo;
        private ObjPersonalizados.CircleButton btBuscar;
        private Label lb3;
        private Label lb2;
        private Label label1;
        private TextBox txtid;
        private TextBox txtAsientos;
        private ComboBox cbDispo;
    }
}