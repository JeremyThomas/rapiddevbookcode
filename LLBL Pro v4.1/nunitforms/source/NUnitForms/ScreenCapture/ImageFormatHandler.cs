/*----------------------------------------------------------------------------------------

	A-Soft Ingenieurbüro

	Copyright © 1994 - 2007. All Rights reserved.

	Related Copyrights :

			Microsoft .NET Windows Forms V2.0 library.
			Copyright (C) 2004...2006 Microsoft Corporation,
			All rights reserved.


	FILE		:	ImageFormatHandler.cs

	PROJECT		:	A-Soft Library
	SUB			:	Standard Library
 
	SYSTEM		:	Windows-XP, (Windows 2000), C# (.NET 2.0, Visual Studio.NET 2005)

	AUTHOR		:	Joachim Holzhauer
	
	DESCRIPTION	:	Supplies some helpers methods used for image processing (file 
					selection dialog, image format options selection etc.).
 
	VERSION		:	1.0 - 2006.01.31

----------------------------------------------------------------------------------------*/

using System;
using System.Drawing.Imaging;

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// Supplies some helpers methods used for image processing (file selection dialog, 
    /// image format options selection etc.).
    /// Here, this is just a fragment of the actual implementation !!!
    /// 
    /// </summary>
    public class ImageFormatHandler
    {
        #region ImageFormatTypes enum

        /// <summary>
        /// An enum which represents all supported graphic formats. These enum names are also used
        /// to get a description from the resources.
        /// </summary>
        public enum ImageFormatTypes
        {
            /// <summary>
            /// Undefined format
            /// </summary>
            imgNone,
            /// <summary>
            /// Windows bitmap
            /// </summary>
            imgBMP,
            /// <summary>
            /// Enhanced Windows metafile
            /// </summary>
            imgEMF,
            /// <summary>
            /// Exchangeable Image File
            /// </summary>
            imgEXIF,
            /// <summary>
            /// Graphics Interchange Format
            /// </summary>
            imgGIF,
            /// <summary>
            /// Windows icon
            /// </summary>
            imgICON,
            /// <summary>
            /// Joint Photographic Experts Group
            /// </summary>
            imgJPEG,
            /// <summary>
            /// Portable Network Graphics
            /// </summary>
            imgPNG,
            /// <summary>
            /// Tag Image File
            /// </summary>
            imgTIFF,
            /// <summary>
            /// Windows metafile
            /// </summary>
            imgWMF
        } ;

        #endregion

        /// <summary>
        /// All image decoders available.
        /// </summary>
        private ImageCodecInfo[] availableDecoders;

        /// <summary>
        /// All image encoders available.
        /// </summary>
        private ImageCodecInfo[] availableEncoders;

        /// <summary>
        /// This is the default format used for saving images.
        /// </summary>
        private ImageFormatTypes defaultFormat;

        /// <summary>
        /// The color depth for TIFF
        /// </summary>
        private long encodingColorDepth = 24;

        /// <summary>
        /// The TIFF compression type
        /// </summary>
        private EncoderValue encodingCompression = EncoderValue.CompressionLZW;

        /// <summary>
        /// The quality for JPEG compresseion (0...100)
        /// </summary>
        private long encodingQuality = 50;

        /// <summary>
        /// The rendering method for ????
        /// </summary>
        private EncoderValue encodingRenderMethod = EncoderValue.RenderProgressive;

        /// <summary>
        /// The scanning method for GIF
        /// </summary>
        private EncoderValue encodingScanMethod = EncoderValue.ScanMethodInterlaced;

        /// <summary>
        /// Creator
        /// </summary>
        public ImageFormatHandler()
        {
            availableEncoders = ImageCodecInfo.GetImageEncoders();
            availableDecoders = ImageCodecInfo.GetImageDecoders();
        }

        /// <summary>
        /// Get/Set the default image format used
        /// </summary>
        public ImageFormatTypes DefaultFormat
        {
            get { return defaultFormat; }
            set { defaultFormat = value; }
        }

        /// <summary>
        /// Get the image format associated with that enum, if it does not exist, then return a 'null'.
        /// </summary>
        /// <param name="type">The image format enum type</param>
        /// <returns>The windows image format type</returns>
        public static ImageFormat GetImageFormat(ImageFormatTypes type)
        {
            switch (type)
            {
                case ImageFormatTypes.imgBMP:
                    return ImageFormat.Bmp;
                case ImageFormatTypes.imgEMF:
                    return ImageFormat.Emf;
                case ImageFormatTypes.imgEXIF:
                    return ImageFormat.Exif;
                case ImageFormatTypes.imgGIF:
                    return ImageFormat.Gif;
                case ImageFormatTypes.imgICON:
                    return ImageFormat.Icon;
                case ImageFormatTypes.imgJPEG:
                    return ImageFormat.Jpeg;
                case ImageFormatTypes.imgPNG:
                    return ImageFormat.Png;
                case ImageFormatTypes.imgTIFF:
                    return ImageFormat.Tiff;
                case ImageFormatTypes.imgWMF:
                    return ImageFormat.Wmf;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Get the MIME name of the image format associated with that enum, 
        /// if it does not exist, then return a 'null'.
        /// </summary>
        /// <param name="type">The image format enum type</param>
        /// <returns>The MIME name of the desired image format type or 'null' when none exists.</returns>
        public static String GetMimeType(ImageFormatTypes type)
        {
            String s = null;
            switch (type)
            {
                case ImageFormatTypes.imgBMP:
                    s = "bmp";
                    break;
                case ImageFormatTypes.imgEMF:
                    s = "x-emf";
                    break;
                case ImageFormatTypes.imgGIF:
                    s = "gif";
                    break;
                case ImageFormatTypes.imgICON:
                    s = "x-icon";
                    break;
                case ImageFormatTypes.imgJPEG:
                    s = "jpeg";
                    break;
                case ImageFormatTypes.imgPNG:
                    s = "png";
                    break;
                case ImageFormatTypes.imgTIFF:
                    s = "tiff";
                    break;
                case ImageFormatTypes.imgWMF:
                    s = "x-wmf";
                    break;
            }
            if (!String.IsNullOrEmpty(s))
            {
                s = String.Format("image/{0}", s);
            }

            return s;
        }

        /// <summary>
        /// Get the enum image format associated with that windows format, if it does not exist, then return a 'imgNone'.
        /// </summary>
        /// <param name="type">The windows image format type</param>
        /// <returns>The image format enum type</returns>
        public static ImageFormatTypes GetImageFormat(ImageFormat type)
        {
            if (type == ImageFormat.Bmp)
            {
                return ImageFormatTypes.imgBMP;
            }
            else if (type == ImageFormat.Emf)
            {
                return ImageFormatTypes.imgEMF;
            }
            else if (type == ImageFormat.Exif)
            {
                return ImageFormatTypes.imgEXIF;
            }
            else if (type == ImageFormat.Gif)
            {
                return ImageFormatTypes.imgGIF;
            }
            else if (type == ImageFormat.Icon)
            {
                return ImageFormatTypes.imgICON;
            }
            else if (type == ImageFormat.Jpeg)
            {
                return ImageFormatTypes.imgJPEG;
            }
            else if (type == ImageFormat.Png)
            {
                return ImageFormatTypes.imgPNG;
            }
            else if (type == ImageFormat.Tiff)
            {
                return ImageFormatTypes.imgTIFF;
            }
            else if (type == ImageFormat.Wmf)
            {
                return ImageFormatTypes.imgWMF;
            }
            else
            {
                return ImageFormatTypes.imgNone;
            }
        }

        /// <summary>
        /// Search the codec for a given type, cycle through encoders and decoders until found. 
        /// If no match is found, return 'null'.
        /// </summary>
        /// <param name="type">The graphic format</param>
        /// <returns>The associated codec or 'null'.</returns>
        public virtual ImageCodecInfo GetCodecInfo(ImageFormatTypes type)
        {
            String mimeType = GetMimeType(type);

            if (!String.IsNullOrEmpty(mimeType))
            {
                for (int i = 0; i < 2; i++)
                {
                    ImageCodecInfo[] encoders;
                    encoders = i == 0 ? availableEncoders : availableDecoders;

                    foreach (ImageCodecInfo info in encoders)
                    {
                        if (info.MimeType == mimeType)
                        {
                            return info;
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Get the encoder parameters used for saving a graphic into a file or stream.
        /// </summary>
        /// <param name="type">The desired format type.</param>
        /// <param name="info">Returns the codec info.</param>
        /// <returns>The encoder parameters or 'null' when not supported by the requested type.</returns>
        public virtual EncoderParameters GetEncoderParameters(ImageFormatTypes type, out ImageCodecInfo info)
        {
            EncoderParameters parameters = null;
            info = GetCodecInfo(type);
            if (info != null)
            {
                switch (type)
                {
                    case ImageFormatTypes.imgGIF:
                        parameters = new EncoderParameters(2);
                        parameters.Param[0] = new EncoderParameter(Encoder.Version, (long) EncoderValue.VersionGif89);
                        parameters.Param[1] = new EncoderParameter(Encoder.ScanMethod, (long) encodingScanMethod);
                        break;

                    case ImageFormatTypes.imgJPEG:
                        parameters = new EncoderParameters(2);
                        parameters.Param[0] = new EncoderParameter(Encoder.RenderMethod, (long) encodingRenderMethod);
                        parameters.Param[1] = new EncoderParameter(Encoder.Quality, encodingQuality);
                        break;

                    case ImageFormatTypes.imgPNG:
                        parameters = new EncoderParameters(2);
                        parameters.Param[0] = new EncoderParameter(Encoder.RenderMethod, (long) encodingRenderMethod);
                        parameters.Param[1] = new EncoderParameter(Encoder.ScanMethod, (long) encodingScanMethod);
                        break;

                    case ImageFormatTypes.imgTIFF:
                        parameters = new EncoderParameters(2);
                        parameters.Param[0] = new EncoderParameter(Encoder.ColorDepth, encodingColorDepth);
                        parameters.Param[1] = new EncoderParameter(Encoder.Compression, (long) encodingCompression);
                        break;
                }
            }
            return parameters;
        }

        /// <summary>
        /// Get the default filename extension for a given type
        /// </summary>
        /// <param name="type">The image type</param>
        /// <returns>The extension string.</returns>
        public virtual String GetDefaultFilenameExtension(ImageFormatTypes type)
        {
            String ext = "";
            ImageCodecInfo info = GetCodecInfo(type);

            if (info != null)
            {
                String[] extensions = info.FilenameExtension.Split(new[] {';'});
                ext = extensions[0];
                if (ext.StartsWith("*."))
                {
                    ext = ext.Substring(2);
                }
            }
            return ext;
        }
    }
}