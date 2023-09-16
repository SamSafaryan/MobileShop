using WebApplication2.ViewModels.Categories;

namespace WebApplication2.Services.Interfaces
{
    public interface ICategoryService
    {
        public List<CategoryDropdownViewModel> GetListForDropdown();
    }
}
