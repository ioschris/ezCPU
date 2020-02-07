using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezCPU
{
    class Updater
    {
        //Variable to hold the new app version
        string newVersion = "";

        //Check for update and download if it exists
        public void DownloadUpdate()
        {
            //URL of the updated file
            string url = "http://www.chrisharrisdev.com/ezcpu/ezCPU.exe";

            //Declare new WebClient object
            WebClient wc = new WebClient();
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);
            wc.DownloadFileAsync(new Uri(url), Application.StartupPath + "/ezCPU(1).exe");
        }

        //When the download completes, show the message box and restart the application
        void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //Show a message when the download has completed
            MessageBox.Show("ezCPU is now up-to-date!\n\nThe application will now restart!", "ezCPU - Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        //Create method to check for an update
        public void GetUpdate()
        {
            //Declare new WebClient object
            WebClient wc = new WebClient();
            string textFile = wc.DownloadString("http://www.chrisharrisdev.com/ezcpu/ezcpu_version.txt");
            newVersion = textFile;

            //If there is a new version, call the DownloadUpdate method
            if (newVersion != Application.ProductVersion)
            {
                MessageBox.Show("An update is available!\n\nClick OK to download and restart!", "ezCPU - Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DownloadUpdate();
            }
            else
            {
                MessageBox.Show("ezCPU is up-to-date!\n\nThere is not an update that needs to be applied!", "ezCPU - Up-to-Date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
