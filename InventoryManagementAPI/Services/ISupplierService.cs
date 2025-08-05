using InventoryManagementAPI.Models;

namespace InventoryManagementAPI.Services
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAll();
        Supplier? GetById(int id);
        void Create(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(int id);
    }
}
