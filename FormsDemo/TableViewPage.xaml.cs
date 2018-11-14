using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsDemo
{
    public partial class TableViewPage : ContentPage
    {
        public TableViewPage()
        {
            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            DisplayAlert("Alerta", "Salvou", "vlw");
        }
    }
}
