using System.ComponentModel.DataAnnotations;

namespace Northwind.DataModels.Authentication
{
    public partial class UserDto
    {
        public string UserId { get; set; }

        [Required(ErrorMessage ="User Email cannot be empty.")]
        [Display(Name ="User Email.")]
        [EmailAddress(ErrorMessage ="Please enter an email address.")]
        public string UserEmail { get; set; }

        [Required]
        [MinLength(3, ErrorMessage ="First Name cannot be less than 3 characters.")]
        [MaxLength(50, ErrorMessage = "First Name cannot be more than 50 characters.")]
        [Display(Name ="First Name")]
        public string UserFirstName { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Last Name cannot be less than 3 characters.")]
        [MaxLength(50, ErrorMessage = "Last Name cannot be more than 50 characters.")]
        [Display(Name = "Last Name")]
        public string UserLastName { get; set; }
    }
}
