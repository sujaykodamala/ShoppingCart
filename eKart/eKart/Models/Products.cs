using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace eKart.Models
{
    public class Products
    {
       

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Product_D { get; set; }

        [Required(ErrorMessage="Product is required")]
        [Display(Name="Product Name")]
        public string Product_Name { get; set; }

        [Required(ErrorMessage="Photo of the product is required")]
        [Display(Name="Product Photo")]
        public byte[] Product_Photo { get; set; }

        [NotMapped]
        public HttpPostedFileBase Image { get; set; }

        [Required(ErrorMessage="Enter the Quantity Available")]
        [Display(Name = "Product Quantity")]
        public int Product_Quantity { get; set; }

        [Required(ErrorMessage="Enter the price of the product")]
        [Display(Name = "Product Price")]
        public int Product_Price { get; set; }

        [Required(ErrorMessage = "Choose your category")]
        public string Category { get; set; }

        //[Required]
        //public int CategoryID { get; set; }

        //[ForeignKey("Category")]
        //[NotMapped]
        //public virtual Category Category_Name { get; set; }

        [NotMapped]
        public List<System.Web.Mvc.SelectListItem> CategoryList { get; set; }

        [Required(ErrorMessage = "Choose your category")]
        public string Gender { get; set; }

        //[ForeignKey("Gender")]
        //[NotMapped]
        //public virtual Gender Gender_Name { get; set; }

        [NotMapped]
        public List<System.Web.Mvc.SelectListItem> GenderList { get; set; }

    }
}
