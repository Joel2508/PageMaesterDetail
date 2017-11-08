using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMaesterDetail.ViewModel
{
    public class Xamarinpart2ViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public Xamarinpart2ViewModel()
        {
            Author = "Joel Arias";
            Title = "Building Cross Platform App Xamarin part 2";
            Description = "Learn how to use Xamarin to leverage your" +
                      "skillis in Microsoft Visual Studio and C# to build cross" +
                      "-platform apps that run on both android and IOS.";
        }

     
    }
}
