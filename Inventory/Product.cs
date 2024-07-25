using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Product
    {
        public Boolean isChecked { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string ProductID { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }
}
