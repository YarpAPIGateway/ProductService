using ProductService.API.Models.Response;

namespace ProductService.API.Manager;

public interface IProductManager
{
    Task<List<ProductResponse>> GetProductsAsync();

    Task<ProductResponse> GetProductByIdAsync(int id);
}
