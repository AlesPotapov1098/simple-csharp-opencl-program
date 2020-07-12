using OpenCL.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_opencl_rotate_picture.execution_model.dto
{
    class DtoKernel
    {
        public Kernel ID { get; }

        public DtoKernel(DtoProgram program, string name)
        {
            ID = Cl.CreateKernel(program.ID, name, out _);
        }
    }
}
