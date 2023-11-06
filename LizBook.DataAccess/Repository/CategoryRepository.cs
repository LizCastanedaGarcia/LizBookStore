using LizBook.DataAccess.Repository;
using LizBook.DataAccess.Repository.IRepository;
using LizBook.Models;
using LizBookStore.DataAccess.Data;
//using LizBook.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using System.Threading.Tasks;

namespace LizBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //use .NET LINQ to retrieve the first or default category object,
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //save if not null
            {
                objFromDb.Name = category.Name;
                //_db.SaveChanges();
            }
           
        }



    }
}
