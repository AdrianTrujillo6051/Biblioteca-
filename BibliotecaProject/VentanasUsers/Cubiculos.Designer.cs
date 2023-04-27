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
            components = new System.ComponentModel.Container();
            panelFondo = new Panel();
            subPanelNavigator = new Panel();
            panelCubiculos = new FlowLayoutPanel();
            panelDiv = new Panel();
            DesplegarBTN = new Button();
            panelManipulacion = new Panel();
            PedirBTN = new ObjPersonalizados.ButtonDML();
            DevolverBTN = new ObjPersonalizados.ButtonDML();
            label9 = new Label();
            TXTCodCubDev = new ObjPersonalizados.TextBoxPers();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            TXTFecha = new ObjPersonalizados.TextBoxPers();
            label5 = new Label();
            TXTHora = new ObjPersonalizados.TextBoxPers();
            label4 = new Label();
            TXTCodigoAlum = new ObjPersonalizados.TextBoxPers();
            label3 = new Label();
            label2 = new Label();
            TXTCodCubPres = new ObjPersonalizados.TextBoxPers();
            label1 = new Label();
            CubiculosInfoDGV = new DataGridView();
            errorFormulario = new ErrorProvider(components);
            panelFondo.SuspendLayout();
            subPanelNavigator.SuspendLayout();
            panelDiv.SuspendLayout();
            panelManipulacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CubiculosInfoDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorFormulario).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.Controls.Add(subPanelNavigator);
            panelFondo.Controls.Add(panelDiv);
            panelFondo.Controls.Add(panelManipulacion);
            panelFondo.Dock = DockStyle.Fill;
            panelFondo.Location = new Point(0, 0);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(1105, 715);
            panelFondo.TabIndex = 2;
            // 
            // subPanelNavigator
            // 
            subPanelNavigator.Controls.Add(panelCubiculos);
            subPanelNavigator.Dock = DockStyle.Fill;
            subPanelNavigator.Location = new Point(481, 0);
            subPanelNavigator.Name = "subPanelNavigator";
            subPanelNavigator.Size = new Size(624, 715);
            subPanelNavigator.TabIndex = 3;
            // 
            // panelCubiculos
            // 
            panelCubiculos.AutoScroll = true;
            panelCubiculos.Dock = DockStyle.Fill;
            panelCubiculos.Location = new Point(0, 0);
            panelCubiculos.Name = "panelCubiculos";
            panelCubiculos.Padding = new Padding(20);
            panelCubiculos.Size = new Size(624, 715);
            panelCubiculos.TabIndex = 3;
            // 
            // panelDiv
            // 
            panelDiv.BackColor = Color.FromArgb(19, 45, 70);
            panelDiv.Controls.Add(DesplegarBTN);
            panelDiv.Dock = DockStyle.Left;
            panelDiv.Location = new Point(432, 0);
            panelDiv.Name = "panelDiv";
            panelDiv.Size = new Size(49, 715);
            panelDiv.TabIndex = 4;
            // 
            // DesplegarBTN
            // 
            DesplegarBTN.BackColor = Color.Transparent;
            DesplegarBTN.Dock = DockStyle.Top;
            DesplegarBTN.FlatStyle = FlatStyle.Popup;
            DesplegarBTN.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            DesplegarBTN.ForeColor = SystemColors.Control;
            DesplegarBTN.Location = new Point(0, 0);
            DesplegarBTN.Name = "DesplegarBTN";
            DesplegarBTN.Size = new Size(49, 58);
            DesplegarBTN.TabIndex = 9;
            DesplegarBTN.Text = ">";
            DesplegarBTN.UseVisualStyleBackColor = false;
            DesplegarBTN.Click += DesplegarBTN_Click;
            // 
            // panelManipulacion
            // 
            panelManipulacion.AutoScroll = true;
            panelManipulacion.BackColor = Color.FromArgb(19, 45, 70);
            panelManipulacion.Controls.Add(PedirBTN);
            panelManipulacion.Controls.Add(DevolverBTN);
            panelManipulacion.Controls.Add(label9);
            panelManipulacion.Controls.Add(TXTCodCubDev);
            panelManipulacion.Controls.Add(label8);
            panelManipulacion.Controls.Add(label7);
            panelManipulacion.Controls.Add(label6);
            panelManipulacion.Controls.Add(TXTFecha);
            panelManipulacion.Controls.Add(label5);
            panelManipulacion.Controls.Add(TXTHora);
            panelManipulacion.Controls.Add(label4);
            panelManipulacion.Controls.Add(TXTCodigoAlum);
            panelManipulacion.Controls.Add(label3);
            panelManipulacion.Controls.Add(label2);
            panelManipulacion.Controls.Add(TXTCodCubPres);
            panelManipulacion.Controls.Add(label1);
            panelManipulacion.Controls.Add(CubiculosInfoDGV);
            panelManipulacion.Dock = DockStyle.Left;
            panelManipulacion.Location = new Point(0, 0);
            panelManipulacion.Name = "panelManipulacion";
            panelManipulacion.Size = new Size(432, 715);
            panelManipulacion.TabIndex = 2;
            // 
            // PedirBTN
            // 
            PedirBTN.BackColor = Color.FromArgb(106, 110, 121);
            PedirBTN.FlatAppearance.BorderSize = 0;
            PedirBTN.FlatStyle = FlatStyle.Flat;
            PedirBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PedirBTN.ForeColor = Color.White;
            PedirBTN.Location = new Point(236, 345);
            PedirBTN.Name = "PedirBTN";
            PedirBTN.Size = new Size(150, 40);
            PedirBTN.TabIndex = 22;
            PedirBTN.Text = "Confirmar";
            PedirBTN.UseVisualStyleBackColor = false;
            PedirBTN.Click += PedirBTN_Click;
            // 
            // DevolverBTN
            // 
            DevolverBTN.BackColor = Color.FromArgb(106, 110, 121);
            DevolverBTN.FlatAppearance.BorderSize = 0;
            DevolverBTN.FlatStyle = FlatStyle.Flat;
            DevolverBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DevolverBTN.ForeColor = Color.White;
            DevolverBTN.Location = new Point(236, 544);
            DevolverBTN.Name = "DevolverBTN";
            DevolverBTN.Size = new Size(150, 40);
            DevolverBTN.TabIndex = 21;
            DevolverBTN.Text = "Devolver";
            DevolverBTN.UseVisualStyleBackColor = false;
            DevolverBTN.Click += DevolverBTN_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(70, 485);
            label9.Name = "label9";
            label9.Size = new Size(96, 32);
            label9.TabIndex = 20;
            label9.Text = "Código:";
            // 
            // TXTCodCubDev
            // 
            TXTCodCubDev.BackColor = Color.Transparent;
            TXTCodCubDev.colorBorde = SystemColors.Control;
            TXTCodCubDev.ForeColor = Color.FromArgb(26, 30, 41);
            TXTCodCubDev.Location = new Point(172, 481);
            TXTCodCubDev.Name = "TXTCodCubDev";
            TXTCodCubDev.Padding = new Padding(7);
            TXTCodCubDev.passCaracter = false;
            TXTCodCubDev.Size = new Size(217, 36);
            TXTCodCubDev.soloLetras = false;
            TXTCodCubDev.soloNumeros = true;
            TXTCodCubDev.subrayadoEstilo = true;
            TXTCodCubDev.TabIndex = 19;
            TXTCodCubDev.tamanoBorde = 3;
            TXTCodCubDev.textBoxBackColor = Color.FromArgb(19, 45, 70);
            TXTCodCubDev.textBoxFontColor = SystemColors.Window;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(3, 433);
            label8.Name = "label8";
            label8.Size = new Size(194, 45);
            label8.TabIndex = 18;
            label8.Text = "Devolución";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(42, 234);
            label7.Name = "label7";
            label7.Size = new Size(121, 37);
            label7.TabIndex = 17;
            label7.Text = "Alumno:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(82, 180);
            label6.Name = "label6";
            label6.Size = new Size(81, 32);
            label6.TabIndex = 16;
            label6.Text = "Fecha:";
            // 
            // TXTFecha
            // 
            TXTFecha.BackColor = Color.Transparent;
            TXTFecha.colorBorde = SystemColors.Control;
            TXTFecha.ForeColor = Color.FromArgb(26, 30, 41);
            TXTFecha.Location = new Point(169, 176);
            TXTFecha.Name = "TXTFecha";
            TXTFecha.Padding = new Padding(7);
            TXTFecha.passCaracter = false;
            TXTFecha.Size = new Size(217, 36);
            TXTFecha.soloLetras = false;
            TXTFecha.soloNumeros = false;
            TXTFecha.subrayadoEstilo = true;
            TXTFecha.TabIndex = 15;
            TXTFecha.tamanoBorde = 3;
            TXTFecha.textBoxBackColor = Color.FromArgb(19, 45, 70);
            TXTFecha.textBoxFontColor = SystemColors.Window;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(93, 138);
            label5.Name = "label5";
            label5.Size = new Size(70, 32);
            label5.TabIndex = 14;
            label5.Text = "Hora:";
            // 
            // TXTHora
            // 
            TXTHora.BackColor = Color.Transparent;
            TXTHora.colorBorde = SystemColors.Control;
            TXTHora.ForeColor = Color.FromArgb(26, 30, 41);
            TXTHora.Location = new Point(169, 134);
            TXTHora.Name = "TXTHora";
            TXTHora.Padding = new Padding(7);
            TXTHora.passCaracter = false;
            TXTHora.Size = new Size(217, 36);
            TXTHora.soloLetras = false;
            TXTHora.soloNumeros = false;
            TXTHora.subrayadoEstilo = true;
            TXTHora.TabIndex = 13;
            TXTHora.tamanoBorde = 3;
            TXTHora.textBoxBackColor = Color.FromArgb(19, 45, 70);
            TXTHora.textBoxFontColor = SystemColors.Window;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(67, 282);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 12;
            label4.Text = "Código:";
            // 
            // TXTCodigoAlum
            // 
            TXTCodigoAlum.BackColor = Color.Transparent;
            TXTCodigoAlum.colorBorde = SystemColors.Control;
            TXTCodigoAlum.ForeColor = Color.FromArgb(26, 30, 41);
            TXTCodigoAlum.Location = new Point(169, 278);
            TXTCodigoAlum.Name = "TXTCodigoAlum";
            TXTCodigoAlum.Padding = new Padding(7);
            TXTCodigoAlum.passCaracter = false;
            TXTCodigoAlum.Size = new Size(217, 36);
            TXTCodigoAlum.soloLetras = false;
            TXTCodigoAlum.soloNumeros = true;
            TXTCodigoAlum.subrayadoEstilo = true;
            TXTCodigoAlum.TabIndex = 11;
            TXTCodigoAlum.tamanoBorde = 3;
            TXTCodigoAlum.textBoxBackColor = Color.FromArgb(19, 45, 70);
            TXTCodigoAlum.textBoxFontColor = SystemColors.Window;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(4, 5);
            label3.Name = "label3";
            label3.Size = new Size(169, 45);
            label3.TabIndex = 10;
            label3.Text = "Prestamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(67, 87);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 9;
            label2.Text = "Código:";
            // 
            // TXTCodCubPres
            // 
            TXTCodCubPres.BackColor = Color.Transparent;
            TXTCodCubPres.colorBorde = SystemColors.Control;
            TXTCodCubPres.ForeColor = Color.FromArgb(26, 30, 41);
            TXTCodCubPres.Location = new Point(169, 83);
            TXTCodCubPres.Name = "TXTCodCubPres";
            TXTCodCubPres.Padding = new Padding(7);
            TXTCodCubPres.passCaracter = false;
            TXTCodCubPres.Size = new Size(217, 36);
            TXTCodCubPres.soloLetras = false;
            TXTCodCubPres.soloNumeros = true;
            TXTCodCubPres.subrayadoEstilo = true;
            TXTCodCubPres.TabIndex = 7;
            TXTCodCubPres.tamanoBorde = 3;
            TXTCodCubPres.textBoxBackColor = Color.FromArgb(19, 45, 70);
            TXTCodCubPres.textBoxFontColor = SystemColors.Window;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(31, 50);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 6;
            label1.Text = "Cúbiculo:";
            // 
            // CubiculosInfoDGV
            // 
            CubiculosInfoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CubiculosInfoDGV.Dock = DockStyle.Bottom;
            CubiculosInfoDGV.Location = new Point(0, 682);
            CubiculosInfoDGV.Name = "CubiculosInfoDGV";
            CubiculosInfoDGV.RowTemplate.Height = 25;
            CubiculosInfoDGV.Size = new Size(432, 33);
            CubiculosInfoDGV.TabIndex = 2;
            // 
            // errorFormulario
            // 
            errorFormulario.ContainerControl = this;
            // 
            // Cubiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 715);
            Controls.Add(panelFondo);
            Name = "Cubiculos";
            Text = "Cubiculos";
            panelFondo.ResumeLayout(false);
            subPanelNavigator.ResumeLayout(false);
            panelDiv.ResumeLayout(false);
            panelManipulacion.ResumeLayout(false);
            panelManipulacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CubiculosInfoDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorFormulario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFondo;
        private FlowLayoutPanel panelCubiculos;
        private Panel panelManipulacion;
        private DataGridView CubiculosInfoDGV;
        private Label lb1;
        private Label label1;
        private Panel panelDiv;
        private ObjPersonalizados.TextBoxPers TXTCodCubPres;
        private Button DesplegarBTN;
        private Panel subPanelNavigator;
        private ObjPersonalizados.ButtonDML PedirBTN;
        private ObjPersonalizados.ButtonDML DevolverBTN;
        private Label label9;
        private ObjPersonalizados.TextBoxPers TXTCodCubDev;
        private Label label8;
        private Label label7;
        private Label label6;
        private ObjPersonalizados.TextBoxPers TXTFecha;
        private Label label5;
        private ObjPersonalizados.TextBoxPers TXTHora;
        private Label label4;
        private ObjPersonalizados.TextBoxPers TXTCodigoAlum;
        private Label label3;
        private Label label2;
        private ErrorProvider errorFormulario;
    }
}