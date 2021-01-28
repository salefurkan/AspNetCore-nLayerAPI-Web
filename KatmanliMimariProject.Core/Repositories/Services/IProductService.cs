using KatmanliMimariProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariProject.Core.Repositories.Services
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int productId);
        //bool ControlInnerBarcode(Product product);
    }
}
