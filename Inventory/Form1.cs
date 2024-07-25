namespace Inventory
{
    public partial class Form1 : Form
    {
        InventoryControl invControl = new InventoryControl();
        HomeControl homeControl = new HomeControl();
        AboutControl aboutControl = new AboutControl();
        public Form1()
        {
            InitializeComponent();

        }

        public void Load_Form(object Form)
        {
            if (this.MainPanel.Controls.Count > 0) this.MainPanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nav_Clicked(object sender, EventArgs e)
        {
            home_bar.Visible = false;
            inventory_bar.Visible = false;
            about_bar.Visible = false;
            settings_bar.Visible = false;

            inventory_btn.Checked = false;
            home_btn.Checked = false;
            about_btn.Checked = false;

            if (sender == inventory_btn)
            {
                inventory_bar.Visible = true;
                inventory_btn.Checked = true;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(invControl);
                invControl.Dock = DockStyle.Fill;
            }
            else if (sender == home_btn)
            {
                home_bar.Visible = true;
                home_btn.Checked = true;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(homeControl);
                homeControl.Dock = DockStyle.Fill;
            }
            else if(sender == about_btn)
            {
                about_bar.Visible = true;
                about_btn.Checked = true;
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(aboutControl);
                aboutControl.Dock = DockStyle.Fill;
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Nav_Clicked(home_btn, EventArgs.Empty);

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Save Product Data";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    invControl.SaveData(saveFileDialog.FileName);
                }
            }
        }

        private void new_Clicked(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to create a new file? This will clear all current data.",
                               "Confirmation",
                               MessageBoxButtons.OKCancel,
                               MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                invControl.ClearData();
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Select a CSV file";

                // Show the dialog and check if a file was selected
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path
                    string filePath = openFileDialog.FileName;

                    // Load the data into InventoryControl
                    invControl.LoadData(filePath);
                }
            }
        }
    }
}
