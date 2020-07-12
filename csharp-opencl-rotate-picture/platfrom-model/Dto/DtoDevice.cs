using OpenCL.Net;

namespace csharp_opencl_rotate_picture.platfrom_model.Dto
{
    struct DtoDevice
    {
        private InfoBuffer infoBufferDeviceName;

        private InfoBuffer infoBufferDeviceVendor;

        private InfoBuffer infoBufferDeviceVerion;

        private InfoBuffer infoBufferDeviceDriverVersion;

        private InfoBuffer infoBufferDeviceType;

        private InfoBuffer infoBufferDeviceMaxWorkGroupSize;

        private InfoBuffer infoBufferDeviceMaxWorkItemDimensions;

        public string Name => infoBufferDeviceName.ToString();
        public string Vendor => infoBufferDeviceVendor.ToString();
        public string Version => infoBufferDeviceVerion.ToString();
        public string DriverVersion => infoBufferDeviceDriverVersion.ToString();
        public DeviceType Type => infoBufferDeviceType.CastTo<DeviceType>();
        public long MaxWorkGroupSize => infoBufferDeviceMaxWorkGroupSize.CastTo<long>();
        public int MaxWorkItemDimensions => infoBufferDeviceMaxWorkItemDimensions.CastTo<int>();
        public Device ID { get; }

        public DtoDevice(Device id)
        {
            ID = id;
            infoBufferDeviceName = Cl.GetDeviceInfo(ID, DeviceInfo.Name, out _);
            infoBufferDeviceVendor = Cl.GetDeviceInfo(ID, DeviceInfo.Vendor, out _);
            infoBufferDeviceVerion = Cl.GetDeviceInfo(ID, DeviceInfo.Version, out _);
            infoBufferDeviceDriverVersion = Cl.GetDeviceInfo(ID, DeviceInfo.DriverVersion, out _);
            infoBufferDeviceType = Cl.GetDeviceInfo(ID, DeviceInfo.Type, out _);
            infoBufferDeviceMaxWorkGroupSize = Cl.GetDeviceInfo(ID, DeviceInfo.MaxWorkGroupSize, out _);
            infoBufferDeviceMaxWorkItemDimensions = Cl.GetDeviceInfo(ID, DeviceInfo.MaxWorkItemDimensions, out _);
        }

        public override string ToString()
        {
            return string.Format("Type : {0}\nName : {1}\nVendor : {2}\nVersion : {3}\nDriver version: {4}\n" +
                "Max work group size : {5}\nMax work item dimensions : {6}\n",
                Type.ToString(), Name, Vendor, Version, DriverVersion,
                MaxWorkGroupSize, MaxWorkItemDimensions);
        }
    }
}
