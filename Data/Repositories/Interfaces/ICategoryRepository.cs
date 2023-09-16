using WebApplication2.Data.Entities;

namespace WebApplication2.Data.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
    }
}
