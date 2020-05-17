using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Service.Product.ViewModel
{
    public class ProductCardViewModel
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string AvatarUrl { get; set; }
        public CategoryTagViewModel Category { get; set; }
        public int RatePersent { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; } = 0;
        public bool IsNew { get; set; }
        public bool IsSale { get; set; }

    }
}
