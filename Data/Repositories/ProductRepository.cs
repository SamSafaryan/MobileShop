using WebApplication2.Data.Entities;
using WebApplication2.Data.Repositories.Interfaces;

namespace WebApplication2.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MobileShopDataContext _context;
        public ProductRepository(MobileShopDataContext context)
        {
            _context = context;
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
