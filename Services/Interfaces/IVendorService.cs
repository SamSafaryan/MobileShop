using WebApplication2.ViewModels.Vendors;

namespace WebApplication2.Services.Interfaces
{
    public interface IVendorService
    {
        public List<VendorDropdownViewModel> GetListForDropdown();
    }
}
