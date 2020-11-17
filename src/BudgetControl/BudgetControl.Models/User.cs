using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetControl.Models
{
    class User
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public bool NameUsedInApp { get; set; }
    }
}