using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Validation<T> where T: IComparable
    {
        public bool fieldHasValue<T>(T t)
        {
            if (EqualityComparer<T>.Default.Equals(t, default(T)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
      
    }
}
