using Demo.View;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        string _normalText = "";
        string _magicText = "Nie obliczono";

        public MainViewModel()
        {
            this.DoMagicCommand = new Command(() =>
            {
                this.MagicText = string.Format("Magicznie powiększony tekst: {0}", this.NormalText.ToUpperInvariant());
            }, () =>
            {
                return !string.IsNullOrEmpty(this.NormalText);
            });

            this.NextPageCommand = new Command(async () =>
            {
                await App.Navigation.PushAsync(new SecondPage());
            });
        }

        public string NormalText
        {
            set
            {
                if (_normalText != value)
                {
                    _normalText = value;
                    OnPropertyChanged();
                    OnPropertyChanged("NormalTextLength");
                    OnPropertyChanged("NormalTextVisibility");
                    ((Command)this.DoMagicCommand).ChangeCanExecute();
                }
            }
            get
            {
                return _normalText;
            }
        }

        public string NormalTextLength
        {
            get
            {
                return string.Format("Wprowadzono {0} znaków", this.NormalText.Length);
            }
        }

        public bool NormalTextVisibility
        {
            get
            {
                return (this.NormalText.Length > 4);
            }
        }

        public string MagicText
        {
            set
            {
                if (_magicText != value)
                {
                    _magicText = value;
                    OnPropertyChanged();
                }
            }
            get
            {
                return _magicText;
            }
        }

        public ICommand DoMagicCommand { protected set; get; }
        public ICommand NextPageCommand { protected set; get; }
    }
}