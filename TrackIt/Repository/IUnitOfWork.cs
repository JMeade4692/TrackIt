using BulkyBook.DataAccess.Repository.IRepository;
using System;
using TrackIt.Data;
using TrackIt.DataAccess.Repository;
using TrackIt.DataAccess.Repository.IRepository;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork1
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        ICategoryRepository IUnitOfWork1.Category => throw new NotImplementedException();

        ISP_Call IUnitOfWork1.SP_Call => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
