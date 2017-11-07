namespace PageMaesterDetail.Infrasctructure
{
    using PageMaesterDetail.ViewModel;

    public class InstanceLocator
    {
        #region Propertie
        public MainViewModel Main { get; set; } 
        #endregion

        #region Constructor
        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
        #endregion
    }
}
