using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezCPU
{
    public class GPU
    {
        public string gpuName;
        public string gpuManufacturer;
        public string gpuVideoMode;
        public string gpuRefreshRate;
        public string gpuStatus;
        public string gpuDriverDate;
        public string gpuDriverVersion;

        //Get the name of the GPU and return the manufacturer (First word in string) **THIS MAY NEED MORE TESTING**
        public string GetManufacturer(string s)
        {
            var firstSpaceIndex = s.IndexOf(" ");
            gpuManufacturer = s.Substring(0, firstSpaceIndex);

            return gpuManufacturer;
        }

        //Gets the byte value and returns the best measurement
        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        public void GetGPUInfo()
        {
            try
            {
                //Create the ManagementObjectSearcher grabbing everything from the Win32_Processor
                ManagementObjectSearcher myProcessorObject = new ManagementObjectSearcher("select * from Win32_VideoController");

                //Loop through the returned results
                foreach (ManagementObject obj in myProcessorObject.Get())
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
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
