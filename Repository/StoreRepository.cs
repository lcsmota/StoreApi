using System.Data;
using Dapper.Contrib.Extensions;
using StoreApi.Contracts;
using StoreApi.Models;

namespace StoreApi.Repository;

public class StoreRepository : IStoreRepository
{
    private readonly IDbConnection dbConnection;
    public StoreRepository(IDbConnection dbConnection)
    {
        this.dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Store>> GetAllAsync()
    {
        var stores = await dbConnection.GetAllAsync<Store>();

        return stores.ToList();
    }

    public async Task<Store> GetByIdAsync(int id)
    {
        var store = await dbConnection.GetAsync<Store>(id);

        return store;
    }

    public async Task<Store> AddStoreAsync(Store store)
    {
        store.StoreId = await dbConnection.InsertAsync(store);

        return store;
    }

    public async Task<bool> DeleteStoreAsync(int id)
    {
        var result = await dbConnection.DeleteAsync(new Store { StoreId = id });

        return result;
    }

    public async Task<bool> UpdateStoreAsync(Store store)
    {
        var result = await dbConnection.UpdateAsync(store);

        return result;
    }
}
