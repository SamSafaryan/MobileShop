using WebApplication2.Data.Entities;
using WebApplication2.Data.Repositories.Interfaces;
using WebApplication2.Services.Interfaces;
using WebApplication2.ViewModels.Categories;
using WebApplication2.ViewModels.Vendors;

namespace WebApplication2.Services
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        public VendorService(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }
        List<VendorDropdownViewModel> IVendorService.GetListForDropdown()
        {
            var data = _vendorRepository.GetAll();
            return data.Select(v => new VendorDropdownViewModel
            {
                Id = v.Id,
                Name = v.Name,
            }).ToList();
        }
    }
}
