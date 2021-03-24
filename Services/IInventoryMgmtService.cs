using ShopBridge.Models;
using ShopBridge.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Services
{
    public interface IInventoryMgmtService
    {
        public Task<List<InventoryDTO>> GetItems();

        public Task<int> AddItem(InventoryDTO inventoryDTO);

        public Task DeleteItem(int id);

        public Task UpdateItem(InventoryDTO inventoryDTO);
    }
}
