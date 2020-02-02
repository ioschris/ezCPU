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
        CPU cpu = new CPU();
        GPU gpu = new GPU(); 

        public ezCPU()
        {
            InitializeComponent();
        }

        //On load, do this
        private void ezCPU_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " - v" + Application.ProductVersion;

            //Call CPU class and display the results
            cpu.GetCPUInfo();
            DisplayCPUStats();

            //Call the GPU class and display the results
            gpu.GetGPUInfo();
            DisplayGPUStats();
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
        }
    }
}