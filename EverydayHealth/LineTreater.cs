using System.Collections.Generic;
using EverydayHealthData;

namespace EverydayHealth
{
    public class LineTreater
    {
        private readonly ImageData _imageData;
        private readonly PageLineExtractor _extractor;
        private readonly IDictionary<int, ImageData> _cache;

        public LineTreater(ImageData imageData, PageLineExtractor extractor, IDictionary<int, ImageData> cache)
        {
            _imageData = imageData;
            _extractor = extractor;
            _cache = cache;
        }

        public string Treat(string line)
        {
            var extractedDetails = _extractor.Extract(line);
            var image = _imageData.GetImageData(extractedDetails.imageId, _cache);
            return $"{image.ToImageTagOrEmpty()}{extractedDetails.description}";
        }
    }
}
