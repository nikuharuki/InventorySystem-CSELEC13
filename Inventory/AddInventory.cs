using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory
{
    public partial class AddInventory : Form
    {
        public Product NewProduct { get; private set; }



        public AddInventory(Product existingProduct = null)
        {
            InitializeComponent();

            if (existingProduct != null)
            {

                label1.Text = "Edit a Product";
                addItem_btn.Text = "Edit";

                name_tb.Text = existingProduct.Name;
                productId_tb.Text = existingProduct.ProductID.ToString();
                category_tb.Text = existingProduct.Category;
                stock_tb.Text = existingProduct.Stock.ToString();
                price_tb.Text = existingProduct.Price.ToString();

                NewProduct = existingProduct; 
            }
            else
            {
                // Set the form in add mode
                label1.Text = "Add a New Product";
                addItem_btn.Text = "Submit";

                NewProduct = new Product();
            }
        }

        private void addItem_btn_Click(object sender, EventArgs e)
        {
            // Update NewProduct with form data
            NewProduct.Name = name_tb.Text;
            NewProduct.ProductID = productId_tb.Text;
            NewProduct.Category = category_tb.Text;
            NewProduct.Stock = int.Parse(stock_tb.Text);
            NewProduct.Price = double.Parse(price_tb.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
