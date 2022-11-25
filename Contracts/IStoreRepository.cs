using StoreApi.Models;

namespace StoreApi.Contracts;

public interface IStoreRepository
{
    Task<Store> AddStoreAsync(Store store);
    Task<bool> UpdateStoreAsync(Store store);
    Task<bool> DeleteStoreAsync(int id);
    Task<IEnumerable<Store>> GetAllAsync();
    Task<Store> GetByIdAsync(int id);
}
