using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using csharp_opencl_rotate_picture.platfrom_model;
using csharp_opencl_rotate_picture.platfrom_model.Dto;
using OpenCL.Net;

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
        private Image inImage;
        private Image outImage;
        
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
                outImage.Save(pathToSaveImage);
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

        private void Rotate_Click(object sender, EventArgs e)
        {
            Angle.Enabled = false;
            double angle = (double)Angle.Value * Math.PI / 180;
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);

            DtoPlatform platform = platfomrsOfOpenCL.Platforms[currentOpenCLPlatform];
            Device device = platform.devices[currentDeviceOfCurrentPlatform].ID;
            string pathToSrc = System.Environment.CurrentDirectory + "/../../resources/image_rotate.cl";
            if (!System.IO.File.Exists(pathToSrc))
            {
                Console.WriteLine("Program doesn't exist at path " + pathToSrc);
                return;
            }

            string src = System.IO.File.ReadAllText(pathToSrc);
            ErrorCode error;

            using (Context context = Cl.CreateContext(null,1,new Device[] { device },null,IntPtr.Zero, out error))
            using(OpenCL.Net.Program program = Cl.CreateProgramWithSource(context, 1, new[] { src},null, out error))
            {
                error = Cl.BuildProgram(program, 1, new[] { device }, string.Empty, null, IntPtr.Zero);
                if(Cl.GetProgramBuildInfo(program,device,ProgramBuildInfo.Status,out
                    error).CastTo<BuildStatus>() != BuildStatus.Success)
                {
                    return;
                }

                Kernel kernel = Cl.CreateKernel(program, "imagingTest", out error);
                int intPtrSize = 0;
                intPtrSize = Marshal.SizeOf(typeof(IntPtr));

                IMem inputImage2DBuffer;
                OpenCL.Net.ImageFormat clImageFormat = new OpenCL.Net.ImageFormat(ChannelOrder.RGBA, ChannelType.Unsigned_Int8);

                int intInputWidth = userImage.Width, intInputHeight = userImage.Height;

                

                Bitmap bitmap = new Bitmap(userImage);
                BitmapData bitmapData = bitmap.LockBits(
                    new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                    ImageLockMode.ReadWrite,
                    PixelFormat.Format32bppArgb);
                int imgStride = bitmapData.Stride;
                int imgSize = bitmapData.Stride * bitmapData.Height;
                byte[] imgArrya = new byte[imgSize];
                Marshal.Copy(bitmapData.Scan0,imgArrya,0,imgSize);

                inputImage2DBuffer = Cl.CreateImage2D(context, MemFlags.CopyHostPtr | MemFlags.ReadOnly, clImageFormat,
                    (IntPtr)bitmapData.Width, (IntPtr)bitmapData.Height, (IntPtr)0, imgArrya, out error);

                byte[] outputImage2DBuffer = new byte[imgSize];
                IMem outputImage = Cl.CreateImage2D(context, MemFlags.CopyHostPtr | MemFlags.WriteOnly, clImageFormat,
                    (IntPtr)intInputWidth, (IntPtr)intInputHeight, (IntPtr)0, outputImage2DBuffer, out error);

                error  = Cl.SetKernelArg(kernel, 0, (IntPtr)intPtrSize,  inputImage2DBuffer);
                error |= Cl.SetKernelArg(kernel, 1, (IntPtr)intPtrSize,  outputImage);
                error |= Cl.SetKernelArg(kernel, 2, (IntPtr)sizeof(int), intInputWidth);
                error |= Cl.SetKernelArg(kernel, 3, (IntPtr)sizeof(int), intInputHeight);
                error |= Cl.SetKernelArg(kernel, 4, (IntPtr)sizeof(double), sin);
                error |= Cl.SetKernelArg(kernel, 5, (IntPtr)sizeof(double), cos);

                CommandQueue cmdQueue = Cl.CreateCommandQueue(context, device, (CommandQueueProperties)0, out error);

                Event clevent;

                IntPtr[] originPtr = new IntPtr[] { (IntPtr)0, (IntPtr)0, (IntPtr)0 };
                IntPtr[] regionPtr = new IntPtr[] { (IntPtr)intInputWidth, (IntPtr)intInputHeight, (IntPtr)1 };   
                IntPtr[] workGroupSizePtr = new IntPtr[] { (IntPtr)intInputWidth, (IntPtr)intInputHeight, (IntPtr)1 };
                error = Cl.EnqueueWriteImage(cmdQueue, inputImage2DBuffer, Bool.True,
                   originPtr, regionPtr, (IntPtr)0, (IntPtr)0, imgArrya, 0, null, out clevent);

                error = Cl.EnqueueNDRangeKernel(cmdQueue, kernel, 2, null, workGroupSizePtr, null, 0, null, out clevent);
                error = Cl.Finish(cmdQueue);
                error = Cl.EnqueueReadImage(cmdQueue, outputImage, Bool.True, originPtr, regionPtr,
                                            (IntPtr)0, (IntPtr)0, outputImage2DBuffer, 0, null, out clevent);

                Cl.ReleaseKernel(kernel);
                Cl.ReleaseCommandQueue(cmdQueue);

                Cl.ReleaseMemObject(inputImage2DBuffer);
                Cl.ReleaseMemObject(outputImage);
                
                GCHandle pinnedOutputArray = GCHandle.Alloc(outputImage2DBuffer, GCHandleType.Pinned);
                IntPtr outputBmpPointer = pinnedOutputArray.AddrOfPinnedObject();
                
                Bitmap outputBitmap = new Bitmap(intInputWidth, intInputHeight,
                      imgStride, PixelFormat.Format32bppArgb, outputBmpPointer);
                outImage = outputBitmap;
                ImageRotates.Image = outImage;
            }

            Angle.Enabled = true;
        }
    }
}
