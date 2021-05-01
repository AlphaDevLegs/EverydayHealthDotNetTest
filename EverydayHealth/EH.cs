using EverydayHealthData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace EverydayHealth
{
    class EH
    {
        /// <Goal>
        /// Create and print a Page object from a data source EverydayHealthData.PageData
        /// </Goal>

        /// <Requirements>
        /// Sort the PageData Content so that the latest content it at the top
        /// Replace Content "ImageID:ID" with the image element <img src=<src> alt=<alt>>
        /// Get the image data from the data source EverydayHealthData.ImageData
        /// Incase image data is unavailable it should be replace by an empty string
        /// Image data response is slow. Apply performance improvements for consuming it
        /// PageData.HeaderData and PageData.FooterData never changes
        /// </Requirements>
        

        static void Main(string[] args)
        {
            bool exit;
            var pageFacade = new PageFacade(new PageData(), new LineTreater(new ImageData(), new PageLineExtractor(), new Dictionary<int, ImageData>()));
            
            do
            {
                foreach (var line in pageFacade.GetPageLines())
                {
                    Console.WriteLine(line);
                    Console.WriteLine();
                }

                Console.WriteLine("Continue? (Y/Any Key): ");
                var input = Console.ReadLine();
                exit = !string.Equals("y", input, StringComparison.OrdinalIgnoreCase);
            } while (!exit);
        }
    }
}
