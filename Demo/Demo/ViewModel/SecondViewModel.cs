using Demo.Service;
using Xamarin.Forms;

namespace Demo.ViewModel
{
    public class SecondViewModel : BaseViewModel
    {
        string _langCode = "";

        public SecondViewModel()
        {
            ILangService langService = DependencyService.Get<ILangService>();

            this.LangCode = string.Format("Twój język to: {0}", langService.GetLangCode());
        }

        public string LangCode
        {
            set
            {
                if (_langCode != value)
                {
                    _langCode = value;
                    OnPropertyChanged();
                }
            }
            get
            {
                return _langCode;
            }
        }
    }
}