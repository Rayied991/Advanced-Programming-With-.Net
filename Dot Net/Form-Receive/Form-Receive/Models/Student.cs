using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Form_Receive.Models
{
    public class Student
    {
        public string Name { get; set; }//can restrict set and get 

        public string Id { get; set; }

        public string Dob { get; set; }

        //public float Cgpa { get; set; }//initialized with zero; because initially constructor is called

        public float? Cgpa { get; set; }//nullable
    }
}