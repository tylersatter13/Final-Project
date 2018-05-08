using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Validation<T> where T : IComparable
    {
        public Nullable<int> CheckNullForeignKey(int t)
        {
            if (fieldHasValue(t) == true)
            {
                return null;
            }
            else
            {
                return t;
            }
        }
        public Nullable<DateTime> checkNullDate(DateTime t)
        {
            if (fieldHasValue(t) == true)
            {
                Console.WriteLine("A");
                Console.WriteLine(default(DateTime));
                return null;
            }
            else
            {
                DateTime? date = t;
                Console.WriteLine("B");
                Console.WriteLine(date);
                return date;
            }
        }
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
