using LizBook.DataAccess.Repository;
using LizBook.DataAccess.Repository.IRepository;
using LizBook.Models;
using LizBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace LizBook.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CoverType covertype)
        {
            //use .NET LINQ to retrieve the first or default category object,
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == covertype.Id);
            if (objFromDb != null) //save if not null
            {
                objFromDb.Name = covertype.Name;
                //_db.SaveChanges();
            }

        }
    }
}
