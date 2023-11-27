using LizBook.DataAccess.Repository;
using LizBook.DataAccess.Repository.IRepository;
using LizBook.Models;
using LizBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
//using System.Threading.Tasks;

namespace LizBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product product)
        {
            //use .NET LINQ to retrieve the first or default category object,
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.Products.FirstOrDefault(s => s.id == product.id);
            if (objFromDb != null) //save if not null
            {
                if (product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;

                }
                objFromDb.Title = product.Title;
                objFromDb.Description = product.Description;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Author = product.Author;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.CoverTypeId = product.CoverTypeId;
                //new
                objFromDb.Price = product.Price;
                //objFromDb.Price100 = product.Price100;
                //objFromDb.Price50 = product.Price50;
                //****

            }

        }
    }
}
