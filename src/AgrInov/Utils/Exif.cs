using System;
using System.IO;
using System.Linq;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;

namespace AgrInov.Utils
{
    public static class ExifReader
    {
        public static (double? Latitude, double? Longitude, DateTime? TakenAt) GetExifData(Stream imageStream)
        {
            try
            {
                var directories = ImageMetadataReader.ReadMetadata(imageStream);
                var gpsDirectory = directories.OfType<GpsDirectory>().FirstOrDefault();
                var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();

                double? lat = null;
                double? lon = null;

                if (gpsDirectory != null)
                {
                    var latRef = gpsDirectory.GetDescription(GpsDirectory.TagLatitudeRef);
                    var lonRef = gpsDirectory.GetDescription(GpsDirectory.TagLongitudeRef);

                    var latComponents = gpsDirectory.GetRationalArray(GpsDirectory.TagLatitude);
                    var lonComponents = gpsDirectory.GetRationalArray(GpsDirectory.TagLongitude);

                    if (latComponents != null && lonComponents != null)
                    {
                        lat = ConvertToDegrees(latComponents);
                        lon = ConvertToDegrees(lonComponents);

                        if (latRef == "S")
                            lat = -lat;
                        if (lonRef == "W")
                            lon = -lon;
                    }
                }

                DateTime? takenAt = null;
                if (subIfdDirectory != null && subIfdDirectory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out DateTime date))
                    takenAt = date;

                return (lat, lon, takenAt);
            }
            catch
            {
                return (null, null, null);
            }
        }

        private static double ConvertToDegrees(MetadataExtractor.Rational[] components)
        {
            double degrees = components[0].ToDouble();
            double minutes = components[1].ToDouble();
            double seconds = components[2].ToDouble();
            return degrees + (minutes / 60.0) + (seconds / 3600.0);
        }
    }
}
