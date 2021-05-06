using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace Shop.Security
{
    public static class ImageSecurity
    {
        public static bool ImageValidator(IFormFile file)
        {
            if(file.Length>0 && file != null)
            {
                try
                {
                    System.Drawing.Image.FromStream(file.OpenReadStream());
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;

        }
    }
}
