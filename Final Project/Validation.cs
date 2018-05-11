using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Final_Project
{
   public class Validation<T> where T : IComparable
    {
        private Alert alert = new Alert();
        public DateTime ConvertDatePickerDefault(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Checked == false)
            {
                return new DateTime();
            }
            else
            {
                return dateTimePicker.Value;
            }
        }
        public bool CheckComboBox(ComboBox comboBox, String Field) // Checks is no data is avaliable for combox
        {
            if (comboBox.SelectedIndex == 0)
            {
                alert.CreateBasicAlert(3, $"{Field} field is required", "Invalid Entry");
                return false;
            }
            else if (comboBox.SelectedItem == null)
            {
                alert.CreateBasicAlert(1, $"A selection is required fo field {Field}", "Selection Required");
                return false;
            }
            else
            {
                return true;
            }
        }
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
