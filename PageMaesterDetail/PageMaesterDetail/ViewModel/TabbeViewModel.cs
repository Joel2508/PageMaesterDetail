using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMaesterDetail.ViewModel
{
    public class TabbeViewModel
    {

        public string Autor { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public TabbeViewModel()
        {
            LoadHome();
        }

        private void LoadHome()
        {
            Autor = "Joel Arias";
            Title = "Building Cross Platform Apps with Xamarin Part1";

            Description = "Learn how to use Xamarin to leverage your" +
                          "skillis in Microsoft Visual Studio and C# to build cross" +
                          "-platform apps that run on both android and IOS.";
        }

    }
}
