using System;
using System.Collections.Generic;

#nullable disable

namespace ShopBridge.Models
{
    public partial class Inventory
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
