using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
   public class ValidationType
    {
       public Validation<String> getValidationString()
        {
           Validation<String> validate = new Validation<String>();
            return validate;
        }
       public Validation<int> getValidationInt()
        {
            Validation<int> validate = new Validation<int>();
            return validate;
        }
        public Validation<DateTime> getValidationDateTime()
        {
            Validation<DateTime> validation = new Validation<DateTime>();
            return validation;
        }
    }
}
