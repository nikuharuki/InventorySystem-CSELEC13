namespace Inventory
{
    partial class SummaryForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            titlebar_pnl = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            products_lbl = new Label();
            label4 = new Label();
            value_lbl = new Label();
            label6 = new Label();
            ok_btn = new Guna.UI2.WinForms.Guna2Button();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            stocks_lbl = new Label();
            label5 = new Label();
            titlebar_pnl.SuspendLayout();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 24;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.CustomIconSize = 20F;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.Dock = DockStyle.Right;
            guna2ControlBox1.FillColor = Color.Transparent;
            guna2ControlBox1.IconColor = Color.Black;
            guna2ControlBox1.Location = new Point(610, 0);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(77, 61);
            guna2ControlBox1.TabIndex = 2;
            // 
            // titlebar_pnl
            // 
            titlebar_pnl.BackColor = Color.White;
            titlebar_pnl.Controls.Add(guna2ControlBox1);
            titlebar_pnl.Dock = DockStyle.Top;
            titlebar_pnl.Location = new Point(0, 0);
            titlebar_pnl.Name = "titlebar_pnl";
            titlebar_pnl.Size = new Size(687, 61);
            titlebar_pnl.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(213, 218, 223);
            panel2.Location = new Point(30, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 1);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(38, 111);
            label2.Name = "label2";
            label2.Size = new Size(223, 19);
            label2.TabIndex = 11;
            label2.Text = "Inventory / Inventory Summary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(31, 31, 31);
            label1.Location = new Point(35, 71);
            label1.Name = "label1";
            label1.Size = new Size(276, 33);
            label1.TabIndex = 10;
            label1.Text = "Inventory Summary";
            // 
            // products_lbl
            // 
            products_lbl.AutoSize = true;
            products_lbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            products_lbl.ForeColor = Color.FromArgb(31, 31, 31);
            products_lbl.Location = new Point(43, 253);
            products_lbl.Name = "products_lbl";
            products_lbl.Size = new Size(73, 19);
            products_lbl.TabIndex = 13;
            products_lbl.Text = "Products";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Inter", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(31, 31, 31);
            label4.Location = new Point(35, 213);
            label4.Name = "label4";
            label4.Size = new Size(191, 29);
            label4.TabIndex = 12;
            label4.Text = "Total Products:";
            // 
            // value_lbl
            // 
            value_lbl.AutoSize = true;
            value_lbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            value_lbl.ForeColor = Color.FromArgb(31, 31, 31);
            value_lbl.Location = new Point(334, 333);
            value_lbl.Name = "value_lbl";
            value_lbl.Size = new Size(48, 19);
            value_lbl.TabIndex = 15;
            value_lbl.Text = "Value";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Inter", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(31, 31, 31);
            label6.Location = new Point(326, 293);
            label6.Name = "label6";
            label6.Size = new Size(152, 29);
            label6.TabIndex = 14;
            label6.Text = "Total Value:";
            // 
            // ok_btn
            // 
            ok_btn.Animated = true;
            ok_btn.AnimatedGIF = true;
            ok_btn.BackColor = Color.Transparent;
            ok_btn.BorderColor = Color.Empty;
            ok_btn.BorderRadius = 12;
            ok_btn.BorderThickness = 2;
            ok_btn.CheckedState.FillColor = Color.FromArgb(57, 47, 82);
            ok_btn.CheckedState.Font = new Font("Inter SemiBold", 10.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ok_btn.Cursor = Cursors.Hand;
            ok_btn.CustomizableEdges = customizableEdges1;
            ok_btn.DisabledState.BorderColor = Color.DarkGray;
            ok_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            ok_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ok_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ok_btn.FillColor = Color.FromArgb(123, 88, 208);
            ok_btn.Font = new Font("Inter Medium", 10.7999992F);
            ok_btn.ForeColor = Color.White;
            ok_btn.ImageAlign = HorizontalAlignment.Left;
            ok_btn.Location = new Point(480, 363);
            ok_btn.Name = "ok_btn";
            ok_btn.PressedColor = Color.Empty;
            ok_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ok_btn.Size = new Size(174, 57);
            ok_btn.TabIndex = 18;
            ok_btn.Text = "OK";
            ok_btn.UseTransparentBackground = true;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = titlebar_pnl;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // stocks_lbl
            // 
            stocks_lbl.AutoSize = true;
            stocks_lbl.Font = new Font("Inter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocks_lbl.ForeColor = Color.FromArgb(31, 31, 31);
            stocks_lbl.Location = new Point(43, 333);
            stocks_lbl.Name = "stocks_lbl";
            stocks_lbl.Size = new Size(57, 19);
            stocks_lbl.TabIndex = 20;
            stocks_lbl.Text = "Stocks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Inter", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(31, 31, 31);
            label5.Location = new Point(35, 293);
            label5.Name = "label5";
            label5.Size = new Size(166, 29);
            label5.TabIndex = 19;
            label5.Text = "Total Stocks:";
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(687, 450);
            Controls.Add(stocks_lbl);
            Controls.Add(label5);
            Controls.Add(ok_btn);
            Controls.Add(value_lbl);
            Controls.Add(label6);
            Controls.Add(products_lbl);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(titlebar_pnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SummaryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SummaryForm";
            titlebar_pnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Panel titlebar_pnl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label value_lbl;
        private Label label6;
        private Label products_lbl;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button ok_btn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Label stocks_lbl;
        private Label label5;
    }
}