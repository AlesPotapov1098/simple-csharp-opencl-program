using csharp_opencl_rotate_picture.platfrom_model.Dto;
using OpenCL;
using OpenCL.Net;
using System;
using System.IO;
using System.Linq;

namespace csharp_opencl_rotate_picture.execution_model.dto
{
    class DtoProgram
    {
        public OpenCL.Net.Program ID { get; set; }

        private string PathToFile;

        private string[] SourceCode;

        public DtoProgram(ref string path)
        {
            PathToFile = path;
            using (StreamReader reader = new StreamReader(PathToFile))
                try 
                { 
                    SourceCode = reader.ReadToEnd().Split('\n').ToArray(); 
                }
                catch (IOException ex)
                {
                    throw ex;
                }
        }

        public void build(DtoContext context)
        {
            ID = Cl.CreateProgramWithSource(
                context.ID, 1, SourceCode, new IntPtr[1] { IntPtr.Zero }, out _);
        }
    }
}
