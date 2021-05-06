using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ExtensionMethods
{
    public static class DirectoryEX
    {
        public static void CreateDirectory(this string path)
        {
            try
            {
                path = Directory.GetCurrentDirectory() + path;
                if (Directory.Exists(path))
                    return;
                Directory.CreateDirectory(path);
            }
            catch
            {


            }

        }

        public static void DeleteDirectory(this string path)
        {

            path = Directory.GetCurrentDirectory() + path;
            if (Directory.Exists(path))
            {
                Directory.Delete(path,true);
            }






        }
    }
}
