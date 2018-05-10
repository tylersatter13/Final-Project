using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
namespace Final_Project
{
    class Alert
    {
        //Provides a  Yes or No question to the user an then returns a response to the calling method
        public bool CreateChoiceAlert(int AlertType, string title, string description)
        {
            DialogResult result = MessageBox.Show(title,description, MessageBoxButtons.YesNo, DetermineMessageType(AlertType));

             
            if (result == DialogResult.Yes) //Determine if the user selected The postive or negative button
            {
                return true;
            }
            else
            {
                return false; // Represents no
            }

        }
        //Provides and alert message of a selected type but 
        public void CreateBasicAlert(int AlertType, string description, string title)
        {
            MessageBox.Show( description, title, MessageBoxButtons.OK, DetermineMessageType(AlertType) );
        }
        //Makes it easier to set Message Type and collect error by assigning them an a number based on their severity.
        public MessageBoxIcon DetermineMessageType( int  alertType)
        {
            switch (alertType)
            {
                case 1:
                    return MessageBoxIcon.Information; // will make the message box in to an information message box
                case 2:
                    return MessageBoxIcon.Question; // will make the message box in to an Question message box
                case 3:
                    return MessageBoxIcon.Error;  // will make the message box in to an Error message box 
                case 4:
                     return MessageBoxIcon.Warning; // will make the message box in to an Warnign message box
                default:
                    return MessageBoxIcon.None; // will make the message box in to a standard message box
            }
        }
    }
}
