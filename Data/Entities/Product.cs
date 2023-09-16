using System.ComponentModel.DataAnnotations.Schema;
using WebApplication2.Data.Entities;
namespace WebApplication2.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        [ForeignKey("Vendor")]
        public int VendorId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        public Vendor Vendor { get; set; }
    }
}
