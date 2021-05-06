using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ExtensionMethods
{
    public static  class ImageEX
    {
        public static void DeleteImage(this string FileName,string path)
        {
            string ImagePath = Path.Combine(Directory.GetCurrentDirectory(), path, FileName);
            if (System.IO.File.Exists(ImagePath))
            {
                System.IO.File.Delete(ImagePath);
            }

        }

        public static string SaveImage(this IFormFile imgfile , string FileName ,string path)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                FileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(imgfile.FileName);
            }
            path = Path.Combine(Directory.GetCurrentDirectory(), path, FileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                imgfile.CopyTo(stream);
            }
            return FileName;
        }


        public static void Image_resize(this string input_Image_Path, string output_Image_Path, int new_width,int new_height)

        {
            const long quality = 50L;
            using (var image = new Bitmap(System.Drawing.Image.FromFile(input_Image_Path)))

            {
                //< create Empty Drawarea >
                var resized_Bitmap = new Bitmap(new_width, new_height);

                //</ create Empty Drawarea >
                using (var graphics = Graphics.FromImage(resized_Bitmap))
                {
                    //< setup >

                    graphics.CompositingQuality = CompositingQuality.HighSpeed;

                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    graphics.CompositingMode = CompositingMode.SourceCopy;

                    //</ setup >
                    //< draw into placeholder >

                    graphics.DrawImage(image, 0, 0, new_width, new_height);

                    //</ draw into placeholder >
                    //--< Output as .Jpg >--

                    using (var output = System.IO.File.Open(output_Image_Path, FileMode.Create))

                    {

                        //< setup jpg >

                        var qualityParamId = Encoder.Quality;

                        var encoderParameters = new EncoderParameters(1);

                        encoderParameters.Param[0] = new EncoderParameter(qualityParamId, quality);

                        //</ setup jpg >
                        //< save Bitmap as Jpg >

                        var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);

                        resized_Bitmap.Save(output, codec, encoderParameters);

                        //</ save Bitmap as Jpg >
                    }

                    //--</ Output as .Jpg >--

                }

            }



            //---------------</ Image_resize() >---------------

        }

        public static IEnumerable<FileInfo> GetFilesByExtensions(this DirectoryInfo directoryInfo, params string[] extensions)
        {
            var allowedExtensions = new HashSet<string>(extensions, StringComparer.OrdinalIgnoreCase);
            var i = directoryInfo.EnumerateFiles().Where(f => allowedExtensions.Contains(f.Extension));
            return directoryInfo.EnumerateFiles().Where(f => allowedExtensions.Contains(f.Extension));
        }



    }

}

