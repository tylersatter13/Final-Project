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
   public partial class PaintSearch:Form
    {
        private ManageComboxLists comboxLists = new ManageComboxLists();
        private List<House> Houses = new List<House>();
        private HouseSearch search = new HouseSearch();
        private Alert alert = new Alert();
        public PaintSearch()
        {
            InitializeComponent();
            Console.WriteLine(this.Size);
            //onsole.WriteLine(this.
            //
            //Console.Write(ActiveMdiChild.w);  
          //  this.WindowState = FormWindowState.Maximized;
         //   this.WindowState = FormWindowState.Maximized;
          //  this.WindowState = FormWindowState.Maximized;
        }
        private void print()
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printHouses;
            printDialog.UseEXDialog = true;

            printHouses.DocumentName = "Test";
            printHouses.Print();
            
        }

        private void PaintSearch_Load(object sender, EventArgs e)
        {
            FillCombobox();
           List<House> houses = search.findHouses();
           PopulateDatabase(houses);
        }
        private void FillCombobox()
        {
            List<String> exteriorColors = comboxLists.GetExteriorColor();
            AddListToBox(drpExteriorColor, exteriorColors);
            List<String> interriorColor = comboxLists.GetInterriorColors();
            AddListToBox(drpInterriorColor, interriorColor);
        }
        private void AddListToBox(ComboBox combobox, List<String> items)
        {
            
            combobox.Items.Add("None");
            foreach (String item in items)
            {
                combobox.Items.Add(item);
               
            }
        }
        private void PopulateDatabase(List<House> houses)
        {
            
            foreach (House house in houses)
           {
                AddHouseToTable(house);
                Houses.Add(house);
            }
        }
        private void AddHouseToTable(House house)
        { 
            dataHouse.Rows.Add(false, house.Owner.OwnerInitals1,
            house.HouseNumber1+ " " + house.Streetname1,
            house.FloorPlan1,
            house.HouseInterrior.PrimaryPaintColor1,
            ConvertDateFormat(house.HouseInterrior.LastPaintDate1),
            house.HouseInterrior.CarpetColorName1 ,
            ConvertDateFormat(house.HouseInterrior.CarpetInstallDate1),
            house.HouseExterior.ExteriorColor1,
            house.HouseExterior.Trim1,
            house.HouseExterior.SidingName1,
            ConvertDateFormat(house.HouseExterior.ExteriorPaintDate1),
            ConvertDateFormat( house.HouseInterrior.Blindreplacement1)
            );
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            Houses.Clear();
            dataHouse.Rows.Clear();
            dataHouse.Refresh();
            // Console.WriteLine(drpExteriorColor.SelectedItem.ToString());
            if (textHouseNumber.Text != "")
            {
                if(radioExterrior.Checked == true)
                {
                   List<House> houses = search.findExteriorColorByHouse(textHouseNumber.Text);
                   PopulateDatabase(houses);
                } else if (radioInterrior.Checked == true)
                {
                    List<House> houses = search.findInterriorColorByHouse(textHouseNumber.Text);
                    PopulateDatabase(houses);
                }
            }
            else if (/*drpExteriorColor.SelectedIndex != 0 || */drpExteriorColor.SelectedIndex !=-1) 
            {
                Console.WriteLine("B");
                List<House> houses =  search.findHouseByExteriorColor(drpExteriorColor.SelectedIndex);
                PopulateDatabase(houses);
            }else if(drpInterriorColor.SelectedIndex != 0 || drpInterriorColor.SelectedIndex != -1)
            {
                Console.WriteLine("C");
                List<House> houses = search.findHouseByInterriorColor(drpInterriorColor.SelectedIndex);
                PopulateDatabase(houses);
            }
            
            ClearInputs();
          
        }
        private void ClearInputs()
        {
            drpInterriorColor.SelectedIndex = -1;
            drpExteriorColor.SelectedIndex = -1;
            textHouseNumber.Text = "";
        }
        private String ConvertDateFormat(DateTime date)
        {
           return date.ToString("MM/dd/yyyy");
        }


        private void radioInterrior_CheckedChanged(object sender, EventArgs e)
        {
            if (radioExterrior.Checked == true)
            {
                drpInterriorColor.SelectedIndex = -1;
                drpInterriorColor.Enabled = false;
                
            }else if (radioInterrior.Checked == true)
            {
                drpExteriorColor.SelectedIndex = -1;
                drpExteriorColor.Enabled = false;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           // PrintDialog printDialog = new PrintDialog();
          //printDialog.Document.DocumentName = 
        }

        private void dataHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            CreateBasicHouseInformation createBasic = new CreateBasicHouseInformation(Houses[row]);
            Close();
            createBasic.Show();
            
        }

        private void textHouseNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "  ^ [0-9]"))
            {
                textHouseNumber.Text = "";
            }
        }

        private void textHouseNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            CreateBasicHouseInformation createhouse = new CreateBasicHouseInformation();
            Close();
            createhouse.Show();
           
            
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            print();
        }

        private void printHouses_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
               /* strFormat = new StringFormat();
                strFormat.Alignment = StringAlignment.Near;
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Trimming = StringTrimming.EllipsisCharacter;

                arrColumnLefts.Clear();
                arrColumnWidths.Clear();
                iCellHeight = 0;
                iCount = 0;
                bFirstPage = true;
                bNewPage = true;

                // Calculating Total Widths
                iTotalWidth = 0;
                foreach (DataGridViewColumn dgvGridCol in dataGridView1.Columns)
                {
                    iTotalWidth += dgvGridCol.Width;
                }*/
            }
            catch (Exception ex)
            {
                alert.CreateBasicAlert(3, ex.ToString(), "Printing Error");
            }
        }
    }
}
