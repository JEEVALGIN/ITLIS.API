using ITLIS.Models.Input;
using ITLIS.Service.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ITLIS.Areas.Inventory
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        IInventoryService _inventoryService;
        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        // GET: api/<InventoryController>
        [HttpGet]
        [ActionName("GetInventoryDetails")]
        public async Task<IActionResult> GetInventoryDetailsAsync()
        {
            return Ok(await _inventoryService.GetInventoryDetailsAsync());
        }

        // GET api/<InventoryController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInventoryDetailsByIdAsync(int id)
        {
            return Ok(await _inventoryService.GetInventoryDetailsByIdAsync(id));
        }

        // POST api/<InventoryController>
        [HttpPost]
        [ActionName("InsertInventoryDetailsAsync")]
        public async Task<IActionResult> InsertInventoryDetailsAsync([FromBody] InventoryDetailDTO obj)
        {
            return Ok(await _inventoryService.InsertInventoryDetailsAsync(obj));
        }

        // PUT api/<InventoryController>/5
        [HttpPut("{id}")]
        [ActionName("UpdateInventoryDetailsAsync")]
        public async Task<IActionResult> UpdateInventoryDetailsAsync(int id, [FromBody] InventoryDetailDTO obj)
        {
            obj.DeviceId = id;
            return Ok(await _inventoryService.UpdateInventoryDetailsAsync(obj));
        }

        // DELETE api/<InventoryController>/5
        [HttpDelete("{id}")]
        [ActionName("DeleteInventoryDetailsByIdAsync")]
        public async Task<IActionResult> DeleteInventoryDetailsByIdAsync(int id)
        {
            return Ok(await _inventoryService.DeleteInventoryDetailsByIdAsync(id));
        }
    }
}
