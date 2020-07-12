using OpenCL;
using OpenCL.Net;

namespace csharp_opencl_rotate_picture.platfrom_model.Dto
{
    struct DtoPlatform
    {
        public Platform ID { get; }

        public DtoDevice[] devices { get; }

        private InfoBuffer infoBufferPlatfromName;

        private InfoBuffer infoBufferPlatfromVendor;
        
        private InfoBuffer infoBufferPlatfromVersion;

        private InfoBuffer infoBufferPlatformProfile;

        public string Name => infoBufferPlatfromName.ToString();

        public string Vendor => infoBufferPlatfromVendor.ToString();

        public string Version => infoBufferPlatfromVersion.ToString();

        public string Profile => infoBufferPlatformProfile.ToString();


        public DtoPlatform(Platform id)
        {
            ID = id;
            infoBufferPlatfromName = Cl.GetPlatformInfo(ID, PlatformInfo.Name, out _);
            infoBufferPlatfromVendor = Cl.GetPlatformInfo(ID, PlatformInfo.Vendor, out _);
            infoBufferPlatfromVersion = Cl.GetPlatformInfo(ID, PlatformInfo.Version, out _);
            infoBufferPlatformProfile = Cl.GetPlatformInfo(ID, PlatformInfo.Profile, out _);

            Device[] deviceIDs = Cl.GetDeviceIDs(ID, DeviceType.All, out _);
            devices = new DtoDevice[deviceIDs.Length];
            for (int i = 0; i < deviceIDs.Length; i++)
            {
                devices[i] = new DtoDevice(deviceIDs[i]);
            }
        }

        public override string ToString()
        {
            return string.Format("Name : {0}\nVendor : {1}\nVersion : {2}\nProfile : {3}\n",
                Name, Vendor, Version, Profile);
        }
    }
}
