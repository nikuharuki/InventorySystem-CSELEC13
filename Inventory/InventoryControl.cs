using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.DataFormats;

namespace Inventory
{
    public partial class InventoryControl : UserControl
    {
        private int nextProductId = 1;
        private List<Product> products = new List<Product>();
        private string dataFilePath = "products.csv"; 
        public InventoryControl()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            using (AddInventory addInv = new AddInventory())
            {
                if (addInv.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the product and add it to the DataGridView
                    Product product = addInv.NewProduct;
                    product.ID = nextProductId++; // Assign and increment the ID
                    products.Add(product); // Add product to the list
                    AddProductToDataGridView(product);
                }
            }
        }
        private void AddProductToDataGridView(Product product)
        {
            inventory_dgv.Rows.Add(product.isChecked, product.ID, product.Name, product.ProductID, product.Category, product.Stock, product.Price);
        }

        public void SaveData(string filePath)
        {
            try
            {
                var lines = new List<string>();
                foreach (var product in products)
                {
                    var line = $"{product.isChecked},{product.ID},{product.Name},{product.ProductID},{product.Category},{product.Stock},{product.Price}";
                    lines.Add(line);
                }

                File.WriteAllLines(filePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }
        public void ClearData()
        {
            inventory_dgv.Rows.Clear();
            products.Clear();
            nextProductId = 1;
        }

        public void LoadData(string filePath)
        {
            try
            {
                // Clear current data
                inventory_dgv.Rows.Clear();
                products.Clear();

                // Check if the file exists
                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);

                    foreach (var line in lines)
                    {
                        var values = line.Split(',');

                        if (values.Length >= 6)
                        {
                            var product = new Product
                            {
                                isChecked = bool.Parse(values[0]),
                                ID = int.Parse(values[1]),
                                Name = values[2],
                                ProductID = values[3],
                                Category = values[4],
                                Stock = int.Parse(values[5]),
                                Price = int.Parse(values[6])
                            };

                            products.Add(product);
                            AddProductToDataGridView(product);
                        }
                    }

                    // Update the nextProductId based on the highest ID in the file
                    if (products.Count > 0)
                    {
                        nextProductId = products.Max(p => p.ID) + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void inventory_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7) //  Edit button
            {

                Product productToEdit = products[e.RowIndex];

                using (AddInventory editInv = new AddInventory(productToEdit))
                {

                    if (editInv.ShowDialog() == DialogResult.OK)
                    {

                        products[e.RowIndex] = editInv.NewProduct;


                        inventory_dgv.Rows[e.RowIndex].Cells[0].Value = editInv.NewProduct.isChecked;
                        inventory_dgv.Rows[e.RowIndex].Cells[1].Value = editInv.NewProduct.ID;
                        inventory_dgv.Rows[e.RowIndex].Cells[2].Value = editInv.NewProduct.Name;
                        inventory_dgv.Rows[e.RowIndex].Cells[3].Value = editInv.NewProduct.ProductID;
                        inventory_dgv.Rows[e.RowIndex].Cells[4].Value = editInv.NewProduct.Category;
                        inventory_dgv.Rows[e.RowIndex].Cells[5].Value = editInv.NewProduct.Stock;
                        inventory_dgv.Rows[e.RowIndex].Cells[6].Value = editInv.NewProduct.Price;
                    }
                }
            }
            else if (e.ColumnIndex == 8) // Delete button
            {
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    inventory_dgv.Rows.RemoveAt(e.RowIndex);

                    products.RemoveAt(e.RowIndex);
                }
            }
        }

        private void inventory_dgv_Paint(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            SummaryForm summaryForm = new SummaryForm();

            summaryForm.UpdateSummary(products);

            summaryForm.ShowDialog();
        }
    }
}
