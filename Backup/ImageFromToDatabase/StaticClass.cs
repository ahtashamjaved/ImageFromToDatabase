using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;

using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Imaging.Textures;

namespace ImageFromToDatabase
{
    public static class StaticClass
    {
        /// <summary>
	/// Description of ImageConverter.
	/// </summary>

        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Image Varibles...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................
        public static Bitmap imageActual;
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................imageToByteArray...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

		
		public static byte[] imageToByteArray(System.Drawing.Image imageIn)
		{
			MemoryStream ms = new MemoryStream();
			imageIn.Save(ms,System.Drawing.Imaging.ImageFormat.Gif);
			return  ms.ToArray();
		}

        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................byteArrayToImage...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

        public static System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
			return returnImage;
	
		}
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Get Image Format...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

        public static ImageFormat getImageFormat(String extension)
        {
            switch (extension)
            {
                case ".bmp": return ImageFormat.Bmp;
                case ".gif": return ImageFormat.Gif;
                case ".jpg": return ImageFormat.Jpeg;
                case ".png": return ImageFormat.Png;
                case ".tiff": return ImageFormat.Tiff;
                default: break;
            }
            return ImageFormat.Jpeg;
        }

         //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Convert Image to GrayScale...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

        public static Bitmap GrayScale(Bitmap imageFile)
        {
            Bitmap image = (Bitmap)imageFile;
            IFilter filter = new GrayscaleBT709();
            image = filter.Apply(image);
            imageFile = image;
            return imageFile;
            //FilterResize resize = new ResizeNearestNeighbor( width, height );
        }


        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Resize Image...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................

        public static Bitmap Resize(Bitmap imageFile, int width, int height)
        {
            Bitmap image = (Bitmap)imageFile;
            FilterResize resize = new ResizeNearestNeighbor(width, height);
            image = resize.Apply(image);
            imageFile = image;
            return imageFile;
            
        }
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.......................................................................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com.................................Static Variables...................................
        //..............Developted by Ahtasham Ali ahtashamjaved@yahoo.com........................................................................................
        
        public static int imageSoruceLocation = 1;           // 1 for from folder , 2 for from Database
        public static string sourceDataBaseFileName = "";
        public static string destinationDataBaseFileName = "";
        public static string sourceImageFolder = "";
        public static string destinationImageFolder = "";
        public static string imageExtension = ".BMP";
        public static string updateQuery = "";





        public static string tableName = "";

        
        public static string connectionStr = "Data Source=AHTASHAMJAVED;Initial Catalog=ReportSupply2012;Integrated Security=True";
        public static string dataSourceSource = "";
        public static string dataSourceDestination = "";
        public static string databasePassword = "sk21213631";




    }
}
