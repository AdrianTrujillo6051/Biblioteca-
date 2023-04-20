namespace BibliotecaProject.VentanasUsers
{
    partial class Cubiculos
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
            panelFondo = new Panel();
            panelCubiculos = new FlowLayoutPanel();
            panelManipulacion = new Panel();
            CubiculosInfoDGV = new DataGridView();
            panelFondo.SuspendLayout();
            panelManipulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CubiculosInfoDGV).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.Controls.Add(panelCubiculos);
            panelFondo.Controls.Add(panelManipulacion);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(800, 450);
            panelFondo.TabIndex = 2;
            // 
            // panelCubiculos
            // 
            panelCubiculos.AutoScroll = true;
            panelCubiculos.Dock = DockStyle.Fill;
            panelCubiculos.Location = new Point(312, 0);
            panelCubiculos.Name = "panelCubiculos";
            panelCubiculos.Padding = new Padding(20);
            panelCubiculos.Size = new Size(488, 450);
            panelCubiculos.TabIndex = 3;
            // 
            // panelManipulacion
            // 
            panelManipulacion.BackColor = Color.FromArgb(19, 45, 70);
            panelManipulacion.Controls.Add(CubiculosInfoDGV);
            panelManipulacion.Dock = DockStyle.Left;
            panelManipulacion.Location = new Point(0, 0);
            panelManipulacion.Name = "panelManipulacion";
            panelManipulacion.Size = new Size(312, 450);
            panelManipulacion.TabIndex = 2;
            // 
            // CubiculosInfoDGV
            // 
            CubiculosInfoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CubiculosInfoDGV.Dock = DockStyle.Bottom;
            CubiculosInfoDGV.Location = new Point(0, 417);
            CubiculosInfoDGV.Name = "CubiculosInfoDGV";
            CubiculosInfoDGV.RowTemplate.Height = 25;
            CubiculosInfoDGV.Size = new Size(312, 33);
            CubiculosInfoDGV.TabIndex = 2;
            // 
            // Cubiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFondo);
            Name = "Cubiculos";
            Text = "Cubiculos";
            panelFondo.ResumeLayout(false);
            panelManipulacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CubiculosInfoDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFondo;
        private FlowLayoutPanel panelCubiculos;
        private Panel panelManipulacion;
        private DataGridView CubiculosInfoDGV;
        private Label lb1;
    }
}