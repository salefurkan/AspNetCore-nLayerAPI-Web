using KatmanliMimariProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariProject.Core.Repositories
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int categoryId);
    }
}
