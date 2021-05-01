using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using EverydayHealthData;

namespace EverydayHealth
{
    public class PageFacade
    {
        private readonly PageData _pageData;
        private readonly LineTreater _treater;

        public PageFacade(PageData pageData, LineTreater treater)
        {
            _pageData = pageData;
            _treater = treater;
        }

        public string[] GetPageLines()
        {
            var page = _pageData.GetPageData();
            var contentLines = page.Content
                                   .OrderByDescending(tuple => tuple.Item2)
                                   .Select(content => _treater.Treat(content.Item1));

            return new[]
                   {
                       _treater.Treat(page.HeaderData),
                   }
                   .Concat(contentLines)
                   .Concat(new[] { page.FooterData })
                   .ToArray();
        }
    }
}