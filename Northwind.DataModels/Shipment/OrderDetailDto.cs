using Northwind.DataModels.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Shipment
{
    public class OrderDetailDto
    {
        [Display(Name = "Order Detail Id")]
        public short OrderDetailId { get; set; }

        [Display(Name = "Order*")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a an order.")]
        public short OrderId { get; set;}

        [Display(Name = "Product*")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a product.")]
        public short ProductId { get; set; }

        [Range(0.01, float.MaxValue, ErrorMessage = "Please enter number above 0.01.")]
        [Display(Name = "Unit Price*")]
        public float OrderUnitPrice { get; set; }

        [Range(1, short.MaxValue, ErrorMessage = "Please enter number above 0 and below 32768")]
        [Display(Name = "Quantity*")]
        public short OrderQuantity { get; set; }

        [Display(Name = "Discount*")]
        [Range(1, float.MaxValue, ErrorMessage = "Please enter number above 0 and below 32768")]
        public float OrderDiscount { get; set; }

        public virtual OrderDto Order { get; set; }
        public virtual ProductDto Product { get; set; }
    }
}
