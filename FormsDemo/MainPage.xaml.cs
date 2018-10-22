using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsDemo
{
    public partial class MainPage : ContentPage
    {
        async void Handle_History(
            object sender,
            EventArgs e
        )
        {
            await Navigation.PushAsync(
                new HistoryPage()
            );
        }
        async void Handle_Bindings(
            object sender,
            EventArgs e
        )
        {
            await Navigation.PushModalAsync(
                new BindingsPage()
            );

        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var opener =
                DependencyService
                    .Get<IAppOpener>();

            var confirm = await DisplayAlert(
                "Confirmação",
                "Quer mesmo abrir o app?",
                "Manda ver",
                "Nope"
            );

            if (confirm) {
                AppHistory.AddApp(AppIdEntry.Text);
                opener.OpenApp(
                    AppIdEntry.Text
                );
            }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
