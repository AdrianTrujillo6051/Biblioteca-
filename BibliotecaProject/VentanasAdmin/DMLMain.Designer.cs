namespace BibliotecaProject.VentanasAdmin
{
    partial class DMLMain
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
            PanelDML = new Panel();
            AlumnBtn = new Button();
            panelSubVentanas = new Panel();
            buttondml1 = new ObjPersonalizados.ButtonDML();
            label1 = new Label();
            textBoxdml1 = new ObjPersonalizados.TextBoxDML();
            PanelDML.SuspendLayout();
            panelSubVentanas.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDML
            // 
            PanelDML.BackColor = Color.FromArgb(19, 45, 70);
            PanelDML.Controls.Add(AlumnBtn);
            PanelDML.Dock = DockStyle.Left;
            PanelDML.Location = new Point(0, 0);
            PanelDML.Name = "PanelDML";
            PanelDML.Size = new Size(253, 450);
            PanelDML.TabIndex = 0;
            // 
            // AlumnBtn
            // 
            AlumnBtn.BackColor = Color.Transparent;
            AlumnBtn.Dock = DockStyle.Top;
            AlumnBtn.FlatStyle = FlatStyle.Popup;
            AlumnBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AlumnBtn.ForeColor = SystemColors.Control;
            AlumnBtn.Location = new Point(0, 0);
            AlumnBtn.Name = "AlumnBtn";
            AlumnBtn.Size = new Size(253, 57);
            AlumnBtn.TabIndex = 3;
            AlumnBtn.Text = "Alumnos";
            AlumnBtn.UseVisualStyleBackColor = false;
            // 
            // panelSubVentanas
            // 
            panelSubVentanas.BackColor = SystemColors.Control;
            panelSubVentanas.Controls.Add(buttondml1);
            panelSubVentanas.Controls.Add(label1);
            panelSubVentanas.Controls.Add(textBoxdml1);
            panelSubVentanas.Dock = DockStyle.Fill;
            panelSubVentanas.Location = new Point(253, 0);
            panelSubVentanas.Name = "panelSubVentanas";
            panelSubVentanas.Size = new Size(547, 450);
            panelSubVentanas.TabIndex = 1;
            // 
            // buttondml1
            // 
            buttondml1.BackColor = Color.FromArgb(106, 110, 121);
            buttondml1.FlatAppearance.BorderSize = 0;
            buttondml1.FlatStyle = FlatStyle.Flat;
            buttondml1.ForeColor = Color.White;
            buttondml1.Location = new Point(276, 149);
            buttondml1.Name = "buttondml1";
            buttondml1.Size = new Size(150, 40);
            buttondml1.TabIndex = 2;
            buttondml1.Text = "buttondml1";
            buttondml1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 77);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 1;
            label1.Text = "Datos:";
            // 
            // textBoxdml1
            // 
            textBoxdml1.BackColor = Color.Transparent;
            textBoxdml1.ForeColor = Color.FromArgb(26, 30, 41);
            textBoxdml1.Location = new Point(176, 73);
            textBoxdml1.Name = "textBoxdml1";
            textBoxdml1.Padding = new Padding(7);
            textBoxdml1.passCaracter = false;
            textBoxdml1.Size = new Size(250, 36);
            textBoxdml1.TabIndex = 0;
            // 
            // DMLMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelSubVentanas);
            Controls.Add(PanelDML);
            Name = "DMLMain";
            Text = "DMLMain";
            PanelDML.ResumeLayout(false);
            panelSubVentanas.ResumeLayout(false);
            panelSubVentanas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDML;
        private Panel panelSubVentanas;
        private ObjPersonalizados.ButtonDML buttondml1;
        private Label label1;
        private ObjPersonalizados.TextBoxDML textBoxdml1;
        private Button AlumnBtn;
    }
}