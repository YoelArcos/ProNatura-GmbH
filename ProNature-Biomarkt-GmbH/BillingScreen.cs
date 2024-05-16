using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNature_Biomarkt_GmbH
{
    public partial class BillingScreen : Form
    {

        private SqlConnection dataConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Yoela\OneDrive\Documents\Pro-Natur-Rechnung.mdf;Integrated Security = True; Connect Timeout = 30");

        private int lastSelectedField;
        public BillingScreen()
        {
            
            InitializeComponent();
            
            ShowProducts();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(textBoxCustomerName.Text == "" 
                || textBoxCustomerAdress.Text == ""
                || textBoxCustomerBillingPrice.Text == "")
            {
                MessageBox.Show("Bitte alle Felder ausfüllen");
                return;
            }
            string costumerName = textBoxCustomerName.Text;
            string costumerAdress = textBoxCustomerAdress.Text;
            string customerBillingPrice = textBoxCustomerBillingPrice.Text;


            string query = string.Format(@"Insert into Billing values('{0}','{1}','{2}')", costumerName , costumerAdress, customerBillingPrice ); 
            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if( lastSelectedField == 0)
            {
                MessageBox.Show("Bitte wählen Sie zuerst eine Zeile");
                return;
            }
            
            

            string query = string.Format(@"Delete from Billing where Id= {0}", lastSelectedField);

            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts(); 

        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
           ClearAllFields();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenuScreen mainMenuScreen = new MainMenuScreen();
            mainMenuScreen.Show();
            this.Hide();
        }

        private void ShowProducts()
        {
           
            dataConnection.Open();

            string query = "select * from Billing";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, dataConnection);

            var dataSet = new DataSet();

            //to fill the DataSet with sqlAdapter(query/command, databaseconnection)
            sqlDataAdapter.Fill(dataSet);

            dataGridViewBilling.DataSource = dataSet.Tables[0];

            dataGridViewBilling.Columns[0].Visible = false;

            dataConnection.Close();
            

        }
        private void ExecuteQuery(string query)
        {
            //Database function
            dataConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, dataConnection);
            sqlCommand.ExecuteNonQuery();

            dataConnection.Close();
        }

        private void ClearAllFields()
        {
            textBoxCustomerName.Text = "";
            textBoxCustomerAdress.Text = "";
            textBoxCustomerBillingPrice.Text = "";
        }
        private void dataGridViewBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBoxCustomerName.Text= dataGridViewBilling.CurrentRow.Cells[1].Value.ToString();
            textBoxCustomerAdress.Text = dataGridViewBilling.CurrentRow.Cells[2].Value.ToString();
            textBoxCustomerBillingPrice.Text = dataGridViewBilling.CurrentRow.Cells[3].Value.ToString();

            lastSelectedField = (int)dataGridViewBilling.CurrentRow.Cells[0].Value;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            /*
            textBoxCustomerName.Text = dataGridViewBilling.CurrentRow.Cells[1].Value.ToString();
            textBoxCustomerAdress.Text = dataGridViewBilling.CurrentRow.Cells[2].Value.ToString();
            textBoxCustomerBillingPrice.Text = dataGridViewBilling.CurrentRow.Cells[3].Value.ToString();
            */


            string customerName = textBoxCustomerName.Text;
            string customerAdress = textBoxCustomerAdress.Text;
            string customerBillingPrice = textBoxCustomerBillingPrice.Text;


            string printCustomerBill = string.Format(@"Recipe: '{0}', '{1}', '{2}'", customerName, customerAdress, customerBillingPrice);
            MessageBox.Show(printCustomerBill);
        }
    }
}
