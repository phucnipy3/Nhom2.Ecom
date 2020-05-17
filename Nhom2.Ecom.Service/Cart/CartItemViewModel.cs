using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Service.Cart
{
    public class CartItemViewModel
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string AvatarUrl { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal SubTotal { get { return Price * Quantity; } }
        public int RatePersent { get; set; }
    }
}
