namespace Secret_Library
{
    partial class AdminDataUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(guna2GradientPanel1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 526);
            panel1.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.White;
            guna2GradientPanel1.BorderRadius = 10;
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.Location = new Point(31, 130);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(827, 378);
            guna2GradientPanel1.TabIndex = 1;
            guna2GradientPanel1.Paint += guna2GradientPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(896, 110);
            panel2.TabIndex = 0;
            // 
            // AdminDataUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "AdminDataUserControl";
            Size = new Size(896, 526);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}
