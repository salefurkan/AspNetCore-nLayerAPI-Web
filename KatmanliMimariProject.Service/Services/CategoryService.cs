using KatmanliMimariProject.Core.Entity;
using KatmanliMimariProject.Core.Repositories;
using KatmanliMimariProject.Core.Repositories.Services;
using KatmanliMimariProject.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariProject.Service.Services
{
    public class CategoryService : Service<Category>, Core.Repositories.Services.ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await _unitOfWork.categories.GetWithProductsByIdAsync(categoryId);
        }
    }
}
