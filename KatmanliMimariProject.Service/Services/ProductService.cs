using KatmanliMimariProject.Core.Entity;
using KatmanliMimariProject.Core.Repositories;
using KatmanliMimariProject.Core.Repositories.Services;
using KatmanliMimariProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariProject.Service.Services
{
    public class ProductService : Service<Product>, Core.Repositories.Services.IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await _unitOfWork.Product.GetWithCategoryByIdAsync(productId);
        }
    }
}
