using System;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(FormsDemo.iOS.AppOpener))]
namespace FormsDemo.iOS
{
    public class AppOpener : IAppOpener
    {
        public bool OpenApp(string appId)
        {
            var defaultUrl = new Foundation.NSUrl(appId + "://");
            if (UIApplication.SharedApplication.CanOpenUrl(defaultUrl))
            {
                UIApplication.SharedApplication.OpenUrl(defaultUrl);
                return true;
            }


            UIApplication.SharedApplication.OpenUrl(
                new Foundation.NSUrl("https://www." + appId + ".com")
            );
            return false;
        }
    }
}
