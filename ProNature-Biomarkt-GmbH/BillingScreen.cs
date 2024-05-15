﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNature_Biomarkt_GmbH
{
    public partial class BillingScreen : Form
    {

        private SqlConnection dataConnection = new SqlConnection( @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\C:\\Users\\Yoela\\OneDrive\\Documents\\Pro-Natur Rechnungs Datenbank.mdf\;Integrated Security=True;Connect Timeout=30");

        private int lastSelectedField;
        public BillingScreen()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClearField_Click(object sender, EventArgs e)
        {
            textBoxCustomerName.Text = "";
            textBoxCustomerAdress.Text = "";
            textBoxCustomerBillingPrice.Text = "";
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

            string query = "select * from Table";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, dataConnection);

            var dataSet = new DataSet();

            //to fill the DataSet with sqlAdapter(query/command, databaseconnection)
            sqlDataAdapter.Fill(dataSet);

            dataGridViewBilling.DataSource = dataSet;

        }
        private void ExecuteQuery(string query)
        {
            //Database function
            dataConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, dataConnection);
            sqlCommand.ExecuteNonQuery();

            dataConnection.Close();
        }

        private void dataGridViewBilling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}