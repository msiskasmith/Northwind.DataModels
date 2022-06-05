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

        [Display(Name = "Order")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select an order.")]
        public short OrderId { get; set;}

        [Display(Name = "Product")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a product.")]
        public short ProductId { get; set; }

        [Range(0.01, float.MaxValue, ErrorMessage = "Unit price must be more than 0.00")]
        [Display(Name = "Unit Price")]
        public float OrderUnitPrice { get; set; }

        [Range(1, short.MaxValue, ErrorMessage = "Quantity must be above 0.")]
        [Display(Name = "Quantity")]
        public short OrderQuantity { get; set; }

        [Display(Name = "Discount*")]
        [Range(1, float.MaxValue, ErrorMessage = "Discount must be above above 0.")]
        public float OrderDiscount { get; set; }

        public virtual OrderDto Order { get; set; }
        public virtual ProductDto Product { get; set; }
    }
}
