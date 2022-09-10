﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viewer
{
    internal class ImageUtils
    {
        public static byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ToImage(byte[] b)
        {
            //Create memory stream
            using (var ms = new MemoryStream(b))
            {
                //Get image from stream
                return Image.FromStream(ms);
            }
        }
    }
}