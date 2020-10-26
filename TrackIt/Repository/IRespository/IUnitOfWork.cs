using System;
using System.Collections.Generic;
using System.Text;
using TrackIt.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
