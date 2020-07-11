using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cloo;

namespace csharp_opencl_rotate_picture
{
    public partial class rotationImageByOpenCL : Form
    {
        private ComputePlatform[] platfomrsOfOpenCL;
        private Dictionary<string,ComputeDevice[]> devicesByOpenCLPlatfrom;
        private int currentSIOfNamesOfOpenCLPlatforms;
        private int currentDeviceOfCurrentPlatform;
        public rotationImageByOpenCL()
        {
            InitializeComponent();
        }

        private void rotationImageByOpenCL_Activated(object sender, EventArgs e)
        {
            currentSIOfNamesOfOpenCLPlatforms = 0;
            currentDeviceOfCurrentPlatform = 0;
            platfomrsOfOpenCL = ComputePlatform.Platforms.ToArray();
            devicesByOpenCLPlatfrom = new Dictionary<string, ComputeDevice[]>();
            foreach (var item in platfomrsOfOpenCL)
            {
                namesOpenCLPlatfroms.Items.Add(item.Name);

                var devices = item.Devices;
                devicesByOpenCLPlatfrom.Add(item.Name, devices.ToArray());
            }
            namesOpenCLPlatfroms.SelectedIndex = currentSIOfNamesOfOpenCLPlatforms;
            ComputeDevice[] deviceOfCurrentPlatfrom = devicesByOpenCLPlatfrom[
                platfomrsOfOpenCL[currentSIOfNamesOfOpenCLPlatforms].Name];
            foreach(var device in deviceOfCurrentPlatfrom)
            {
                namesOfDevicesCurrentPlatform.Items.Add(device.Name);
            }
            namesOfDevicesCurrentPlatform.SelectedIndex = currentDeviceOfCurrentPlatform;
            labelAngleScale.Text = angle.Value.ToString();
        }

        private void namesOpenCLPlatfroms_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSIOfNamesOfOpenCLPlatforms = namesOpenCLPlatfroms.SelectedIndex;
            currentDeviceOfCurrentPlatform = 0;
            ComputeDevice[] deviceOfCurrentPlatfrom = devicesByOpenCLPlatfrom[
                platfomrsOfOpenCL[currentSIOfNamesOfOpenCLPlatforms].Name];
            namesOfDevicesCurrentPlatform.Items.Clear();
            foreach (var item in deviceOfCurrentPlatfrom)
            {
                namesOfDevicesCurrentPlatform.Items.Add(item.Name);
            }
            namesOfDevicesCurrentPlatform.SelectedIndex = currentDeviceOfCurrentPlatform;

            UpdatePlatfromInformation();
            UpdateDeviceInformation();
        }
        private void namesOfDevicesCurrentPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDeviceOfCurrentPlatform = namesOfDevicesCurrentPlatform.SelectedIndex;
            UpdateDeviceInformation();
        }

        private void UpdatePlatfromInformation()
        {
            informationCurrentPlatfrom.Items.Clear();
            ComputePlatform platform = platfomrsOfOpenCL[currentSIOfNamesOfOpenCLPlatforms];
            string informationPlatform = string.Format("Name : {0}\nVendor : {1}\nVersion : {2}\nProfile : {3}\n",
                platform.Name, platform.Vendor, platform.Version, platform.Profile);
            informationCurrentPlatfrom.Items.AddRange(informationPlatform.Split('\n').ToArray());
            informationCurrentPlatfrom.Update();
        }

        private void UpdateDeviceInformation()
        {
            informationAboutDevice.Items.Clear();
            ComputeDevice[] deviceOfCurrentPlatfrom = devicesByOpenCLPlatfrom[
                platfomrsOfOpenCL[currentSIOfNamesOfOpenCLPlatforms].Name];
            ComputeDevice device = deviceOfCurrentPlatfrom[currentDeviceOfCurrentPlatform];
            string informationDevice = string.Format("Type : {0}\nName : {1}\nVendor : {2}\nVersion : {3}\nDriver version: {4}\n" +
                "Max work group size : {5}\nMax work item dimensions : {6}\n",
                device.Type.ToString(), device.Name, device.Vendor, device.VersionString, device.DriverVersion,
                device.MaxWorkGroupSize,device.MaxWorkItemDimensions);
            
            informationAboutDevice.Items.AddRange(informationDevice.Split('\n').ToArray());
            informationAboutDevice.Update();
        }

        private void angle_Scroll(object sender, EventArgs e)
        {
            labelAngleScale.Text = angle.Value.ToString();
        }

        private void open_Click(object sender, EventArgs e)
        {
            openImgage.ShowDialog();
        }
    }
}
