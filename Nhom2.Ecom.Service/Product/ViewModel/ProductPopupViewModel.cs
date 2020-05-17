using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Service.Product.ViewModel
{
    public class ProductPopupViewModel
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string AvatarUrl { get; set; }
        public List<string> SubImageUrls { get; set; } = new List<string>();
        public string Name { get; set; }
        public int RatePersent { get; set; }
        public int CommentCount { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public Decimal PromotionPrice { get; set; } = 0;
        public List<CategoryTagViewModel> CategoryTags { get; set; } = new List<CategoryTagViewModel>();

    }
}
