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
            LoadingbarTimer.Start(); // Startet den Timer wenn LoadingScreen geöffnet wird.

        }
        private void LoadingbarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue+=2;

            //Die Zahl neben Loading...
            lblLoadingProgress.Text = loadingBarValue.ToString() + "%";

            //
            LoadingProgressBar.Value = loadingBarValue;
            
            if ( loadingBarValue >= LoadingProgressBar.Maximum)
            {
                LoadingbarTimer.Stop();
                
                // Hallo ich bin ein neuer Eintrag und sogleich eine Veränderung.


            }
        }

       
    }
}
