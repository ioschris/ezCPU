using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezCPU
{
    public class Memory
    {
        //Public ram variables
        public string ramSize;
        public string ramManufacturer;
        public string ramType;
        public string ramFrequency;

        //Take the returned RAM size and convert it to GB
        public string BytesToGB(string s)
        {
            double capacity = Convert.ToDouble(s);
            double newCapacity = capacity / 1024 / 1024 / 1024;
            return Math.Round(newCapacity, 0).ToString() + " GB";
        }

        //Get integer result and return the type corresponding to the index
        public string GetRAMType(int i)
        {
            string s = "";

            switch (i)
            {
                case 0:
                    s = "Unknown";
                    break;
                case 1:
                    s = "Other";
                    break;
                case 2:
                    s = "DRAM";
                    break;
                case 3:
                    s = "Synchronous RAM";
                    break;
                case 4:
                    s = "Cache RAM";
                    break;
                case 5:
                    s = "EDO";
                    break;
                case 6:
                    s = "EDRAM";
                    break;
                case 7:
                    s = "VRAM";
                    break;
                case 8:
                    s = "SRAM";
                    break;
                case 9:
                    s = "RAM";
                    break;
                case 10:
                    s = "ROM";
                    break;
                case 11:
                    s = "Flash";
                    break;
                case 12:
                    s = "EEPROM";
                    break;
                case 13:
                    s = "FEPROM";
                    break;
                case 14:
                    s = "EPROM";
                    break;
                case 15:
                    s = "CDRAM";
                    break;
                case 16:
                    s = "3DRAM";
                    break;
                case 17:
                    s = "SDRAM";
                    break;
                case 18:
                    s = "SGRAM";
                    break;
                case 19:
                    s = "RDRAM";
                    break;
                case 20:
                    s = "DDR";
                    break;
                case 21:
                    s = "DDR2";
                    break;
                case 22:
                    s = "DDR2 FB-DIMM";
                    break;
                case 24:
                    s = "DDR3";
                    break;
                case 25:
                    s = "FBD2";
                    break;
                case 26:
                    s = "DDR4";
                    break;
            }

            return s;
        }

        //Get all of the memory info
        public void GetRAMInfo()
        {
            try
            {
                //Create the ManagementObjectSearcher grabbing everything from the Win32_PhysicalMemory
                ManagementObjectSearcher ram = new ManagementObjectSearcher("select * from Win32_PhysicalMemory");

                //Loop through the returned results
                foreach (ManagementObject obj in ram.Get())
                {
                    //Assign ram manufacturer
                    ramManufacturer = obj["Manufacturer"].ToString();

                    //Assign ram type
                    ramType = obj["SMBIOSMemoryType"].ToString();

                    //Get ram frequency
                    ramFrequency = obj["Speed"].ToString();

                    ramSize = WMIGetTotalPhysicalMemory().ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Get total RAM size
        public static ulong WMIGetTotalPhysicalMemory()
        {
            ManagementScope mScope = new ManagementScope($@"\\{Environment.MachineName}\root\CIMV2");
            SelectQuery mQuery = new SelectQuery("SELECT * FROM Win32_PhysicalMemory");
            mScope.Connect();

            ulong installedMemory = 0;
            using (ManagementObjectSearcher moSearcher = new ManagementObjectSearcher(mScope, mQuery))
            {
                foreach (ManagementObject moCapacity in moSearcher.Get())
                {
                    installedMemory += (UInt64)moCapacity["Capacity"];
                }
            }
            return installedMemory;
        }
    }
}
