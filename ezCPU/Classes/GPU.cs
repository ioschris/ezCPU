using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace ezCPU
{
    public class GPU
    {
        //Public GPU variables
        public string gpuName;
        public string gpuManufacturer;
        public string gpuVideoMode;
        public string gpuRefreshRate;
        public string gpuStatus;
        public string gpuDriverDate;
        public string gpuDriverVersion;

        //Access Date class
        Date dt = new Date();

        //Get the name of the GPU and return the manufacturer (First word in string) **THIS MAY NEED MORE TESTING**
        public string GetManufacturer(string s)
        {
            var firstSpaceIndex = s.IndexOf(" ");
            gpuManufacturer = s.Substring(0, firstSpaceIndex);

            return gpuManufacturer;
        }

        //Get all of the GPU info
        public void GetGPUInfo()
        {
            try
            {
                //Create the ManagementObjectSearcher grabbing everything from the Win32_Processor
                ManagementObjectSearcher gpu = new ManagementObjectSearcher("select * from Win32_VideoController");

                //Loop through the returned results
                foreach (ManagementObject obj in gpu.Get())
                {
                    //Assign GPU name
                    gpuName = obj["VideoProcessor"].ToString();

                    //Assign GPU manufacturer
                    string tempGPU = obj["Name"].ToString();
                    GetManufacturer(tempGPU);

                    //Assign video mode description
                    gpuVideoMode = obj["VideoModeDescription"].ToString();

                    //Assign refresh rate
                    gpuRefreshRate = obj["CurrentRefreshRate"].ToString();

                    //Assign GPU status
                    gpuStatus = obj["Status"].ToString();

                    //Assign GPU driver version
                    gpuDriverVersion = obj["DriverVersion"].ToString();

                    //Assign GPU driver date
                    string tempGPUDriverDate = obj["DriverDate"].ToString();
                    gpuDriverDate = dt.CustomDateTime(tempGPUDriverDate.Substring(0, 8));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
