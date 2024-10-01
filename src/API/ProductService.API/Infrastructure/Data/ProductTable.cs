using ProductService.API.Models.Response;

namespace ProductService.API.Infrastructure.Data;

public class ProductTable
{
    public async Task<List<ProductResponse>> GetSampleProducts()
    {
        return await Task.FromResult(new List<ProductResponse>
        {
            new ProductResponse { Id = 1, Name = "Product A", Description = "Description for Product A", Price = 10.99m, Stock = 100 },
            new ProductResponse { Id = 2, Name = "Product B", Description = "Description for Product B", Price = 20.99m, Stock = 150 },
            new ProductResponse { Id = 3, Name = "Product C", Description = "Description for Product C", Price = 30.50m, Stock = 200 },
            new ProductResponse { Id = 4, Name = "Product D", Description = "Description for Product D", Price = 40.00m, Stock = 50 },
            new ProductResponse { Id = 5, Name = "Product E", Description = "Description for Product E", Price = 15.75m, Stock = 75 },
            new ProductResponse { Id = 6, Name = "Product F", Description = "Description for Product F", Price = 25.25m, Stock = 60 },
            new ProductResponse { Id = 7, Name = "Product G", Description = "Description for Product G", Price = 55.99m, Stock = 30 },
            new ProductResponse { Id = 8, Name = "Product H", Description = "Description for Product H", Price = 35.80m, Stock = 40 },
            new ProductResponse { Id = 9, Name = "Product I", Description = "Description for Product I", Price = 45.10m, Stock = 20 },
            new ProductResponse { Id = 10, Name = "Product J", Description = "Description for Product J", Price = 60.00m, Stock = 10 },
            new ProductResponse { Id = 11, Name = "Product K", Description = "Description for Product K", Price = 12.99m, Stock = 110 },
            new ProductResponse { Id = 12, Name = "Product L", Description = "Description for Product L", Price = 22.99m, Stock = 90 },
            new ProductResponse { Id = 13, Name = "Product M", Description = "Description for Product M", Price = 32.50m, Stock = 80 },
            new ProductResponse { Id = 14, Name = "Product N", Description = "Description for Product N", Price = 42.00m, Stock = 55 },
            new ProductResponse { Id = 15, Name = "Product O", Description = "Description for Product O", Price = 18.75m, Stock = 65 },
            new ProductResponse { Id = 16, Name = "Product P", Description = "Description for Product P", Price = 28.25m, Stock = 45 },
            new ProductResponse { Id = 17, Name = "Product Q", Description = "Description for Product Q", Price = 58.99m, Stock = 35 },
            new ProductResponse { Id = 18, Name = "Product R", Description = "Description for Product R", Price = 38.80m, Stock = 25 },
            new ProductResponse { Id = 19, Name = "Product S", Description = "Description for Product S", Price = 48.10m, Stock = 15 },
            new ProductResponse { Id = 20, Name = "Product T", Description = "Description for Product T", Price = 70.00m, Stock = 5 },
            new ProductResponse { Id = 21, Name = "Product U", Description = "Description for Product U", Price = 14.99m, Stock = 120 },
            new ProductResponse { Id = 22, Name = "Product V", Description = "Description for Product V", Price = 24.99m, Stock = 95 },
            new ProductResponse { Id = 23, Name = "Product W", Description = "Description for Product W", Price = 34.50m, Stock = 85 },
            new ProductResponse { Id = 24, Name = "Product X", Description = "Description for Product X", Price = 44.00m, Stock = 65 },
            new ProductResponse { Id = 25, Name = "Product Y", Description = "Description for Product Y", Price = 19.75m, Stock = 75 },
            new ProductResponse { Id = 26, Name = "Product Z", Description = "Description for Product Z", Price = 29.25m, Stock = 55 },
            new ProductResponse { Id = 27, Name = "Product AA", Description = "Description for Product AA", Price = 59.99m, Stock = 45 },
            new ProductResponse { Id = 28, Name = "Product AB", Description = "Description for Product AB", Price = 39.80m, Stock = 30 },
            new ProductResponse { Id = 29, Name = "Product AC", Description = "Description for Product AC", Price = 49.10m, Stock = 20 },
            new ProductResponse { Id = 30, Name = "Product AD", Description = "Description for Product AD", Price = 80.00m, Stock = 10 }
        });
    }
}