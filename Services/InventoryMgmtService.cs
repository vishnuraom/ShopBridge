using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using ShopBridge.Models;
using ShopBridge.Controllers;
using ShopBridge.Models.DTO;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace ShopBridge.Services
{
    public class InventoryMgmtService : IInventoryMgmtService
    {

        private readonly ILogger<InventoryMgmtService> _logger;
        private ShopBridgeDbContext _dbContext;

        public InventoryMgmtService(ShopBridgeDbContext dbContext, ILogger<InventoryMgmtService> logger) 
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<List<InventoryDTO>> GetItems()
        {
            return await _dbContext.Inventories.Select(x => new InventoryDTO(x)).ToListAsync();
        }
        
        public async Task<int> AddItem(InventoryDTO inventoryDTO)
        {
            Inventory inventory = inventoryDTO.ToInventory();
            inventory.DateAdded = DateTime.Now;
            await _dbContext.Inventories.AddAsync(inventory);
            await _dbContext.SaveChangesAsync();
            return inventory.ItemId;
        }

        public async Task UpdateItem(InventoryDTO inventoryDTO)
        {
            Inventory inventory = inventoryDTO.ToInventory();
            inventory.DateUpdated = DateTime.Now;
            _dbContext.Inventories.Update(inventory);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteItem(int id)
        {
            //Inventory inven = await _dbContext.Inventories.FindAsync(id);
            //_dbContext.Inventories.Remove(inven);
            //var i = await _dbContext.SaveChangesAsync();
            //return i;

            using (ShopBridgeDbContext sdb = new ShopBridgeDbContext())
            {
                Inventory rec = await sdb.Inventories.FindAsync(id);
                sdb.Inventories.Remove(rec);
                await sdb.SaveChangesAsync();
            }
        }

    }
}
