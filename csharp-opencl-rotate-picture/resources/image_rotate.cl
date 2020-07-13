__kernel void imagingTest(__read_only  image2d_t srcImg,
                       __write_only image2d_t dstImg)
{
  const sampler_t smp = CLK_NORMALIZED_COORDS_TRUE | 
    CLK_ADDRESS_NONE |
    CLK_FILTER_LINEAR;
  int2 coord = (int2)(get_global_id(0), get_global_id(1));
  int i = coord.x;
  int j = coord.y;
  uint4 bgra = read_imageui(srcImg, smp, coord); 

  write_imageui(dstImg, coord, bgra);
}