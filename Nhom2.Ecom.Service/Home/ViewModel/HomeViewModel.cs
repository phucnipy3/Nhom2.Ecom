using Nhom2.Ecom.Service.Product.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Service.Home.ViewModel
{
    public class HomeViewModel
    {
        public string SeasonImage { get; set; }
        public int MyProperty { get; set; }
        public List<ProductCardViewModel> NewProducts { get; set; } = new List<ProductCardViewModel>();
        public List<ProductCardViewModel> HotProducts { get; set; } = new List<ProductCardViewModel>();

    }
}
