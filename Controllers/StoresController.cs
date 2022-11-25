using Microsoft.AspNetCore.Mvc;
using StoreApi.Contracts;
using StoreApi.Models;

namespace StoreApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoresController : ControllerBase
    {
        private readonly IStoreRepository repository;
        public StoresController(IStoreRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await repository.GetAllAsync());
        }

        [HttpGet("{id:int}", Name = "GetStoreById")]
        public async Task<IActionResult> GetAsync(int id)
        {
            var store = await repository.GetByIdAsync(id);

            return store is null
                ? NotFound("Store not found.")
                : Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Store store)
        {
            if (store is null) return BadRequest("Error. Check the field(s) and try again.");

            await repository.AddStoreAsync(store);

            return CreatedAtRoute("GetStoreById", new { id = store.StoreId }, store);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutAsync(int id, Store store)
        {
            if (store.StoreId != id) return BadRequest("Error. Check the field(s) and try again.");

            var st = await repository.GetByIdAsync(id);
            if (st is null) return NotFound("Store not found.");

            return Ok(await repository.UpdateStoreAsync(store));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var st = await repository.GetByIdAsync(id);
            if (st is null) return NotFound("Store not found.");

            await repository.DeleteStoreAsync(id);

            return NoContent();
        }
    }
}