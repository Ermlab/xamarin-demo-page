using Demo.Service;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(Demo.iOS.LangService))]
namespace Demo.iOS
{
    public class LangService : ILangService
    {
        public string GetLangCode()
        {
            var language = "en";

            if (NSLocale.PreferredLanguages.Length > 0)
            {
                var pref = NSLocale.PreferredLanguages[0];
                language = pref.Replace("_", "-");
            }

            return language;
        }
    }
}