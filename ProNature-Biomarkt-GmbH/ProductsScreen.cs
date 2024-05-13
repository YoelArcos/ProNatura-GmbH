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
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Yoela\OneDrive\Documents\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");
        public ProductsScreen()
        {
            InitializeComponent();

            //Start database
        }

        private void btnProductSafe_Click(object sender, EventArgs e)
        {
            string prodcutName = textBoxProductName.Text;
            
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
