﻿using LizBook.DataAccess.Repository.IRepository;
using LizBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LizBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CoverTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)      //action method for Upsert
        {
            CoverType covertype = new CoverType();   //using LizBook.Models
            if (id == null)
            {
                //this is for create
                return View(covertype);
            }
            //this for edit
            covertype = _unitOfWork.CoverType.Get(id.GetValueOrDefault());
            if (covertype == null)
            {
                return NotFound();
            }
            return View(covertype);

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        //[ValidateAntiforgeryToken]

        public IActionResult Upsert(CoverType covertype)
        {
            if (ModelState.IsValid)    //checks all validations in the modelo
            {
                if (covertype.Id == 0)
                {
                    _unitOfWork.CoverType.Add(covertype);
                    _unitOfWork.Save();
                }
                else
                {
                    _unitOfWork.CoverType.Update(covertype);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));  //to see all the categories
            }
            return View(covertype);
        }


        //API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            //return NotFound();
            var allObj = _unitOfWork.CoverType.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.CoverType.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.CoverType.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion

    }
}
