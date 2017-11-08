namespace PageMaesterDetail.ViewModel
{
    using GalaSoft.MvvmLight.Command;
    using PageMaesterDetail.Service;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class MenuItemViewModel
    {

        #region Service
        private NavigationService navigationService;
        #endregion

        #region Properties
        public string Icon { get; set; }
        public string Title { get; set; }
        public string View { get; set; }
        #endregion

        #region Constructor
        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }
        #endregion

        public ICommand NavigateCommand { get { return new RelayCommand(Navigate); } }

        private async void Navigate()
        {

            var mainViewModel = MainViewModel.GetIntance();
            switch (View)
            {
                case "FollowingView":
                    mainViewModel.FollowingItem = new ObservableCollection<FollowingViewModel>();
                    await navigationService.Navigation(View);
                    break;
                case "Xamarinpart2View":
                    mainViewModel.Xamarinpart2 = new Xamarinpart2ViewModel();
                    await navigationService.Navigation(View);
                    break;
                case "AndroidForView":
                    mainViewModel.AndroidFor = new AndroidForViewModel();
                    await navigationService.Navigation(View);
                    break;
                case "TabbeView":
                    mainViewModel.Tabbe = new TabbeViewModel();
                    await navigationService.Navigation(View);
                    break;
                case "CarouselView":
                    mainViewModel.Carousel = new CarouselViewModel();
                    await navigationService.Navigation(View);
                    break;

            }
        }
    }
}
