using System.Drawing;
using System.Drawing.Imaging;
using System.Web;

namespace Blog.Controllers
{
    public static class ImageUploadValidator
    {
        public static bool IsWebFriendlyImage(HttpPostedFileBase file)
        {
            //check for actial object
            if (file == null)
                return false;
            // check size - file must be less tan 2MB and greater thank 1KB
            if (file.ContentLength > 2 * 1024 * 1024 || file.ContentLength < 1024)
                return false;
            try
            {
                using (var img = Image.FromStream(file.InputStream))
                {
                    return ImageFormat.Jpeg.Equals(img.RawFormats) ||
                           ImageFormat.Png.Equals(img.RawFormats) ||
                           ImageFormat.Gif.Equals(img.RawFormats);
                }
            }
          
        }
    }
}