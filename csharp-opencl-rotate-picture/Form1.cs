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
    public partial class RotationImageByOpenCL : Form
    {
        private ComputePlatform[] platfomrsOfOpenCL;
        private Dictionary<string,ComputeDevice[]> devicesByOpenCLPlatfrom;
        private int currentSIOfNamesOfOpenCLPlatforms;
        private int currentDeviceOfCurrentPlatform;
        private string pathToOpenImage;
        private string pathToSaveImage;
        private Image userImage;
        public RotationImageByOpenCL()
        {
             InitializeComponent();                       
        }

        private void NamesOpenCLPlatfroms_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSIOfNamesOfOpenCLPlatforms = NamesOpenCLPlatfroms.SelectedIndex;
            currentDeviceOfCurrentPlatform = 0;
            ComputeDevice[] deviceOfCurrentPlatfrom = devicesByOpenCLPlatfrom[
                platfomrsOfOpenCL[currentSIOfNamesOfOpenCLPlatforms].Name];
            NamesOfDevicesCurrentPlatform.Items.Clear();
            foreach (var item in deviceOfCurrentPlatfrom)
            {
                NamesOfDevicesCurrentPlatform.Items.Add(item.Name);
            }
            NamesOfDevicesCurrentPlatform.SelectedIndex = currentDeviceOfCurrentPlatform;
            UpdatePlatfromInformation();
            UpdateDeviceInformation();    
        }
        private void NamesOfDevicesCurrentPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDeviceOfCurrentPlatform = NamesOfDevicesCurrentPlatform.SelectedIndex;
            UpdateDeviceInformation();
        }

        private void UpdatePlatfromInformation()
        {
            InformationCurrentPlatfrom.Items.Clear();
            ComputePlatform platform = platfomrsOfOpenCL[currentSIOfNamesOfOpenCLPlatforms];
            string informationPlatform = string.Format("Name : {0}\nVendor : {1}\nVersion : {2}\nProfile : {3}\n",
                platform.Name, platform.Vendor, platform.Version, platform.Profile);
            InformationCurrentPlatfrom.Items.AddRange(informationPlatform.Split('\n').ToArray());
            InformationCurrentPlatfrom.Update();
        }

        private void UpdateDeviceInformation()
        {
            InformationAboutDevice.Items.Clear();
            ComputeDevice[] deviceOfCurrentPlatfrom = devicesByOpenCLPlatfrom[
                platfomrsOfOpenCL[currentSIOfNamesOfOpenCLPlatforms].Name];
            ComputeDevice device = deviceOfCurrentPlatfrom[currentDeviceOfCurrentPlatform];
            string informationDevice = string.Format("Type : {0}\nName : {1}\nVendor : {2}\nVersion : {3}\nDriver version: {4}\n" +
                "Max work group size : {5}\nMax work item dimensions : {6}\n",
                device.Type.ToString(), device.Name, device.Vendor, device.VersionString, device.DriverVersion,
                device.MaxWorkGroupSize,device.MaxWorkItemDimensions);
            
            InformationAboutDevice.Items.AddRange(informationDevice.Split('\n').ToArray());
            InformationAboutDevice.Update();
        }

        private void Angle_Scroll(object sender, EventArgs e)
        {
            LabelAngleScale.Text = string.Format("∠{0}°", Angle.Value);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if(OpenImage.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            pathToOpenImage = OpenImage.FileName;

            try
            {
                userImage = Image.FromFile(pathToOpenImage);
                ImageRotates.Image = userImage;
                ImageRotates.Update();
            } 
            catch(OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveImage.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            pathToSaveImage = SaveImage.FileName;

            try
            {
                userImage.Save(pathToSaveImage);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RotationImageByOpenCL_Shown(object sender, EventArgs e)
        {
            pathToOpenImage = string.Empty;
            pathToSaveImage = string.Empty;
            currentSIOfNamesOfOpenCLPlatforms = 0;
            currentDeviceOfCurrentPlatform = 0;
            NamesOpenCLPlatfroms.Items.Clear();
            NamesOfDevicesCurrentPlatform.Items.Clear();
            foreach (var item in platfomrsOfOpenCL)
            {
                NamesOpenCLPlatfroms.Items.Add(item.Name);
            }
            NamesOpenCLPlatfroms.SelectedIndex = currentSIOfNamesOfOpenCLPlatforms;
            LabelAngleScale.Text = string.Format("∠{0}°", Angle.Value);
        }

        private void RotationImageByOpenCL_Load(object sender, EventArgs e)
        {
            platfomrsOfOpenCL = ComputePlatform.Platforms.ToArray();
            devicesByOpenCLPlatfrom = new Dictionary<string, ComputeDevice[]>();
            foreach (var item in platfomrsOfOpenCL)
            {
                var devices = item.Devices;
                devicesByOpenCLPlatfrom.Add(item.Name, devices.ToArray());
            }
            ImageRotates.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
