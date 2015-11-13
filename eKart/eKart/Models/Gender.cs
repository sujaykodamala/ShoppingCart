using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKart.Models
{
    public class Gender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Gender_ID { get; set; }

        [Display(Name="Gender")]
        [Required(ErrorMessage="Gender is Required")]
        public string Gender_Name { get; set; }

        //public virtual ICollection<Products> Products { get; set; }
    }
}
