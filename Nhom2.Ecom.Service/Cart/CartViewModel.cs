using System;
using System.Collections.Generic;
using System.Text;

namespace Nhom2.Ecom.Service.Cart
{
    public class CartViewModel
    {
        public List<CartItemViewModel> Items { get; set; }
        public decimal SubTotal
        {
            get
            {
                decimal sum = 0;
                foreach (var item in Items)
                {
                    sum += item.SubTotal;
                }
                return sum;
            }
        }
        public Decimal Shipping { get; set; }
        public Decimal Tax { get { return SubTotal / 10; } }
        public Decimal Total { get { return SubTotal + Shipping + Tax; } }
        public AddressViewModel Address { get; set; }
        public string GiftCode { get; set; }
        public string CouponCode { get; set; }
    }
}
