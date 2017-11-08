namespace PageMaesterDetail.Service
{
    using PageMaesterDetail.View;
    using System.Threading.Tasks;

    public class NavigationService
    {
        #region Method
        public async Task Navigation(string pageName)
        {
            App.Master.IsPresented = false;
            
            switch (pageName)
            {

                case "FollowingView":
                    await App.Navigator.PushAsync(new FollowingView());
                    break;
                case "Xamarinpart2View":
                    await App.Navigator.PushAsync(new Xamarinpart2View());
                    break;
                case "AndroidForView":
                    await App.Navigator.PushAsync(new AndroidForView());
                    break;
                case "TabbeView":
                    await App.Navigator.PushAsync(new TabbeView());
                    break;
                case "CarouselView":
                    await App.Navigator.PushAsync(new CarouselView());
                    break;
            }
        }
        #endregion

    }
}
