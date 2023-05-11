using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductCategoryManagement.Models
{
    public class UserAccount
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "FullName is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "EmailId is required")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Please enter a valid email address.")]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Choose Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Compare("Password",ErrorMessage = "Password is not matching")]
        public string ConfirmPassword { get; set; }
    }
}