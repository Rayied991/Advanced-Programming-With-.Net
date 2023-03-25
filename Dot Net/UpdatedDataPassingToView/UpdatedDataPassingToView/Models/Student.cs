using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpdatedDataPassingToView.Models
{
    public class Student
    {
        //class=model
        //auto property
        public string Name { get; set; }//can restrict set and get 

        public string Id { get; set; }

        public string Dob { get; set; }

        //public string name;//field variable


        //Full Property
       /* private int myvar;

        public int myprop
        {

            get { return myvar; }
            set { myvar = value; }

        }*/
    }
}