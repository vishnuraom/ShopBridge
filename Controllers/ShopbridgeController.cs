﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopBridge.Models;
using ShopBridge.Services;
using ShopBridge.Models.DTO;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopBridge.Controllers
{
    //[Route("api/inventory")]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {

        private IInventoryMgmtService _inventoryMgmtService;
        private readonly ILogger<InventoryController> _logger;

        public InventoryController(IInventoryMgmtService inventoryMgmtService, ILogger<InventoryController> logger)
        {
            _inventoryMgmtService = inventoryMgmtService;
            _logger = logger;
        }


        [HttpGet]
        [Route("GetItems")]

        public async Task<List<InventoryDTO>> Get()
        {
            return await this._inventoryMgmtService.GetItems();
        }

        // POST api/AddItem
        [HttpPost]
        [Route("AddItem")]
        public async Task<int> Post([FromBody]string _inventoryDto)
        {
            InventoryDTO inventoryDTO = JsonConvert.DeserializeObject<InventoryDTO>(_inventoryDto);
            return await this._inventoryMgmtService.AddItem(inventoryDTO);
        }

        // PUT api/UpdateItem
        [HttpPut]
        [Route("UpdateItem")]
        public void Put([FromBody] string _inventoryDto)
        {
            InventoryDTO inventoryDTO = JsonConvert.DeserializeObject<InventoryDTO>(_inventoryDto);
            this._inventoryMgmtService.UpdateItem(inventoryDTO); 
        }

        // DELETE api/DeleteItem
        [HttpDelete]
        [Route("DeleteItem")]
        public void Delete([FromBody] int id)
        {
            this._inventoryMgmtService.DeleteItem(id);
        }
    }
}
 