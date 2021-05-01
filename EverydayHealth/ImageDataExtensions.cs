using System;
using System.Collections.Generic;
using EverydayHealthData;

namespace EverydayHealth
{
    public static class ImageDataExtensions
    {
        public static ImageData GetImageData(this ImageData imageData, int id, IDictionary<int, ImageData> cache)
        {
            try
            {
                if (!cache.TryGetValue(id, out var image))
                {
                    image = imageData.GetImageById(id);
                    cache[image.Id] = image;
                }

                return image;
            }
            catch (InvalidOperationException)
            {
                return default;
            }
        }

        public static string ToImageTagOrEmpty(this ImageData imageData)
        {
            return imageData is null ? string.Empty : $"<img src={imageData.src} alt={imageData.alt}>";
        }
    }
}
