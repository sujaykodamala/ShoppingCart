using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eKart.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Category_ID { get; set; }

        [Display(Name="Category Name ")]
        [Required(ErrorMessage="Category Name is required")]
        public string Category_Name { get; set; }

        //public virtual ICollection<Products> Products { get; set; }

    }
}
