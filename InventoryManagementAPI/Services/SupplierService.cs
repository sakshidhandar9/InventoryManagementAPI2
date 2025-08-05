using InventoryManagementAPI.Infrastructure.Data;
using InventoryManagementAPI.Models;
using System;

namespace InventoryManagementAPI.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ApplicationDbContext _context;

        public SupplierService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Supplier> GetAll() => _context.Suppliers.ToList();

        public Supplier? GetById(int id) => _context.Suppliers.Find(id);

        public void Create(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void Update(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}
