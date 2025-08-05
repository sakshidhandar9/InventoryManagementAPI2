using InventoryManagementAPI.Infrastructure.Data;
using InventoryManagementAPI.Models;
using System;

namespace InventoryManagementAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll() => _context.Products.ToList();
        public Product? GetById(int id) => _context.Products.Find(id);
        public void Create(Product product) { _context.Products.Add(product); _context.SaveChanges(); }
        public void Update(Product product) { _context.Products.Update(product); _context.SaveChanges(); }
        public void Delete(int id)
        {
            var p = _context.Products.Find(id);
            if (p != null) { _context.Products.Remove(p); _context.SaveChanges(); }
        }
    }
}

