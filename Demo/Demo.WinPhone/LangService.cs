using Demo.Service;
using Xamarin.Forms;

[assembly: Dependency(typeof(Demo.WinPhone.LangService))]
namespace Demo.WinPhone
{
    public class LangService : ILangService
    {
        public string GetLangCode()
        {
            return System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        }
    }
}