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
    public partial class ProductsScreen : Form
    {

        // Connection to the Database
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Yoela\OneDrive\Documents\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        public ProductsScreen()
        {
            InitializeComponent();

            //Start database
            databaseConnection.Open();

            //Command from SQL that shows all items from table "Products"
            string query = "select * from Products";

            //Only configuration (on hold) nothing happens yet
            //Creates new SQLAdapter with the command and the connection to the Database
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);
            
            // DataSet is the "item storage" right now it is empty
            var dataSet = new DataSet();

            //form the sqlDataAdapter(query, dataBaseConnection) fill to DataSet
            sqlDataAdapter.Fill(dataSet);

            //dataSet infos will be transfered to the GridView of the Products
            productsDGV.DataSource = dataSet.Tables[0];
            productsDGV.Columns[0].Visible = false;

            

            databaseConnection.Close();
        }

        private void btnProductSafe_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            
            //save product name in Database (SQL).
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
