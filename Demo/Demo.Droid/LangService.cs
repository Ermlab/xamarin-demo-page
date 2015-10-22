using Demo.Service;
using Xamarin.Forms;

[assembly: Dependency(typeof(Demo.Droid.LangService))]
namespace Demo.Droid
{
    public class LangService : ILangService
    {
        public string GetLangCode()
        {
            var androidLocale = Java.Util.Locale.Default;

            return androidLocale.ToString().Replace("_", "-").TrimEnd('-');
        }
    }
}