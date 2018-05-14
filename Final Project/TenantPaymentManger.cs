using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Final_Project
{
    public partial class TenantPaymentManger : Form
    {
        private House tenantHouse;
        private TransactionManager Manager = new TransactionManager();
        private LeadTenant tenant;
        private List<TenantTransaction> transactions;
        private List<String> payment = new List<String>();
        private ManageComboxLists comboxLists = new ManageComboxLists();
        private ValidationType validation = new ValidationType();
        private Alert alert = new Alert();
        private bool filterEnabled = false;
        private DataFormat dataFormat = new DataFormat();
        public TenantPaymentManger(House house )
        {
            tenantHouse = house;
            tenant = tenantHouse.LeadTenant;
            transactions = tenant.Transactions;
            InitializeComponent();
          
        }
        public void FillComboBox()
        {
             List<String> types = comboxLists.GetPaymentTypes();
            AddListToBox(drpPaymentType, types);
        }
        private void AddListToBox(ComboBox combobox, List<String> items)
        {
            combobox.Items.Add("Add Item");
            foreach (String item in items)
            {
                payment.Add(item);
                combobox.Items.Add(item);
            }
        }
        private void PopulateDatabase(List<TenantTransaction> transactions)
        {
            
            foreach (TenantTransaction transaction  in transactions)
            {
                AddRequestsToTable(transaction);
            }
        }
        private void AddRequestsToTable(TenantTransaction transaction)
        {
            
            var debt = "";
            var credit = "";
            
          
            if (transaction.transactionAmount <= 0)
            {
                credit = dataFormat.formatCurrency(transaction.transactionAmount);

            }
            else
            {
               debt = dataFormat.formatCurrency(transaction.transactionAmount);
            }

            dataTransactions.Rows.Add(transaction.transactionDate.ToShortDateString(),
                payment[transaction.transactiontype-1], credit, debt, dataFormat.formatCurrency(transaction.currentBalance));
        }
    
            public void  populateFields()
        {
            var date = tenant.RentDate;
            var day = date.Day;
            var year = DateTime.Today.Year;
            var currentMonth = DateTime.Today.Month;
            var lastrentDate = new DateTime(year, currentMonth, day);
            var nextrentDate = new DateTime(year, currentMonth + 1, day);

            lblFirstName.Text = tenant.TenantFirst;
            lblLastName.Text = tenant.TenantLast;
            lblPhoneNumber.Text = tenant.TenantPhone;
            lblAddress.Text = tenantHouse.getAddress();
            lblPetCount.Text = tenant.getNumberOfPets().ToString();

            lblCurrentBalanceAmount.Text = dataFormat.formatCurrency(tenant.Balance.ToString());
            lblLastPaymentDate.Text = lastrentDate.ToShortDateString();
            lblNextPayment.Text = nextrentDate.ToShortDateString();
        }
        private void TenantPaymentManger_Load(object sender, EventArgs e)
        {
            FillComboBox();
            populateFields();
            PopulateDatabase(transactions);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            TenantSearchScreen searchScreen = new TenantSearchScreen();
            Hide();
            ShowDialog();

        }


        private void btnPaymentSubmit_Click(object sender, EventArgs e)
        {
            if (transactionValidation() == true){

                Console.WriteLine($"Payment Amount:{textPaymentAmount.Text}");
                AddRequestsToTable(Manager.CreateTenantTransaction(tenant.TenantId, dateTransactionDate.Value,
                     drpPaymentType.SelectedIndex, decimal.Parse(textPaymentAmount.Text), textDescription.Text).Last());
            }
       }
     private bool transactionValidation()
        {
            var intVal = validation.getValidationInt();
            var paymentAmount = textPaymentAmount.Text;
            var firstDigit = paymentAmount.ToCharArray()[0];
            if (dateTransactionDate.Checked == true)
            {
                Console.WriteLine($"SelectIndex {drpPaymentType.SelectedIndex}");
               if (drpPaymentType.SelectedIndex > 0)
                {
                    if (radioDebit.Checked == true) { } // If transaction is payment do nothing because it should equate to a postive balance
                    if (radioCredit.Checked == true)
                    {
                        if (firstDigit.ToString() == "-") { }

                        else
                        {
                            var payment = "-" + textPaymentAmount.Text;
                            textPaymentAmount.Text = payment;
                        }
                    }
                    return true;
                }
               else
                {
                    alert.CreateBasicAlert(4, "A Transaction Type is required", "Invalid Entry");
                    return false;
                }
            }
            else
            {
                alert.CreateBasicAlert(4, "A Date is required to complete the transaction ", "Invalid Entry");
                return false;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (filterEnabled == false)
            {
                if (dateRangeStart.Checked == true && dateRangeEnd.Checked == true)
                {
                    if (dateRangeStart.Value <= dateRangeEnd.Value)
                    {
                        ///  BindingSource bs = new BindingSource();
                        // bs.DataSource = dataTransactions.DataSource;
                        //bs. Filter = "PaymentDate <='" + dateRangeStart.Value + "'and PaymentDate >='" + dateRangeEnd.Value +"";
                        // (dataTransactions.DataSource as DataView).RowFilter = string.Format("dataPaymentDate >'{0}' AND dataPaymentDate > '{1}' ", dateRangeStart.Value.ToShortDateString()
                        //    ,dateRangeEnd.Value.ToShortDateString());
                        btnFilter.Text = "Clear";
                        dataTransactions.Rows.Clear();
                        PopulateDatabase(transactions.Where(transaction => (transaction.transactionDate >= dateRangeStart.Value && transaction.transactionDate <= dateRangeEnd.Value)).ToList());
                        filterEnabled = true;
                    }
                    else
                    {
                        alert.CreateBasicAlert(3, "Start Date must be sooner then End Date", "Invalid Date Selection");
                    }
                }
                else
                {
                    alert.CreateBasicAlert(3, "Both date must be active to use the filter", "Invalid Date Selection");
                }
            }
            else
            {
                btnFilter.Text = "Filter";
                dataTransactions.Rows.Clear();
                PopulateDatabase(transactions);
            }
        }
    }
}
