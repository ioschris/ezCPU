using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ezCPU
{
    public class Motherboard
    {
        public string mbModel;
        public string mbManufacturer;
        public string mbSerial;
        public string mbBusType;
        public string mbStatus;

        public string biosVersion;
        public string biosDate;
        public string biosManufacturer;

        //This will take the 8 character string returned and convert it accordingly
        public string CustomDateTime(string s)
        {
            string year = s.Substring(0, 4);
            string yearRemoved = s.Remove(0, 4);

            string month = yearRemoved.Substring(0, 2);
            string monthRemoved = s.Remove(0, 6);

            string day = monthRemoved;

            return month + "-" + day + "-" + year;
        }

        public void GetMBInfo()
        {
            try
            {
                //Create the ManagementObjectSearcher grabbing everything from the Win32_Baseboard, Win32_MotherboardDevice and Win32_BIOS
                ManagementObjectSearcher baseBoard = new ManagementObjectSearcher("select * from Win32_BaseBoard");
                ManagementObjectSearcher motherBoard = new ManagementObjectSearcher("select * from Win32_MotherboardDevice");
                ManagementObjectSearcher bios = new ManagementObjectSearcher("select * from Win32_BIOS");

                //Loop through the returned results
                foreach (ManagementObject obj in baseBoard.Get())
                {
                    //Assign motherboard manufacturer
                    mbManufacturer = obj["Manufacturer"].ToString();

                    //Assign motherboard model
                    mbModel = obj["Product"].ToString();

                    //Assign motherboard serial number
                    mbSerial = obj["SerialNumber"].ToString();

                    //Assign motherboard status
                    mbStatus = obj["Status"].ToString();
                }

                foreach (ManagementObject obj in motherBoard.Get())
                {
                    //Assign motherboard bus type
                    mbBusType = obj["PrimaryBusType"].ToString();
                }

                foreach (ManagementObject obj in bios.Get())
                {
                    //Assign bios version
                    biosVersion = obj["Caption"].ToString();

                    //Assign bios date (Custom Date Time)
                    string tempBIOSDate = obj["ReleaseDate"].ToString();
                    biosDate = CustomDateTime(tempBIOSDate.Substring(0, 8));

                    //Assign the BIOS manufacturer
                    biosManufacturer = obj["Manufacturer"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
