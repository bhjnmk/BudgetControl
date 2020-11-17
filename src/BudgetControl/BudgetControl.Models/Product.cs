using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetControl.Models
{
    public class Product
    {
        public string Name { get; set; }

        public Category Category { get; set; }

        public double Value { get; set; }
    }
}