using Demo.ViewModel;
using Xamarin.Forms;

namespace Demo.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = new MainViewModel();
        }
    }
}