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
            panelSubVentanas = new Panel();
            AlumnBtn = new Button();
            PanelDML.SuspendLayout();
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
            // panelSubVentanas
            // 
            panelSubVentanas.BackColor = SystemColors.Control;
            panelSubVentanas.Dock = DockStyle.Fill;
            panelSubVentanas.Location = new Point(253, 0);
            panelSubVentanas.Name = "panelSubVentanas";
            panelSubVentanas.Size = new Size(547, 450);
            panelSubVentanas.TabIndex = 1;
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
            AlumnBtn.Click += AlumnBtn_Click;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelDML;
        private Panel panelSubVentanas;
        private Button AlumnBtn;
    }
}