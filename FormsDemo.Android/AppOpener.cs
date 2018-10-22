using System;

[assembly: Xamarin.Forms.Dependency(
    typeof(FormsDemo.Droid.AppOpener)
)]
namespace FormsDemo.Droid
{
    public class AppOpener : IAppOpener
    {
        public bool OpenApp(string appId) {
            var context =
                MainActivity.AppContext;

            var launcher = context
                .PackageManager
                .GetLaunchIntentForPackage(appId);

            if (launcher != null)
            {
                context.StartActivity(launcher);
                return true;
            }

            launcher = new Android.Content.Intent(
                Android.Content.Intent.ActionView
            );
            launcher.SetData(Android.Net.Uri.Parse(
                "https://www." + appId + ".com"
            ));
            context.StartActivity(launcher);

            return false;
        }
    }
}
