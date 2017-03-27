using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    public class Sales
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public decimal Sale
        {
            get
            {
                return Price * Quantity;
            }
        }
    }
}
