namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLModiLibro
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtisb = new TextBox();
            txtCantida = new TextBox();
            txtEdi = new TextBox();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            cbGenero = new ComboBox();
            cbDispoL = new ComboBox();
            cbIdiomas = new ComboBox();
            datexd = new DateTimePicker();
            lblFecha = new Label();
            btActualizar = new ObjPersonalizados.ButtonDML();
            label11 = new Label();
            txtPaginas = new TextBox();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb1.Location = new Point(58, 30);
            lb1.Name = "lb1";
            lb1.Size = new Size(65, 32);
            lb1.TabIndex = 7;
            lb1.Text = "ISBN";
            // 
            // txtBuscarCodigo
            // 
            txtBuscarCodigo.BackColor = SystemColors.ActiveCaption;
            txtBuscarCodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscarCodigo.Location = new Point(151, 27);
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
            btBuscar.Location = new Point(456, 12);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(65, 64);
            btBuscar.TabIndex = 73;
            btBuscar.UseVisualStyleBackColor = false;
            btBuscar.Click += btBuscar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(486, 140);
            label9.Name = "label9";
            label9.Size = new Size(97, 32);
            label9.TabIndex = 82;
            label9.Text = "Idiomas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(476, 87);
            label8.Name = "label8";
            label8.Size = new Size(253, 32);
            label8.TabIndex = 81;
            label8.Text = "Cantidad de prestados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(51, 450);
            label7.Name = "label7";
            label7.Size = new Size(167, 32);
            label7.TabIndex = 80;
            label7.Text = "Disponibilidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(51, 397);
            label6.Name = "label6";
            label6.Size = new Size(92, 32);
            label6.TabIndex = 79;
            label6.Text = "Género";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(51, 324);
            label5.Name = "label5";
            label5.Size = new Size(239, 32);
            label5.TabIndex = 78;
            label5.Text = "Fecha de publicación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(58, 266);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 77;
            label4.Text = "Editorial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(58, 211);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 76;
            label3.Text = "Autor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(58, 162);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 75;
            label2.Text = "Título";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(58, 108);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 74;
            label1.Text = "ISBN";
            // 
            // txtisb
            // 
            txtisb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtisb.Location = new Point(164, 105);
            txtisb.Name = "txtisb";
            txtisb.Size = new Size(298, 39);
            txtisb.TabIndex = 84;
            txtisb.Visible = false;
            // 
            // txtCantida
            // 
            txtCantida.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantida.Location = new Point(735, 84);
            txtCantida.Name = "txtCantida";
            txtCantida.Size = new Size(120, 39);
            txtCantida.TabIndex = 86;
            txtCantida.Visible = false;
            // 
            // txtEdi
            // 
            txtEdi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdi.Location = new Point(164, 258);
            txtEdi.Name = "txtEdi";
            txtEdi.Size = new Size(298, 39);
            txtEdi.TabIndex = 88;
            txtEdi.Visible = false;
            // 
            // txtTitulo
            // 
            txtTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitulo.Location = new Point(164, 159);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(298, 39);
            txtTitulo.TabIndex = 89;
            txtTitulo.Visible = false;
            // 
            // txtAutor
            // 
            txtAutor.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutor.Location = new Point(164, 208);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(298, 39);
            txtAutor.TabIndex = 90;
            txtAutor.Visible = false;
            // 
            // cbGenero
            // 
            cbGenero.BackColor = SystemColors.InactiveCaption;
            cbGenero.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Arte", "Épico", "Ensayo", "Ficción ", "Lírico", "Libros de texto", "Didáctico", "Dramático", "Novela", "Relato", "Poesía", "Referencia" });
            cbGenero.Location = new Point(239, 400);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(250, 33);
            cbGenero.TabIndex = 91;
            cbGenero.Visible = false;
            cbGenero.SelectedIndexChanged += cbGenero_SelectedIndexChanged;
            // 
            // cbDispoL
            // 
            cbDispoL.BackColor = SystemColors.InactiveCaption;
            cbDispoL.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbDispoL.FormattingEnabled = true;
            cbDispoL.Items.AddRange(new object[] { "Disponible", "No Disponible" });
            cbDispoL.Location = new Point(239, 453);
            cbDispoL.Name = "cbDispoL";
            cbDispoL.Size = new Size(250, 33);
            cbDispoL.TabIndex = 92;
            cbDispoL.Visible = false;
            // 
            // cbIdiomas
            // 
            cbIdiomas.BackColor = SystemColors.InactiveCaption;
            cbIdiomas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbIdiomas.FormattingEnabled = true;
            cbIdiomas.Items.AddRange(new object[] { "Español", "Inglés", "Francés", "Otro" });
            cbIdiomas.Location = new Point(605, 139);
            cbIdiomas.Name = "cbIdiomas";
            cbIdiomas.Size = new Size(250, 33);
            cbIdiomas.TabIndex = 93;
            cbIdiomas.Visible = false;
            // 
            // datexd
            // 
            datexd.CustomFormat = "yyyy-MM";
            datexd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            datexd.Format = DateTimePickerFormat.Custom;
            datexd.Location = new Point(296, 324);
            datexd.Name = "datexd";
            datexd.Size = new Size(250, 39);
            datexd.TabIndex = 94;
            datexd.Visible = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(814, 27);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(22, 15);
            lblFecha.TabIndex = 95;
            lblFecha.Text = "XD";
            lblFecha.Visible = false;
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
            btActualizar.Location = new Point(312, 524);
            btActualizar.Name = "btActualizar";
            btActualizar.Size = new Size(150, 40);
            btActualizar.TabIndex = 96;
            btActualizar.Text = "       Actualizar";
            btActualizar.UseVisualStyleBackColor = false;
            btActualizar.Visible = false;
            btActualizar.Click += btActualizar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(486, 208);
            label11.Name = "label11";
            label11.Size = new Size(94, 32);
            label11.TabIndex = 97;
            label11.Text = "Paginas";
            // 
            // txtPaginas
            // 
            txtPaginas.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaginas.Location = new Point(605, 201);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Size = new Size(120, 39);
            txtPaginas.TabIndex = 98;
            txtPaginas.Visible = false;
            // 
            // DMLModiLibro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 644);
            Controls.Add(txtPaginas);
            Controls.Add(label11);
            Controls.Add(btActualizar);
            Controls.Add(lblFecha);
            Controls.Add(datexd);
            Controls.Add(cbIdiomas);
            Controls.Add(cbDispoL);
            Controls.Add(cbGenero);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(txtEdi);
            Controls.Add(txtCantida);
            Controls.Add(txtisb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btBuscar);
            Controls.Add(txtBuscarCodigo);
            Controls.Add(lb1);
            Name = "DMLModiLibro";
            Text = "DMLModiLibro";
            Load += DMLModiLibro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private TextBox txtBuscarCodigo;
        private ObjPersonalizados.CircleButton btBuscar;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtisb;
        private TextBox txtCantida;
        private TextBox txtEdi;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private ComboBox cbGenero;
        private ComboBox cbDispoL;
        private ComboBox cbIdiomas;
        private DateTimePicker datexd;
        private Label lblFecha;
        private ObjPersonalizados.ButtonDML btActualizar;
        private Label label11;
        private TextBox txtPaginas;
    }
}