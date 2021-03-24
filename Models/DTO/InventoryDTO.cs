using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopBridge.Models.Enums;

namespace ShopBridge.Models.DTO
{
    public class InventoryDTO
    {

        public InventoryDTO() { }
        public InventoryDTO(Inventory inventory) 
        {
            this.ItemId = inventory.ItemId; 
            this.Name = inventory.Name;
            this.Description = inventory.Description;
            Enum.TryParse(inventory.Category, out Category category);
            this.Category = category;
            this.Price = inventory.Price;
        }


        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }
        //public DateTime DateAdded { get; set; }
        //public DateTime? DateUpdated { get; set; }

        public Inventory ToInventory() 
        {
            Inventory inventory = new Inventory();

            inventory.ItemId = (this.ItemId <= 0 )? 0 : this.ItemId;
            inventory.Name = this.Name;
            inventory.Description = this.Description;
            inventory.Price = this.Price;
            inventory.Category = this.Category.ToString();

            return inventory;
        }
    }
}
