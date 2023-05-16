namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLModiAlum
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
            lb1 = new Label();
            btBuscar = new ObjPersonalizados.CircleButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btActualizar = new ObjPersonalizados.ButtonDML();
            txtCodigooo = new TextBox();
            txtName = new TextBox();
            txtnsss = new TextBox();
            txtTelefono = new TextBox();
            txtcorreoo = new TextBox();
            txtBuscarCodigo = new TextBox();
            datexd = new DateTimePicker();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(43, 33);
            lb1.Name = "lb1";
            lb1.Size = new Size(182, 32);
            lb1.TabIndex = 6;
            lb1.Text = "Código Alumno";
            lb1.Click += label1_Click;
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
            btBuscar.Location = new Point(522, 12);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(65, 64);
            btBuscar.TabIndex = 18;
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 111);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 37;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 155);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 40;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 202);
            label3.Name = "label3";
            label3.Size = new Size(152, 32);
            label3.TabIndex = 42;
            label3.Text = "Cumpleaños:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(43, 251);
            label6.Name = "label6";
            label6.Size = new Size(63, 32);
            label6.TabIndex = 47;
            label6.Text = "NSS:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 301);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 49;
            label5.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 350);
            label4.Name = "label4";
            label4.Size = new Size(227, 32);
            label4.TabIndex = 51;
            label4.Text = "Correo Institucional:\r\n";
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
            btActualizar.Location = new Point(240, 398);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(150, 40);
            btActualizar.TabIndex = 58;
            btActualizar.Text = "       Actualizar";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Visible = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // txtCodigooo
            // 
            txtCodigooo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigooo.Location = new Point(200, 110);
            txtCodigooo.Name = "txtCodigooo";
            txtCodigooo.Size = new Size(298, 39);
            txtCodigooo.TabIndex = 65;
            txtCodigooo.Visible = false;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(201, 155);
            txtName.Name = "txtName";
            txtName.Size = new Size(297, 39);
            txtName.TabIndex = 66;
            txtName.Visible = false;
            // 
            // txtnsss
            // 
            txtnsss.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtnsss.Location = new Point(201, 251);
            txtnsss.Name = "txtnsss";
            txtnsss.Size = new Size(297, 39);
            txtnsss.TabIndex = 68;
            txtnsss.Visible = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(200, 298);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(298, 39);
            txtTelefono.TabIndex = 69;
            txtTelefono.Visible = false;
            // 
            // txtcorreoo
            // 
            txtcorreoo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtcorreoo.Location = new Point(276, 350);
            txtcorreoo.Name = "txtcorreoo";
            txtcorreoo.Size = new Size(389, 39);
            txtcorreoo.TabIndex = 70;
            txtcorreoo.Visible = false;
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.BackColor = SystemColors.ActiveCaption;
            txtBuscarCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCodigo.Location = new Point(231, 26);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.RightToLeft = RightToLeft.No;
            txtBuscarCodigo.Size = new Size(267, 39);
            txtBuscarCodigo.TabIndex = 71;
            txtBuscarCodigo.TextChanged += txtBuscarCodigo_TextChanged;
            // 
            // datexd
            // 
            datexd.CustomFormat = "yyyy-MM-dd";
            datexd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            datexd.Format = DateTimePickerFormat.Custom;
            datexd.Location = new Point(200, 206);
            datexd.Name = "datexd";
            datexd.Size = new Size(298, 39);
            datexd.TabIndex = 72;
            datexd.Visible = false;
            datexd.ValueChanged += datexd_ValueChanged;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(766, 12);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(22, 15);
            lblFecha.TabIndex = 73;
            lblFecha.Text = "XD";
            lblFecha.Visible = false;
            // 
            // DMLModiAlum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFecha);
            Controls.Add(datexd);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(txtcorreoo);
            Controls.Add(txtTelefono);
            Controls.Add(txtnsss);
            Controls.Add(txtName);
            Controls.Add(txtCodigooo);
            Controls.Add(btActualizar);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btBuscar);
            Controls.Add(lb1);
            Name = "DMLModiAlum";
            Text = "DMLModiAlum";
            Load += DMLModiAlum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private ObjPersonalizados.CircleButton btBuscar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private ObjPersonalizados.ButtonDML btActualizar;
        private TextBox txtCodigooo;
        private TextBox txtName;
        private TextBox txtnsss;
        private TextBox txtTelefono;
        private TextBox txtcorreoo;
        private TextBox txtBuscarCodigo;
        private DateTimePicker datexd;
        private Label lblFecha;
    }
}