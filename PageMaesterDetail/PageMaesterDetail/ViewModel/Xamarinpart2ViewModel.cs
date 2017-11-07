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
            Description = "";
        }

     
    }
}
