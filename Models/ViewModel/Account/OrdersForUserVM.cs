using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_ASP.Models.ViewModel.Account
{
    public class OrdersForUserVM
    {
        public int OrderNumber { get; set; }
        public decimal Total { get; set; }
        public Dictionary<string, int> ProductsAndQty { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}