using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace EverydayHealthData
{

    /// <summary>
    /// ImageData class returns Id, src and alt properties for an image element.
    /// Use ImageData GetImageById(int) to lookup Image data by Id.
    /// </summary>
    public sealed class ImageData
    {
        public int Id { get; set; }
        public string src { get; set; }
        public string alt { get; set; }


        public ImageData GetImageById(int id)
        {          
            return GetData().First(i => i.Id == id);
        }


        private IEnumerable<ImageData> GetData()
        {
            Thread.Sleep(2000); //Simulate slowness

            return new List<ImageData>()
            {
                new ImageData{ Id = 1, src="/images/image1.jpg", alt="image1"},
                new ImageData{ Id = 2, src="/images/image2.jpg", alt="image2"},
                new ImageData{ Id = 3, src="/images/image3.jpg", alt="image3"},
                new ImageData{ Id = 4, src="/images/image4.jpg", alt="image4"},
                new ImageData{ Id = 5, src="/images/image5.jpg", alt="image5"}

            };
        }

    }
}
