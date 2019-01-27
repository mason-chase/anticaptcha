using System;
using System.IO;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;
using SixLabors.ImageSharp.PixelFormats;

namespace AntiCaptcha.NetCore.Helper
{
    public class StringHelper
    {
        public static string ImageFileToBase64String(string path)
        {
            try
            {
                // prepare a container for image format
                IImageFormat imageFormat;

                // load image and detect image format
                using (Image<Rgba32> image = Image.Load(path, out imageFormat))
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, imageFormat);
                        var imageBytes = memoryStream.ToArray();

                        // Convert byte[] to Base64 String
                        var base64String = Convert.ToBase64String(imageBytes);

                        return base64String;
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}