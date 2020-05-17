using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Service.Product.ViewModel
{
    public class ProductDetailViewModel
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public List<CategoryTagViewModel> CategoryTags { get; set; } = new List<CategoryTagViewModel>();
        public string AvatarUrl { get; set; }
        public List<string> SubImageUrl { get; set; } = new List<string>();
        public string Name { get; set; }
        public int RatePersent { get; set; }
        public int CommentCount { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; } = 0;
        public string Availabitity { get; set; }
        public string Desciption { get; set; }
        public List<string> Colors { get; set; }
        public List<int> Sizes { get; set; }
        public string Detail { get; set; }
        public List<CommentViewModel> Comments { get; set; } = new List<CommentViewModel>();
        public List<ProductCardViewModel> RelatedProducts { get; set; } = new List<ProductCardViewModel>();
    }
}
