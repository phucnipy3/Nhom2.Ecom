using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Service.Product.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public List<CategoryViewModel> Children { get; set; } = new List<CategoryViewModel>();
    }
}
