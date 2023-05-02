namespace BibliotecaProject.VentanasUsers
{
    partial class BuscadorLibros
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            busquedaRETURN = new DataGridView();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            bookTXT = new TextBox();
            closeBTN = new ObjPersonalizados.CircleButton();
            ((System.ComponentModel.ISupportInitialize)busquedaRETURN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(19, 45, 70);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(191, 65);
            label1.TabIndex = 0;
            label1.Text = "Bookle";
            // 
            // busquedaRETURN
            // 
            busquedaRETURN.AllowUserToAddRows = false;
            busquedaRETURN.AllowUserToDeleteRows = false;
            busquedaRETURN.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            busquedaRETURN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            busquedaRETURN.Anchor = AnchorStyles.Top;
            busquedaRETURN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            busquedaRETURN.BackgroundColor = SystemColors.Control;
            busquedaRETURN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            busquedaRETURN.Location = new Point(109, 192);
            busquedaRETURN.Name = "busquedaRETURN";
            busquedaRETURN.ReadOnly = true;
            busquedaRETURN.RightToLeft = RightToLeft.No;
            busquedaRETURN.RowTemplate.Height = 25;
            busquedaRETURN.Size = new Size(598, 318);
            busquedaRETURN.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = Properties.Resources.important;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(282, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 31);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(26, 30, 41);
            label2.Location = new Point(310, 84);
            label2.Name = "label2";
            label2.Size = new Size(195, 42);
            label2.TabIndex = 17;
            label2.Text = "Escriba el nombre del libro\r\n               a buscar";
            // 
            // bookTXT
            // 
            bookTXT.Anchor = AnchorStyles.Top;
            bookTXT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bookTXT.Location = new Point(200, 140);
            bookTXT.Name = "bookTXT";
            bookTXT.Size = new Size(410, 29);
            bookTXT.TabIndex = 19;
            bookTXT.TextChanged += Buscando;
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
            closeBTN.Location = new Point(667, 36);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new Size(40, 40);
            closeBTN.TabIndex = 20;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = false;
            closeBTN.Click += closeBTN_Click;
            // 
            // BuscadorLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(closeBTN);
            Controls.Add(bookTXT);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(busquedaRETURN);
            Controls.Add(label1);
            Name = "BuscadorLibros";
            Text = "BuscadorLibros";
            ((System.ComponentModel.ISupportInitialize)busquedaRETURN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ObjPersonalizados.TextBoxPers textBoxPers1;
        private DataGridView busquedaRETURN;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox bookTXT;
        private ObjPersonalizados.CircleButton closeBTN;
    }
}