using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKart.Models
{
    public class Customers
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name="Customer ID")]
        public int Customer_ID { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "The Name is required")]
        [MaxLength(20, ErrorMessage = "Maximum length of characters is 20")]
        [MinLength(6, ErrorMessage = "The minimum length of characters is 6")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Enter a proper email address")]
        [Required(ErrorMessage = "The email address is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Password is required")]
        [DataType(DataType.Password)]
        public string Pass { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "The email address is required")]
        [DataType(DataType.Password)]
        [Compare("Pass", ErrorMessage = "Passwords doesn't match")]
        public string ConfirmPassword { get; set; }
    }
}
