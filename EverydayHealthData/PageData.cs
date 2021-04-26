using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EverydayHealthData
{
    /// <summary>
    /// PageData return prepopulated data for the given page.
    /// </summary>
    public sealed class PageData
    {

        public string HeaderData { get; set; }

        public IEnumerable<(string, DateTime)> Content { get; set; }

        public string FooterData { get; set; }


        public PageData GetPageData()
        {
            return
                new PageData
                {
                    HeaderData = "ImageID:1<div>Everyday Health</div>",
                    Content = new List<(string, DateTime)>
                    {
                        ("ImageID:2<div class=\"contentHead\">Mobile App May Help Catch Silent Atrial Fibrillation in High-Risk, Underserved Populations</div>", new DateTime(2019,1,1)),
                        ("ImageID:3<div class=\"contentHead\">8 Laundry Tips for People With Eczema</div>", new DateTime(2017,10,10)),
                        ("ImageID:4<div class=\"contentHead\">Track the Vax: Buyer Beware: Fighting COVID-19 Vaccine Fraud</div>", new DateTime(2020,3,15)),
                        ("ImageID:5<div class=\"contentHead\">Track the Vax: Understanding the Reasons for COVID-19 Vaccine Hesitancy</div>", new DateTime(2020,5,1)),
                        ("ImageID:6<div class=\"contentHead\">Newly Approved MS Drug Ponvory Reduces Fatigue, Study Shows</div>", new DateTime(2019,11,9)),

                    },

                    FooterData = "<div>© 1996-2021 Everyday Health, Inc. Everyday Health is among the federally registered trademarks of Everyday Health, Inc. and may not be used by third parties without explicit permission.</div>",

                };               

        }

    }




}
