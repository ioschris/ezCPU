using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Timers;

namespace ezCPU
{
    public partial class ezCPU : Form
    {
        //Create objects of each class that is needed
        CPU cpu = new CPU();
        GPU gpu = new GPU();
        Motherboard mb = new Motherboard();
        Memory mem = new Memory();

        //Constructor
        public ezCPU()
        {
            InitializeComponent();
        }

        //On load, do this
        private void ezCPU_Load(object sender, EventArgs e)
        {
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
    }
}