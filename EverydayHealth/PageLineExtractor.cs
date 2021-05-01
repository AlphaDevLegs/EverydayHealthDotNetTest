using System;
using System.Text.RegularExpressions;

namespace EverydayHealth
{
    public class PageLineExtractor
    {
        private static readonly Regex Extractor;

        static PageLineExtractor()
        {
            Extractor = new Regex(@"^ImageID:(?<imageId>\d+)(?<secondPart>.*)", RegexOptions.Compiled);
        }

        public (int imageId, string description) Extract(string line)
        {
            var extractedLine = Extractor.Match(line);
            if (!extractedLine.Success)
            {
                throw new InvalidOperationException($"Invalid header: {extractedLine}");
            }

            return (int.Parse(extractedLine.Groups["imageId"].Value), extractedLine.Groups["secondPart"].Value);
        }
    }
}