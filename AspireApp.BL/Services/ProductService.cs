using AspireApp.BL.Repositories;
using AspireApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspireApp.BL.Services
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProducts();
        Task<ProductModel> CreateProduct(ProductModel productModel);
    }
    public class ProductService (IProductRepository productRepository) : IProductService
    {

        public Task<List<ProductModel>> GetProducts()
        {
            return productRepository.GetProducts();
        }

        Task<ProductModel> IProductService.CreateProduct(ProductModel productModel)
        {
            return productRepository.CreateProduct(productModel);
        }
    }
}
