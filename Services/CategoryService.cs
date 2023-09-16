using WebApplication2.Services.Interfaces;
using WebApplication2.ViewModels.Categories;
using WebApplication2.Data.Repositories.Interfaces;

namespace WebApplication2.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<CategoryDropdownViewModel> GetListForDropdown()
        {
            var data = _categoryRepository.GetAll();
            return data.Select(c => new CategoryDropdownViewModel
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
        }
    }
}
