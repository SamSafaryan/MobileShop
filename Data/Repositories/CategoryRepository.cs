using WebApplication2.Data.Entities;
using WebApplication2.Data.Repositories.Interfaces;

namespace WebApplication2.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MobileShopDataContext _context;
        public CategoryRepository(MobileShopDataContext context)
        {
            _context = context;
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
