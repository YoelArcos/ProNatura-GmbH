using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNature_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {

        private int loadingBarValue;
        public LoadingScreen()
        {
            InitializeComponent();
        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingbarTimer.Start(); // Starts timer when Loadingscreen opens

        }
        private void LoadingbarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue+=2;

            //The digit after the label "Loading.."
            lblLoadingProgress.Text = loadingBarValue.ToString() + "%";

            //The Loadingbar gets the value from loadingBarValue
            LoadingProgressBar.Value = loadingBarValue;
            
            if ( loadingBarValue >= LoadingProgressBar.Maximum)
            {
                LoadingbarTimer.Stop();
                
                // Finish loading now show main menu screen
                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();

                // Hides LoadingScreen
                this.Hide();
            }
        }

       
    }
}
