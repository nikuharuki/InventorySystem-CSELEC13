namespace Inventory
{
    partial class AboutControl
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
            panel5 = new Panel();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(248, 248, 248);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(guna2PictureBox1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(48);
            panel5.Size = new Size(1340, 860);
            panel5.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(123, 88, 208);
            label3.Location = new Point(152, 516);
            label3.Name = "label3";
            label3.Size = new Size(102, 34);
            label3.TabIndex = 12;
            label3.Text = "SEG31";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.WindowFrame;
            label5.Location = new Point(152, 477);
            label5.Name = "label5";
            label5.Size = new Size(258, 34);
            label5.TabIndex = 11;
            label5.Text = "By Nikos L. Pasion";
            // 
            // label4
            // 
            label4.Font = new Font("Inter", 54F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(31, 31, 31);
            label4.Location = new Point(130, 239);
            label4.Name = "label4";
            label4.Size = new Size(1073, 238);
            label4.TabIndex = 9;
            label4.Text = "Inventory Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(213, 218, 223);
            panel2.Location = new Point(62, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(1207, 1);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(51, 98);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 2;
            label2.Text = "/ About";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(31, 31, 31);
            label1.Location = new Point(48, 58);
            label1.Name = "label1";
            label1.Size = new Size(96, 33);
            label1.TabIndex = 1;
            label1.Text = "About";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.BackgroundImage = Properties.Resources.Black_and_Grey_Minimalist_Creative_Modern_Simple__Square_Hipster_Helium_Studio_Logo__1_;
            guna2PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.FillColor = Color.Empty;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(-137, 177);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(2121, 907);
            guna2PictureBox1.TabIndex = 13;
            guna2PictureBox1.TabStop = false;
            // 
            // AboutControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 248, 248);
            Controls.Add(panel5);
            Name = "AboutControl";
            Size = new Size(1340, 860);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}
