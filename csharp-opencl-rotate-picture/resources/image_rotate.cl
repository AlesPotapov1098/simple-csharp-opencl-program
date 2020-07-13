__kernel void imagingTest(__read_only  image2d_t srcImg,
                       __write_only image2d_t dstImg)
{
  const sampler_t smp = CLK_NORMALIZED_COORDS_TRUE | 
    CLK_ADDRESS_NONE |
    CLK_FILTER_LINEAR;
  int2 coord = (int2)(get_global_id(0), get_global_id(1));
  int i = coord.x;
  int j = coord.y;
  uint4 bgra = read_imageui(srcImg, smp, coord); //The byte order is BGRA
  float4 bgrafloat = convert_float4(bgra) / 255.0f; //Convert to normalized [0..1] float
  //Convert RGB to luminance (make the image grayscale).
  //float luminance =  sqrt(0.1f * bgrafloat.z * bgrafloat.z + 0.6f * 
   //                   bgrafloat.y * bgrafloat.y + 0.0068f * bgrafloat.x * bgrafloat.x);
  //bgra.x = bgra.y = bgra.z = (uint) (luminance * 255.0f);
 // bgra.w = 255;
  write_imageui(dstImg, coord, bgra);
}