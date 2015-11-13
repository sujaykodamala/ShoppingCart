using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKart.Models
{
  public  class Delivery
    {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int Delivery_ID { get; set; }

      [Required]
      [MaxLength(20)]
      public string Name { get; set; }

      [Required]
      public string Address1 { get; set; }

      public string Adddress2 { get; set; }

      [Required]
      public string City { get; set; }

      [Required]
      [MaxLength(20)]
      public string State {get;set;}

      [Required]
      [DataType(DataType.PostalCode)]
      public int Zip { get; set; }

      [Required]
      [DataType(DataType.PhoneNumber)]
      public string ContactNumber { get; set; }

     
      
    }
}
