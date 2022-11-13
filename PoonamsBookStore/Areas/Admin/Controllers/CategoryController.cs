﻿using PoonamsBooks.DataAccess.Repository.IRepository;
using PoonamsBooks.DataAccess.Repository;
using PoonamsBookStore.DataAccess;
using PoonamsBookStore.Areas;
using PoonamsBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoonamsBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        // API calls here
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            // return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }
        #endregion
    }
}