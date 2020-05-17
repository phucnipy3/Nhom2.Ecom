using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Service.Product.ViewModel
{
    public class ProductViewModel
    {
        public List<CategoryTagViewModel> MainTags { get; set; } = new List<CategoryTagViewModel>();
        public List<CategoryTagViewModel> RecommandTags { get; set; } = new List<CategoryTagViewModel>();
        public List<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
        public List<ProductCardViewModel> Products { get; set; } = new List<ProductCardViewModel>();
        public List<FilterWithPropertyViewModel> Materials { get; set; } = new List<FilterWithPropertyViewModel>();
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public List<FilterWithPropertyViewModel> Colors { get; set; } = new List<FilterWithPropertyViewModel>();
        public List<ProductCardViewModel> RecommandProducts { get; set; } = new List<ProductCardViewModel>();



    }
}
