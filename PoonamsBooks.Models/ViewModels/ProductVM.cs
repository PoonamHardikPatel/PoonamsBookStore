using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PoonamsBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }    // Display all the product details

        public IEnumerable<SelectListItem> CategoryList { get; set; }   // install package "Microsoft.AspNetCore.Mvc.Rendering"

        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
