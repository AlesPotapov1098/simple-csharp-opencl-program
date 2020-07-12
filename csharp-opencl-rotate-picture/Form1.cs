using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using csharp_opencl_rotate_picture.platfrom_model;
using csharp_opencl_rotate_picture.platfrom_model.Dto;

namespace csharp_opencl_rotate_picture
{
    public partial class RotationImageByOpenCL : Form
    {
        private PlatformModel platfomrsOfOpenCL;
        private int currentOpenCLPlatform;
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
            currentOpenCLPlatform = NamesOpenCLPlatfroms.SelectedIndex;
            currentDeviceOfCurrentPlatform = 0;
            DtoDevice[] deviceOfCurrentPlatfrom = platfomrsOfOpenCL.Platforms[currentOpenCLPlatform].devices;
            NamesOfDevicesCurrentPlatform.Items.Clear();
            foreach (var item in deviceOfCurrentPlatfrom)
            {
                NamesOfDevicesCurrentPlatform.Items.Add(item.Name);
            }
            UpdatePlatfromInformation();
            NamesOfDevicesCurrentPlatform.SelectedIndex = currentDeviceOfCurrentPlatform;
        }

        private void NamesOfDevicesCurrentPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDeviceOfCurrentPlatform = NamesOfDevicesCurrentPlatform.SelectedIndex;
            UpdateDeviceInformation();
        }

        private void UpdatePlatfromInformation()
        {
            InformationCurrentPlatfrom.Items.Clear();
            DtoPlatform platform = platfomrsOfOpenCL.Platforms[currentOpenCLPlatform];
            string informationPlatform = platform.ToString();
            InformationCurrentPlatfrom.Items.AddRange(informationPlatform.Split('\n').ToArray());
            InformationCurrentPlatfrom.Update();
        }

        private void UpdateDeviceInformation()
        {
            InformationAboutDevice.Items.Clear();
            DtoDevice device = platfomrsOfOpenCL.Platforms[currentOpenCLPlatform].devices[currentDeviceOfCurrentPlatform];
            string informationDevice = device.ToString();
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
            currentOpenCLPlatform = 0;
            currentDeviceOfCurrentPlatform = 0;
            NamesOpenCLPlatfroms.Items.Clear();
            NamesOfDevicesCurrentPlatform.Items.Clear();
            foreach (var item in platfomrsOfOpenCL.Platforms)
            {
                NamesOpenCLPlatfroms.Items.Add(item.Name);
            }
            NamesOpenCLPlatfroms.SelectedIndex = currentOpenCLPlatform;
            LabelAngleScale.Text = string.Format("∠{0}°", Angle.Value);
        }

        private void RotationImageByOpenCL_Load(object sender, EventArgs e)
        {
            platfomrsOfOpenCL = new PlatformModel();
            ImageRotates.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
