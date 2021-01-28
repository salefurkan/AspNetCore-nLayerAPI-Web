using KatmanliMimariProject.Core.Repositories;
using KatmanliMimariProject.Core.UnitOfWorks;
using KatmanliMimariProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariProject.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IProductRepository Product => _productRepository = _productRepository ?? new ProductRepository(_appDbContext);

        public ICategoryRepository categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_appDbContext);

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
