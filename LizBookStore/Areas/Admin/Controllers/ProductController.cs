﻿using LizBook.DataAccess.Repository.IRepository;
using LizBook.DataAccess.Repository;
using LizBook.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LizBook.Models.ViewModels;

namespace LizBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;


        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)      //action method for Upsert
        {
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),

                CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };

           if (id == null)
           {
               //this is for create
               return View(productVM);
    }

    //this for edit
    productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
            if (productVM.Product == null)
            {
                return NotFound();
            }
        return View(productVM);
}

[HttpPost]
        [AutoValidateAntiforgeryToken]
        //[ValidateAntiforgeryToken]

        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)    //checks all validations in the modelo
            {
                if(category.Id == 0)
                { 
                _unitOfWork.Category.Add(category);
                _unitOfWork.Save();
            }
            else
            {
                    _unitOfWork.Category.Update(category);
            }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));  //to see all the categories
        }
        return View(category);
    }


        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Category.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
