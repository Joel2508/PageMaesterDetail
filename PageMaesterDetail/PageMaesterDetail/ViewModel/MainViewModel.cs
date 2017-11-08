using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageMaesterDetail.ViewModel
{
    public class MainViewModel
    {

        #region Propeties
        public HomeViewModel Home { get; set; }
        public Xamarinpart2ViewModel Xamarinpart2 { get; set; }
        public AndroidForViewModel AndroidFor { get; set; }
        public TabbeViewModel Tabbe { get; set; }
        public CarouselViewModel Carousel { get; set; }
        #endregion

        #region Observable
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<FollowingViewModel> FollowingItem { get; set; }
        #endregion


        #region Contructor
        public MainViewModel()
        {
            Home = new HomeViewModel();
            Xamarinpart2 = new Xamarinpart2ViewModel();
            AndroidFor = new AndroidForViewModel();
            Tabbe = new TabbeViewModel();
            Carousel = new CarouselViewModel();
            LoadMenu();
            FollowingLoad();
        }

        #endregion

        #region Singleton
        private static MainViewModel intance;
        public static MainViewModel GetIntance()
        {
            if (intance == null)
            {
                intance = new MainViewModel();
            }
            return intance;
        }
        #endregion

        #region Method
        private void FollowingLoad()
        {
            FollowingItem = new ObservableCollection<FollowingViewModel>();
            FollowingItem.Add(new FollowingViewModel
            {
                Author = "Joel Arias",
                Title = "Building Cross Platform App Xamarin part 1",
                Description = "Learn how to use Xamarin to leverage your" +
                          "skillis in Microsoft Visual Studio and C# to build cross" +
                          "-platform apps that run on both android and IOS.",

            });
            FollowingItem.Add(new FollowingViewModel
            {
                Author = "Joel Arias",
                Title = "Building Cross Platform App Xamarin part 2",
                Description = "Learn how to use Xamarin to leverage your" +
                          "skillis in Microsoft Visual Studio and C# to build cross" +
                          "-platform apps that run on both android and IOS.",
            });
            FollowingItem.Add(new FollowingViewModel
            {
                Author = "Joel Arias",
                Title = "Building Google Glass Apps With C# and Xamarin",
                Description = "Learn to developer apps for Google Glass with and Xamarin" +
                             "by building a full-featured Scavenger Hunt game using the Xamarin" +
                             "Glass Development Kit component."
            });
            FollowingItem.Add(new FollowingViewModel
            {
                Author = "Joel Arias",
                Title = "Android for .NET Developers",
                Description = "Learn to developer apps for Google Glass with and Xamarin" +
                             "by building a full-featured Scavenger Hunt game using the Xamarin" +
                             "Glass Development Kit component."
            });

        }
        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_shortcut_keyboard_tab.png",
                Title = "Following",
                View = "FollowingView",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_shortcut_play_arrow.png",
                Title = "Xamarin part 2",
                View = "Xamarinpart2View",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_shortcut_last_page.png",
                Title = "Android for .net",
                View = "AndroidForView",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_shortcut_playlist_add_check.png",
                Title = "Tabbed page",
                View = "TabbeView",
            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_shortcut_star_border.png",
                Title = "Carousel",
                View = "CarouselView",
            });
        }
        #endregion

    }
}
