using WebApplication2.ViewModels.Products;

namespace WebApplication2.Services.Interfaces
{
    public interface IProductService
    {
        public int Add(ProductAddEditViewModel model);
        public void Delete(int Id);
        public int Update(ProductAddEditViewModel model);
        public ProductAddEditViewModel GetById(int Id);
    }
}
