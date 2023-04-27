using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormValidation.Models
{
    public class Registration
    {
        [Required(ErrorMessage ="Please Provide Your Name")]//change default message field
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string Id{ get; set; }
        [Required]
        public string Gender{ get; set; }
        [Required]
        public string Profession{ get; set; }
        [Required]
        public string [] Hobbies{ get; set; }
        [Required]
        public DateTime Dob { get; set; }
    }
}