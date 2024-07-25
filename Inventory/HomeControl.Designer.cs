namespace Inventory
{
    partial class HomeControl
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
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(51, 98);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 2;
            label2.Text = "/ Homepage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(31, 31, 31);
            label1.Location = new Point(48, 58);
            label1.Name = "label1";
            label1.Size = new Size(93, 33);
            label1.TabIndex = 1;
            label1.Text = "Home";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(248, 248, 248);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(48);
            panel5.Size = new Size(1340, 860);
            panel5.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(213, 218, 223);
            panel2.Location = new Point(62, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 1);
            panel2.TabIndex = 8;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Name = "HomeControl";
            Size = new Size(1340, 860);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label1;
        private Panel panel5;
        private Panel panel2;
    }
}
