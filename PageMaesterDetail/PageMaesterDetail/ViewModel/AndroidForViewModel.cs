using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMaesterDetail.ViewModel
{
    public class AndroidForViewModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public AndroidForViewModel()
        {
            Title = "Android for .NET Developers";
            Author = "Joel Arias";
            Description = "This course providers and overview of" +
                "the tools used in the Android development process including the"+
                "newly relased Android Studio. Topics are coverd from the perspective of" +
                "someone with .NET experience but are appropriate for anyone whit software" +
                "development experience";        
        }
    }
}
