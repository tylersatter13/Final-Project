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

        //if string is valid the convert the decimal else return 0
        public bool validateHouseNumber(TextBox textbox)
        {
            int houseNumber;
            var isNumeric = int.TryParse(textbox.Text, out houseNumber);
            if (isNumeric == false)
            {
                alert.CreateBasicAlert(3, "House number may only contain numerical values", "Invalid House Number");
                return false;
            }
            else if (textbox.Text.Length != 4)
            {
                alert.CreateBasicAlert(3, "House number must be 4 Digits", "Invalid House Number");
                return false;
            }
            else if (houseNumber < 1000)
            {
                alert.CreateBasicAlert(3, "House number must be Greater then 1000", "Invalid House Number");
                return false;
            }
            else
            {
                return true;
            }
        }
        public decimal convertStringToDecimal(String testvalue)
        {
            decimal decimalResult;
            if (fieldHasValue(testvalue)==false)
            {
              var result = decimal.TryParse(testvalue, out decimalResult);
                if (result == true)
                {
                    return decimalResult;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
    
        public bool checkInt(String testvalue,String FieldName)
        {
            if (fieldHasValue(testvalue))
            {
                return testIntConversion(testvalue, FieldName);
            }
            else
            {
                return false;
            }
        }
        public bool testIntConversion(String test, String FieldName)
        {
            int newInt;

            var isNumeric = int.TryParse(test, out newInt);
            if (isNumeric == false)
            {
                alert.CreateBasicAlert(4,$"{FieldName} must be a numerical value","Invalid Entry");
                return false;
            }
            else
            {
                return true;
            }

        }
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
            if (fieldHasValue(t) == true || t == -1)
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

