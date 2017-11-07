using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageMaesterDetail.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MaesterDetailView : MasterDetailPage
    {
        public MaesterDetailView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            App.Master = this;
            App.Navigator = Navigator;
        }
    }
}