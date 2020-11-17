using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetControl.Models
{
    class Purchase
    {
        public string Name { get; set; }

        public string ShopName { get; set; }

        public double Value { get; set; }

        public string ReceiptPath { get; set; }

        public List<Product> Products {get; set; }

    }
}
