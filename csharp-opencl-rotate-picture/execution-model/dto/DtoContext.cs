using csharp_opencl_rotate_picture.platfrom_model.Dto;
using OpenCL.Net;
using System;

namespace csharp_opencl_rotate_picture.execution_model.dto
{
    class DtoContext
    {
        public Context ID { get; }

        public DtoContext(DtoDevice currentDevice)
        {
            ID = Cl.CreateContext(
                null, 1, new Device[1] { currentDevice.ID }, null,IntPtr.Zero, out _);
        }
    }
}
