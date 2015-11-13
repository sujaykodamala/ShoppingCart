using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKart.Models
{
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int Customer_ID { get; set; }

        [Required(ErrorMessage = "Please enter the name on the credit card")]
        public string Name { get; set; } 

        [Required(ErrorMessage = "The Card Number is required")]
        [DataType(DataType.CreditCard)]
        public int CardNumber { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        [MaxLength(3, ErrorMessage = "The Maximum length of the name allowed is 3 characters")]
        public string CVV { get; set; }

        [Required(ErrorMessage = "The billing Address is required")]
        public string Billing_Address1 { get; set; }

        public string Billing_Address2 { get; set; }

        [Required(ErrorMessage = "The City is required")]
        public string City { get; set; }

        [Required(ErrorMessage = "The State  is required")]
        [MaxLength(20, ErrorMessage = "The Maximum length of the name allowed is 20 characters")]
        public string State { get; set; }

        [Required(ErrorMessage = "The Zip is required")]
        [DataType(DataType.PostalCode)]
        public int Zip { get; set; }

        [Required(ErrorMessage = "Please Enter the Contact Number")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }

                

    }
}
