using System;
using System.Management;
using System.Windows.Forms;

namespace ezCPU
{
    public class Motherboard
    {
        //Check for null object
        IsNull n = new IsNull();

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
                    mbManufacturer = n.isNull(obj["Manufacturer"]);

                    //Assign motherboard model
                    mbModel = n.isNull(obj["Product"]);

                    //Assign motherboard serial number
                    mbSerial = n.isNull(obj["SerialNumber"]);

                    //Assign motherboard status
                    mbStatus = n.isNull(obj["Status"]);
                }

                foreach (ManagementObject obj in motherBoard.Get())
                {
                    //Assign motherboard bus type
                    mbBusType = n.isNull(obj["PrimaryBusType"]);
                }

                foreach (ManagementObject obj in bios.Get())
                {
                    //Assign bios version
                    biosVersion = n.isNull(obj["Caption"]);

                    //Assign bios date (Custom Date Time)
                    string tempBIOSDate = n.isNull(obj["ReleaseDate"]);

                    if (tempBIOSDate != "N/A")
                    {
                        biosDate = dt.CustomDateTime(tempBIOSDate.Substring(0, 8));
                    }

                    //Assign the BIOS manufacturer
                    biosManufacturer = n.isNull(obj["Manufacturer"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
