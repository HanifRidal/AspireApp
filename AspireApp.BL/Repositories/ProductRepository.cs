using AspireApp.Database.Data;
using AspireApp.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireApp.BL.Repositories
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> GetProducts();
        Task<ProductModel> CreateProduct(ProductModel productModel);
    }
    public class ProductRepository(AppDbContext dbContext) : IProductRepository
    {
        public async Task<ProductModel> CreateProduct(ProductModel productModel)
        {
            dbContext.Products.Add(productModel);
            await dbContext.SaveChangesAsync();
            return productModel;
        }

        public Task<List<ProductModel>> GetProducts()
        {
            return dbContext.Products.ToListAsync();
        }
    }
}
