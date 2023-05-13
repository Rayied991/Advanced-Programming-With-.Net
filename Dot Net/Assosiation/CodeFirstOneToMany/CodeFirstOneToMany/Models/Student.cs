using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstOneToMany.Models
{
    public class Student
    {
        [Key]
         public int Student_Id { get; set; }
        [Required(ErrorMessage ="Name is Required")]
         public string Student_Name { get; set; }
        [Required]
         public string Student_Address { get; set; }
        [Required]
         public string Student_Email { get; set; }  
        
        public DateTime Date { get; set; }

        [Required]
        public string Password { get; set; }
       [Compare("Password",ErrorMessage ="Password does not Match")]

        public string Cpassword { get; set; }
        [Required]
        public int Age { get; set; }
    }
}