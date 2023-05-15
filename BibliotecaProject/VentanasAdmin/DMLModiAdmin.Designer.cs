namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLModiAdmin
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
            txtBuscarCodigo = new TextBox();
            btBuscar = new ObjPersonalizados.CircleButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtnss = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtPuesto = new TextBox();
            horario = new DateTimePicker();
            btActualizar = new ObjPersonalizados.ButtonDML();
            lblhora = new Label();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(35, 30);
            lb1.Name = "lb1";
            lb1.Size = new Size(252, 32);
            lb1.TabIndex = 7;
            lb1.Text = "Código Administrativo";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.BackColor = SystemColors.ActiveCaption;
            txtBuscarCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCodigo.Location = new Point(309, 30);
            txtBuscarCodigo.Name = "txtBuscarCodigo";
            txtBuscarCodigo.RightToLeft = RightToLeft.No;
            txtBuscarCodigo.Size = new Size(267, 39);
            txtBuscarCodigo.TabIndex = 72;
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
            btBuscar.Location = new Point(612, 12);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(65, 64);
            btBuscar.TabIndex = 73;
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 279);
            label4.Name = "label4";
            label4.Size = new Size(215, 32);
            label4.TabIndex = 78;
            label4.Text = "Correo Empresarial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(48, 230);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 77;
            label5.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(48, 185);
            label6.Name = "label6";
            label6.Size = new Size(63, 32);
            label6.TabIndex = 76;
            label6.Text = "NSS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 134);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 75;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 90);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 74;
            label1.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 378);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 79;
            label3.Text = "Horario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(48, 331);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 80;
            label7.Text = "Puesto";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodigo.Location = new Point(214, 90);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(298, 39);
            txtCodigo.TabIndex = 81;
            txtCodigo.Visible = false;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(214, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 39);
            txtNombre.TabIndex = 82;
            txtNombre.Visible = false;
            // 
            // txtnss
            // 
            txtnss.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtnss.Location = new Point(214, 178);
            txtnss.Name = "txtnss";
            txtnss.Size = new Size(298, 39);
            txtnss.TabIndex = 83;
            txtnss.Visible = false;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(214, 230);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(298, 39);
            txtTelefono.TabIndex = 84;
            txtTelefono.Visible = false;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(269, 279);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(368, 39);
            txtCorreo.TabIndex = 85;
            txtCorreo.Visible = false;
            // 
            // txtPuesto
            // 
            txtPuesto.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPuesto.Location = new Point(172, 328);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(298, 39);
            txtPuesto.TabIndex = 86;
            txtPuesto.Visible = false;
            // 
            // horario
            // 
            horario.CustomFormat = "yyyy-MM-dd";
            horario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            horario.Format = DateTimePickerFormat.Time;
            horario.Location = new Point(172, 373);
            horario.Name = "horario";
            horario.Size = new Size(298, 39);
            horario.TabIndex = 87;
            horario.Visible = false;
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
            btActualizar.Location = new Point(269, 431);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(150, 40);
            btActualizar.TabIndex = 88;
            btActualizar.Text = "       Actualizar";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Visible = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // lblhora
            // 
            lblhora.AutoSize = true;
            lblhora.Location = new Point(718, 47);
            lblhora.Name = "lblhora";
            lblhora.Size = new Size(22, 15);
            lblhora.TabIndex = 89;
            lblhora.Text = "XD";
            lblhora.Visible = false;
            // 
            // DMLModiAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 498);
            Controls.Add(lblhora);
            Controls.Add(btActualizar);
            Controls.Add(horario);
            Controls.Add(txtPuesto);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtnss);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btBuscar);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(lb1);
            Name = "DMLModiAdmin";
            Text = "DMLModiAdmin";
            Load += DMLModiAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private TextBox txtBuscarCodigo;
        private ObjPersonalizados.CircleButton btBuscar;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label7;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtnss;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtPuesto;
        private DateTimePicker horario;
        private ObjPersonalizados.ButtonDML btActualizar;
        private Label lblhora;
    }
}