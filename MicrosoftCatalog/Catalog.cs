using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MicrosoftCatalog
{
    public class Catalog
    {
        private readonly Item[] items;
        int currentIndex = 0;
        public Catalog()
        {
            items = SeedItems();
        }

        private Item[] SeedItems()
        {
            var seedItems = new Item[]
            {
                new Item()
                {
                    Title = "Microsoft Azure",
                    Description = "Microsoft Azure is a cloud computing platform and infrastructure, created by Microsoft, for building, deploying and managing applications and services through a global network of Microsoft-managed and Microsoft partner hosted datacenters.",
                    Image = Resource.Drawable.img1
                }
                ,
                                new Item()
                {
                    Title = "Imagine Cup",
                    Description = "Imagine Cup is an annual competition sponsored and hosted by Microsoft Corp. which brings together young technologists worldwide to help resolve some of the world's toughest challenges.",
                    Image = Resource.Drawable.img2,
                },
                new Item()
                {
                    Title = "PowerBI",
                    Description = "Power BI is a cloud-based business analytics service that enables anyone to visualize and analyze data with greater speed, efficiency, and understanding.",
                    Image = Resource.Drawable.img3
                },
                new Item()
                {
                    Title = "Visual Studio",
                    Description ="Microsoft Visual Studio is an integrated development environment (IDE) from Microsoft. It is used to develop computer programs for Microsoft Windows, as well as web sites, web applications and web services. Visual Studio uses Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, Windows Store and Microsoft Silverlight. It can produce both native code and managed code.",
                    Image = Resource.Drawable.img4
                }
            };
            return seedItems;
        }

        public void MoveFirst()
        {
            currentIndex = 0;
        }

        public void MovePrev()
        {
            if (currentIndex > 0)
                --currentIndex;
        }

        public void MoveNext()
        {
            if (currentIndex < items.Length - 1)
                ++currentIndex;
        }

        public Item Current
        {
            get { return items[currentIndex]; }
        }
    }
}