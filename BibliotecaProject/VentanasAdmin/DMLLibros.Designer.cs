namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMLLibros));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtISBN = new ObjPersonalizados.TextBoxDML();
            txtTitulo = new ObjPersonalizados.TextBoxDML();
            txtAutor = new ObjPersonalizados.TextBoxDML();
            txtEditorial = new ObjPersonalizados.TextBoxDML();
            cbGenero = new ComboBox();
            cbIdiomas = new ComboBox();
            txtCanPres = new ObjPersonalizados.TextBoxDML();
            txtPaginas = new ObjPersonalizados.TextBoxDML();
            txtFechaPubli = new ObjPersonalizados.TextBoxDML();
            btGuardarLibro = new ObjPersonalizados.ButtonDML();
            pictureBox1 = new PictureBox();
            cbDispoL = new ComboBox();
            errorFormulario = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorFormulario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 5;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(75, 32);
            label2.TabIndex = 6;
            label2.Text = "Título";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 7;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(16, 164);
            label4.Name = "label4";
            label4.Size = new Size(100, 32);
            label4.TabIndex = 8;
            label4.Text = "Editorial";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 220);
            label5.Name = "label5";
            label5.Size = new Size(239, 32);
            label5.TabIndex = 9;
            label5.Text = "Fecha de publicación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 279);
            label6.Name = "label6";
            label6.Size = new Size(92, 32);
            label6.TabIndex = 10;
            label6.Text = "Género";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 345);
            label7.Name = "label7";
            label7.Size = new Size(167, 32);
            label7.TabIndex = 11;
            label7.Text = "Disponibilidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 415);
            label8.Name = "label8";
            label8.Size = new Size(253, 32);
            label8.TabIndex = 12;
            label8.Text = "Cantidad de prestados";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(16, 475);
            label9.Name = "label9";
            label9.Size = new Size(97, 32);
            label9.TabIndex = 13;
            label9.Text = "Idiomas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(19, 530);
            label10.Name = "label10";
            label10.Size = new Size(94, 32);
            label10.TabIndex = 14;
            label10.Text = "Páginas";
            // 
            // txtISBN
            // 
            txtISBN.BackColor = Color.Transparent;
            txtISBN.ForeColor = Color.FromArgb(26, 30, 41);
            txtISBN.Location = new Point(266, 5);
            txtISBN.Name = "txtISBN";
            txtISBN.Padding = new Padding(7);
            txtISBN.passCaracter = false;
            txtISBN.Size = new Size(250, 36);
            txtISBN.soloLetras = false;
            txtISBN.soloNumeros = false;
            txtISBN.TabIndex = 16;
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = Color.Transparent;
            txtTitulo.ForeColor = Color.FromArgb(26, 30, 41);
            txtTitulo.Location = new Point(266, 58);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Padding = new Padding(7);
            txtTitulo.passCaracter = false;
            txtTitulo.Size = new Size(250, 36);
            txtTitulo.soloLetras = false;
            txtTitulo.soloNumeros = false;
            txtTitulo.TabIndex = 17;
            // 
            // txtAutor
            // 
            txtAutor.BackColor = Color.Transparent;
            txtAutor.ForeColor = Color.FromArgb(26, 30, 41);
            txtAutor.Location = new Point(266, 109);
            txtAutor.Name = "txtAutor";
            txtAutor.Padding = new Padding(7);
            txtAutor.passCaracter = false;
            txtAutor.Size = new Size(250, 36);
            txtAutor.soloLetras = false;
            txtAutor.soloNumeros = false;
            txtAutor.TabIndex = 18;
            // 
            // txtEditorial
            // 
            txtEditorial.BackColor = Color.Transparent;
            txtEditorial.ForeColor = Color.FromArgb(26, 30, 41);
            txtEditorial.Location = new Point(266, 160);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Padding = new Padding(7);
            txtEditorial.passCaracter = false;
            txtEditorial.Size = new Size(250, 36);
            txtEditorial.soloLetras = false;
            txtEditorial.soloNumeros = false;
            txtEditorial.TabIndex = 19;
            txtEditorial.Load += txtEditorial_Load;
            // 
            // cbGenero
            // 
            cbGenero.BackColor = SystemColors.InactiveCaption;
            cbGenero.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Arte", "Épico", "Ensayo", "Ficción ", "Lírico", "Libros de texto", "Didáctico", "Dramático", "Novela", "Relato", "Poesía", "Referencia" });
            cbGenero.Location = new Point(266, 278);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(250, 33);
            cbGenero.TabIndex = 20;
            // 
            // cbIdiomas
            // 
            cbIdiomas.BackColor = SystemColors.InactiveCaption;
            cbIdiomas.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbIdiomas.FormattingEnabled = true;
            cbIdiomas.Items.AddRange(new object[] { "Español", "Inglés", "Francés", "Otro" });
            cbIdiomas.Location = new Point(275, 478);
            cbIdiomas.Name = "cbIdiomas";
            cbIdiomas.Size = new Size(250, 33);
            cbIdiomas.TabIndex = 21;
            // 
            // txtCanPres
            // 
            txtCanPres.BackColor = Color.Transparent;
            txtCanPres.ForeColor = Color.FromArgb(26, 30, 41);
            txtCanPres.Location = new Point(275, 411);
            txtCanPres.Name = "txtCanPres";
            txtCanPres.Padding = new Padding(7);
            txtCanPres.passCaracter = false;
            txtCanPres.Size = new Size(250, 36);
            txtCanPres.soloLetras = false;
            txtCanPres.soloNumeros = false;
            txtCanPres.TabIndex = 25;
            // 
            // txtPaginas
            // 
            txtPaginas.BackColor = Color.Transparent;
            txtPaginas.ForeColor = Color.FromArgb(26, 30, 41);
            txtPaginas.Location = new Point(275, 530);
            txtPaginas.Name = "txtPaginas";
            txtPaginas.Padding = new Padding(7);
            txtPaginas.passCaracter = false;
            txtPaginas.Size = new Size(250, 36);
            txtPaginas.soloLetras = false;
            txtPaginas.soloNumeros = false;
            txtPaginas.TabIndex = 26;
            // 
            // txtFechaPubli
            // 
            txtFechaPubli.BackColor = Color.Transparent;
            txtFechaPubli.ForeColor = Color.FromArgb(26, 30, 41);
            txtFechaPubli.Location = new Point(266, 216);
            txtFechaPubli.Name = "txtFechaPubli";
            txtFechaPubli.Padding = new Padding(7);
            txtFechaPubli.passCaracter = false;
            txtFechaPubli.Size = new Size(250, 36);
            txtFechaPubli.soloLetras = false;
            txtFechaPubli.soloNumeros = false;
            txtFechaPubli.TabIndex = 27;
            // 
            // btGuardarLibro
            // 
            btGuardarLibro.BackColor = Color.FromArgb(106, 110, 121);
            btGuardarLibro.FlatAppearance.BorderSize = 0;
            btGuardarLibro.FlatStyle = FlatStyle.Flat;
            btGuardarLibro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btGuardarLibro.ForeColor = Color.White;
            btGuardarLibro.Image = Properties.Resources.yes;
            btGuardarLibro.ImageAlign = ContentAlignment.MiddleLeft;
            btGuardarLibro.Location = new Point(281, 584);
            btGuardarLibro.Name = "btGuardarLibro";
            btGuardarLibro.Size = new Size(235, 39);
            btGuardarLibro.TabIndex = 29;
            btGuardarLibro.Text = "     Guardar";
            btGuardarLibro.UseVisualStyleBackColor = false;
            btGuardarLibro.Click += btGuardarLibro_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(741, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(539, 498);
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // cbDispoL
            // 
            cbDispoL.BackColor = SystemColors.InactiveCaption;
            cbDispoL.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbDispoL.FormattingEnabled = true;
            cbDispoL.Items.AddRange(new object[] { "Disponible", "No Disponible" });
            cbDispoL.Location = new Point(266, 348);
            cbDispoL.Name = "cbDispoL";
            cbDispoL.Size = new Size(250, 33);
            cbDispoL.TabIndex = 31;
            // 
            // errorFormulario
            // 
            errorFormulario.ContainerControl = this;
            // 
            // DMLLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 635);
            Controls.Add(cbDispoL);
            Controls.Add(pictureBox1);
            Controls.Add(btGuardarLibro);
            Controls.Add(txtFechaPubli);
            Controls.Add(txtPaginas);
            Controls.Add(txtCanPres);
            Controls.Add(cbIdiomas);
            Controls.Add(cbGenero);
            Controls.Add(txtEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(txtISBN);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DMLLibros";
            Text = "Idiomas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorFormulario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ObjPersonalizados.TextBoxDML txtISBN;
        private ObjPersonalizados.TextBoxDML txtTitulo;
        private ObjPersonalizados.TextBoxDML txtAutor;
        private ObjPersonalizados.TextBoxDML txtEditorial;
        private ComboBox cbGenero;
        private ComboBox cbIdiomas;
        private ObjPersonalizados.TextBoxDML txtCanPres;
        private ObjPersonalizados.TextBoxDML txtPaginas;
        private ObjPersonalizados.TextBoxDML txtFechaPubli;
        private ObjPersonalizados.ButtonDML btGuardarLibro;
        private PictureBox pictureBox1;
        private ComboBox cbDispoL;
        private ErrorProvider errorFormulario;
    }
}