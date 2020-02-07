using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace ezCPU
{
    public partial class ezCPU : Form
    {
        //Create objects of each class that is needed
        CPU cpu = new CPU();
        GPU gpu = new GPU();
        Motherboard mb = new Motherboard();
        Memory mem = new Memory();
        Updater u = new Updater();

        //Constructor
        public ezCPU()
        {
            InitializeComponent();
        }

        //On load, do this
        private void ezCPU_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Application.StartupPath + "/ezCPU(2).exe"))
            {
                System.IO.File.Delete(Application.StartupPath + "/ezCPU(2).exe");
            }

            this.Text = this.Text + " - v" + Application.ProductVersion;
            this.abVersion.Text = "Version: " + Application.ProductVersion;

            //Call CPU class and display the results
            cpu.GetCPUInfo();
            DisplayCPUStats();

            //Call the GPU class and display the results
            gpu.GetGPUInfo();
            DisplayGPUStats();

            //Call the motherboard class and display the results
            mb.GetMBInfo();
            DisplayMBStats();

            //Call the memory class and display the results
            mem.GetRAMInfo();
            DisplayMemoryStats();
        }

        //Pulls the information from the CPU class to display it on the form
        public void DisplayCPUStats()
        {
            txtCPUName.Text = cpu.cpuName;

            if (cpu.cpuManufacturer.Contains("Intel"))
            {
                txtCPUManufacturer.Text = "Genuine Intel";
            }
            else if (cpu.cpuManufacturer.Contains("AMD"))
            {
                txtCPUManufacturer.Text = "Authentic AMD";
            }
            else
            {
                txtCPUManufacturer.Text = cpu.cpuManufacturer;
            }

            txtCores.Text = cpu.cpuCores;
            txtThreads.Text = cpu.cpuThreads;
            txtMaxSpeed.Text = cpu.ConvertClockSpeed(cpu.cpuMaxSpeed);
            txtCurrentSpeed.Text = cpu.ConvertClockSpeed(cpu.cpuCurrentSpeed);
            txtCaption.Text = cpu.cpuCaption;
            txtStatus.Text = cpu.cpuStatus;
            txtArchitecture.Text = cpu.GetArchitecture(Convert.ToInt16(cpu.cpuArchitecture));
        }

        //Pulls the information from the GPU class to display it on the form
        public void DisplayGPUStats()
        {
            txtGPUName.Text = gpu.gpuName;
            txtGPUManufacturer.Text = gpu.gpuManufacturer;
            txtGPUVideoMode.Text = gpu.gpuVideoMode;
            txtGPURefresh.Text = gpu.gpuRefreshRate + " hertz";
            txtGPUStatus.Text = gpu.gpuStatus;
            txtGPUDriverVersion.Text = gpu.gpuDriverVersion;
            txtGPUDriverDate.Text = gpu.gpuDriverDate;
        }
        
        //Pulls the information from the Motherboard class to display it on the form
        public void DisplayMBStats()
        {
            //Motherboard information
            txtMBManufacturer.Text = mb.mbManufacturer;
            txtMBModel.Text = mb.mbModel;
            txtMBSerial.Text = mb.mbSerial;
            txtMBBusType.Text = mb.mbBusType;
            txtMBStatus.Text = mb.mbStatus;

            //BIOS information
            txtBIOSVersion.Text = mb.biosVersion;
            txtBIOSDate.Text = mb.biosDate;
            txtBIOSBrand.Text = mb.biosManufacturer;
        }

        //Pulls the information from the Memory class to display it on the form
        public void DisplayMemoryStats()
        {
            //RAM information
            txtRAMSize.Text = mem.BytesToGB(mem.ramSize);
            txtRAMManufacturer.Text = mem.ramManufacturer;
            txtRAMType.Text = mem.GetRAMType(Convert.ToInt16(mem.ramType));
            txtRAMFrequency.Text = String.Format("{0:n1}", Convert.ToInt16(mem.ramFrequency)) + " MHz";
        }

        //Visit the GitHub repo on click
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ioschris/ezCPU");
        }

        //When the app restarts, rename the updated file, rename the original file, and delete the old version
        private void ezCPU_FormClosed(object sender, FormClosedEventArgs e)
        {
            //This renames the original file so any shortcut works and names it accordingly after the update
            if (System.IO.File.Exists(Application.StartupPath + "/ezCPU(1).exe"))
            {
                System.IO.File.Move(Application.StartupPath + "/ezCPU.exe", Application.StartupPath + "/ezCPU(2).exe");
                System.IO.File.Move(Application.StartupPath + "/ezCPU(1).exe", Application.StartupPath + "/ezCPU.exe");
            }
        }

        //Check for updates
        private void button1_Click(object sender, EventArgs e)
        {
            u.GetUpdate();
        }

        //Dean's link
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/nuhnotorious");
        }

        //Cas' link
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/ggcasano");
        }

        //Shizzle's link
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/shizzlemoo");
        }

        //Kelly's link
        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/xcxkelly");
        
        }
    }
}