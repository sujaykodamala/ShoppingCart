﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKart.Models
{
  public   class Address
    {


        [Required(ErrorMessage = "The Name is required")]
        [MaxLength(20, ErrorMessage = "The Maximum length of the name allowed is 20 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Address  is required")]
        public string Address1 { get; set; }

        public string Adddress2 { get; set; }

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

        [Required]
        public int Customer_ID { get; set; }

        [Display(Name="Save address?")]
        public bool AddressInfo { get; set; }

    }
}
