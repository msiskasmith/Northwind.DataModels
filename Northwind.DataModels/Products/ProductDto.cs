using Northwind.DataModels.Shipment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Products
{
    public class ProductDto
    {
        [Display(Name = "Product Id")]
        public short ProductId { get; set; }

        [MaxLength(40, ErrorMessage ="Product Name cannot be more than 40 characters.")]
        [MinLength(3, ErrorMessage = "Product Name cannot be less than 3 characters.")]
        [Required(ErrorMessage = "Product Name cannot be empty")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Supplier")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a supplier.")]
        public short? SupplierId { get; set; }

        [Display(Name = "Product Category")]
        [Range(1, short.MaxValue, ErrorMessage = "Please select a product category.")]
        public short? ProductCategoryId { get; set; }

        [MaxLength(20, ErrorMessage ="Product Quantity Per Unit cannot be more than 20 characters.")]
        [MinLength(2, ErrorMessage = "Product Quantity Per Unit cannot be less than 2 characters.")]
        [Display(Name = "Product Quantity Per Unit")]
        public string ProductQuantityPerUnit { get; set; }

        [Display(Name = "Product Unit Price")]
        public float? ProductUnitPrice { get; set; }

        [Display(Name = "Product Units in Stock")]
        public short? ProductUnitsInStock { get; set; }

        [Display(Name = "Product Units On Order")]
        public short? ProductUnitsOnOrder { get; set; }

        [Display(Name = "Product Recorder Level")]
        public short? ProductReorderLevel { get; set; }

        [Range(0, 1, ErrorMessage = "Product discontinued field cannot be empty")]
        [Display(Name = "Product Discontinued?")]
        public int ProductDiscontinued { get; set; }

        public virtual ProductCategoryDto ProductCategory { get; set; }
        public virtual SupplierDto Supplier { get; set; }
    }
}
