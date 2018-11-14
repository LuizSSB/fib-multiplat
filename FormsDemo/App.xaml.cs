using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace FormsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MasterPage master =
                MyMasterDetailPage.Master
                    as MasterPage;
            master.PageSelected +=
                (sender, page) =>
                {
                    MyMasterDetailPage
                        .Detail = page;
                    MyMasterDetailPage.IsPresented = false;
                };
            MyMasterDetailPage.Detail = master.SelectedPage;
        }
    }
}
