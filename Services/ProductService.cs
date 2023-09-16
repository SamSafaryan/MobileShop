using WebApplication2.Data;
using WebApplication2.Data.Entities;
using WebApplication2.Data.Repositories.Interfaces;
using WebApplication2.Services.Interfaces;
using WebApplication2.ViewModels.Products;

namespace WebApplication2.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public int Add(ProductAddEditViewModel model)
        {
            Product product = new Product()
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
                VendorId = model.VendorId,
                Color = model.Color
            };
            _productRepository.Add(product);
            return product.Id;
        }

        public void Delete(int Id)
        {
            var entity = _productRepository.GetById(Id);
            _productRepository.Delete(entity);
        }

        public ProductAddEditViewModel GetById(int Id)
        {
            var entity = _productRepository.GetById(Id);
            return new ProductAddEditViewModel
            {
                Name = entity.Name,
                Color = entity.Color,
                CategoryId = entity.CategoryId,
                VendorId = entity.VendorId
            };
        }

        public int Update(ProductAddEditViewModel model)
        {
            var entity = _productRepository.GetById(model.Id);
            entity.Name = model.Name;
            entity.Color = model.Color;
            entity.CategoryId = model.CategoryId;
            entity.VendorId = model.VendorId;
            return entity.Id;
        }
    }
}
