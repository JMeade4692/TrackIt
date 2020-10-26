using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrackIt.Models;
using TrackIt.Repository.IRespository;

namespace TrackIt.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
