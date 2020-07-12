using csharp_opencl_rotate_picture.platfrom_model.Dto;
using OpenCL.Net;

namespace csharp_opencl_rotate_picture.platfrom_model
{
    class PlatformModel
    {
        public DtoPlatform[] Platforms { get; set; }
        
        public PlatformModel()
        {
            Platform[] platformIDs = Cl.GetPlatformIDs(out _);
            Platforms = new DtoPlatform[platformIDs.Length];
            for(int i = 0; i < platformIDs.Length; i++)
            {
                Platforms[i] = new DtoPlatform(platformIDs[i]);
            }
        }
    }
}
