using AndrewsBooks.DataAccess.Repository;
using LizBook.DataAccess.Repository.IRepository;
using LizBook.Models;
using LizBookStore.DataAccess.Data;
//using LizBook.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Text;
//using System.Linq;
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
            throw new NotImplementedException();
        }

    }
}
