namespace Secret_Library
{
    partial class AdminEditUserControl
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            AdminEditlbl = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 400);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(AdminEditlbl);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(785, 76);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 324);
            panel3.TabIndex = 1;
            // 
            // AdminEditlbl
            // 
            AdminEditlbl.AutoSize = true;
            AdminEditlbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AdminEditlbl.Location = new Point(358, 22);
            AdminEditlbl.Name = "AdminEditlbl";
            AdminEditlbl.Size = new Size(68, 38);
            AdminEditlbl.TabIndex = 0;
            AdminEditlbl.Text = "Edit";
            // 
            // AdminEditUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "AdminEditUserControl";
            Size = new Size(785, 400);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label AdminEditlbl;
    }
}
