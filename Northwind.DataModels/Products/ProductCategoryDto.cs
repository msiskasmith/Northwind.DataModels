using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataModels.Products
{
    public class ProductCategoryDto
    {
        [Display(Name = "Product Category Id")]
        public short ProductCategoryId { get; set; }

        [Display(Name ="Name*")]
        [Required(ErrorMessage = "Product Category Name cannot be empty")]
        [MaxLength(15, ErrorMessage ="Product Category Name cannot be more than 15 characters")]
        [MinLength(4, ErrorMessage ="Product Category Name cannot be less than 4 characters")]       
        public string ProductCategoryName { get; set; }

        [Display(Name = "Description*")]
        [Required(ErrorMessage = "Product category description cannot be empty")]
        [MaxLength(500, ErrorMessage = "Product category description cannot be more than 500 characters")]
        [MinLength(10, ErrorMessage = "Product category description cannot be less than 10 characters")]
        public string ProductCategoryDescription { get; set; }

        [Display(Name ="Product Category Picture")]
        public byte[] ProductCategoryPicture { get; set; }
    }
}
