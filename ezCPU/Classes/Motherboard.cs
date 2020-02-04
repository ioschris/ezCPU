using System;
using System.Management;
using System.Windows.Forms;

namespace ezCPU
{
    public class Motherboard
    {
        //Public motherboard variables
        public string mbModel;
        public string mbManufacturer;
        public string mbSerial;
        public string mbBusType;
        public string mbStatus;

        //Public BIOS variables
        public string biosVersion;
        public string biosDate;
        public string biosManufacturer;

        //Access Date class
        Date dt = new Date();

        //Get all of the motherboard info
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
                    biosDate = dt.CustomDateTime(tempBIOSDate.Substring(0, 8));

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
