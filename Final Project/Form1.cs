using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            // databaseConnection.insert("INSERT Users VALUES ('Rick','paper0',4);");
            // databaseConnection.select("SELECT * FROM Users");
            String[] values = { "Kimmie", "popcorn13", "3" };
           //  databaseConnection.formatInsert("Users",values );
            databaseConnection.formatDelete("Users", "UserID", "3");
            databaseConnection.selectFormat(values, values, "Users");
        }
    }
}
