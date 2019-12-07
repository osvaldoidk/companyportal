using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompanyPortal.Models
{
    public class SalesAdmin
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Link Function")]
        public string LinkFunction { get; set; }

        [Required(ErrorMessage = "Valid Url Example: https://www.amazon.com/")]
        [Url(ErrorMessage = "Valid Url Example: https://www.amazon.com/")]
        [Display(Name = "HyperLink")]
        public string LinkAddress { get; set; }
    }
}