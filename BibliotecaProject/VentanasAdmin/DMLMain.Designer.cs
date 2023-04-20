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
            BTNAlumDML = new Button();
            panelSubVentanas = new Panel();
            PanelDML.SuspendLayout();
            SuspendLayout();
            // 
            // PanelDML
            // 
            PanelDML.BackColor = Color.Fuchsia;
            PanelDML.Controls.Add(BTNAlumDML);
            PanelDML.Dock = DockStyle.Left;
            PanelDML.Location = new Point(0, 0);
            PanelDML.Name = "PanelDML";
            PanelDML.Size = new Size(200, 450);
            PanelDML.TabIndex = 0;
            // 
            // BTNAlumDML
            // 
            BTNAlumDML.Location = new Point(53, 51);
            BTNAlumDML.Name = "BTNAlumDML";
            BTNAlumDML.Size = new Size(75, 23);
            BTNAlumDML.TabIndex = 0;
            BTNAlumDML.Text = "button1";
            BTNAlumDML.UseVisualStyleBackColor = true;
            BTNAlumDML.Click += BTNAlumDML_Click;
            // 
            // panelSubVentanas
            // 
            panelSubVentanas.BackColor = Color.Black;
            panelSubVentanas.Dock = DockStyle.Fill;
            panelSubVentanas.Location = new Point(200, 0);
            panelSubVentanas.Name = "panelSubVentanas";
            panelSubVentanas.Size = new Size(600, 450);
            panelSubVentanas.TabIndex = 1;
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
        private Button BTNAlumDML;
        private Panel panelSubVentanas;
    }
}