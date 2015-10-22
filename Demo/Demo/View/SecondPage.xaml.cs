using Demo.ViewModel;
using Xamarin.Forms;

namespace Demo.View
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.BindingContext = new SecondViewModel();
        }
    }
}