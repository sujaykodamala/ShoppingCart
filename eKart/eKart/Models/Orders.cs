using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKart.Models
{
 public  class Orders
    {
     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int ID { get; set; }
     [Required]
     public int Customer_ID { get; set; }

     public int ProductID{get;set;}

     public string ProductName { get; set; }

     public int ProductQunantity { get; set; }

     public int ProductPrice { get; set; }

     public byte[] ProductPicture { get; set; }

     public DateTime DateTime { get; set; }
    }
}
