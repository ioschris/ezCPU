﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezCPU
{
    public class CPU
    {
        public string cpuName;
        public string cpuManufacturer;
        public string cpuCores;
        public string cpuThreads;
        public string cpuMaxSpeed;
        public string cpuCurrentSpeed;
        public string cpuCaption;
        public string cpuStatus;
        public string cpuArchitecture;

        //Convert the string format to a readable double
        public string ConvertClockSpeed(string s)
        {
            double clockSpeed = Convert.ToDouble(s);
            double newClockSpeed = (clockSpeed / 1000);
            return Math.Round(newClockSpeed, 2).ToString() + " GHz";
        }

        //Accept an integer value and return the text associated to the value
        public string GetArchitecture(int i)
        {
            string s = "";

            switch (i)
            {
                case 0:
                    s = "x86";
                    break;
                case 1:
                    s = "MIPS";
                    break;
                case 2:
                    s = "Alpha";
                    break;
                case 3:
                    s = "PowerPC";
                    break;
                case 6:
                    s = "ia64";
                    break;
                case 9:
                    s = "x64";
                    break;
            }

            return s;
        }

        //Get all of the CPU info
        public void GetCPUInfo()
        {
            try
            {
                //Create the ManagementObjectSearcher grabbing everything from the Win32_Processor
                ManagementObjectSearcher cpu = new ManagementObjectSearcher("select * from Win32_Processor");

                //Loop through the returned results
                foreach (ManagementObject obj in cpu.Get())
                {
                    //Assign CPU Name
                    cpuName = obj["Name"].ToString();

                    //Assign CPU Manufacturer
                    cpuManufacturer = obj["Manufacturer"].ToString();

                    //Assign CPU cores
                    cpuCores = obj["NumberOfCores"].ToString();

                    //Assign CPU threads
                    cpuThreads = obj["ThreadCount"].ToString();

                    //Assign CPU max speed
                    cpuMaxSpeed = obj["MaxClockSpeed"].ToString();

                    //Display current clock speed
                    cpuCurrentSpeed = obj["CurrentClockSpeed"].ToString();

                    //Get family, model and stepping
                    cpuCaption = obj["Caption"].ToString();

                    //Get status of CPU-
                    cpuStatus = obj["Status"].ToString();

                    //Get the architecure
                    cpuArchitecture = obj["Architecture"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
