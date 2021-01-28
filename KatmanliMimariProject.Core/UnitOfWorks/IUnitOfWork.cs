using KatmanliMimariProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliMimariProject.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        ICategoryRepository categories { get; }
        Task CommitAsync();
        void Commit();
    }
}
