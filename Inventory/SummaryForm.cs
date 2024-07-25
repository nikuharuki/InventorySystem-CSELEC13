using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class SummaryForm : Form
    {
        public SummaryForm()
        {
            InitializeComponent();
        }

        public void UpdateSummary(List<Product> products)
        {
            int totalProducts = products.Count;
            double totalValue = products.Sum(p => p.Stock * p.Price);
            int totalStock = products.Sum(p => p.Stock);

            products_lbl.Text = $"{totalProducts}";
            value_lbl.Text = $"Php {totalValue:F2}";
            stocks_lbl.Text = $"Total Stock: {totalStock}";
        }
    }
}
