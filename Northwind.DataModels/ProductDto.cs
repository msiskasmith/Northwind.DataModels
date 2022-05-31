using Northwind.DataModels.Products;
using Northwind.DataModels.Shipment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels
{
    public class ProductDto
    {
        [Display(Name = "Product Id")]
        public short ProductId { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Product Name cannot be empty")]
        [Display(Name = "Product Name*")]
        public string ProductName { get; set; }

        [Display(Name ="Supplier*")]
        [Required(ErrorMessage ="Supplier cannot be empty.")]
        public short? SupplierId { get; set; }

        [Display(Name ="Product Category*")]
        [Required(ErrorMessage ="Product Category cannot be empty")]
        public short? ProductCategoryId { get; set; }

        [MaxLength(20)]
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

        [Range(0, 1, ErrorMessage ="Product discontinued field cannot be empty")]
        [Display(Name ="Product Discontinued?*")]
        public int ProductDiscontinued { get; set; }

        public virtual ProductCategoryDto ProductCategory { get; set; }
        public virtual SupplierDto Supplier { get; set; }
    }
}
