using ProductService.API.Infrastructure.Data;
using ProductService.API.Models.Response;

namespace ProductService.API.Manager;

public class ProductManager : IProductManager
{
    public async Task<ProductResponse> GetProductByIdAsync(int id)
    {
        ProductTable productTable = new ProductTable();
        var data = await productTable.GetSampleProducts();
        return data.FirstOrDefault(x => x.Id == id) ?? default;
    }

    public async Task<List<ProductResponse>> GetProductsAsync()
    {
        ProductTable productTable = new ProductTable();
        return await productTable.GetSampleProducts();
    }
}
