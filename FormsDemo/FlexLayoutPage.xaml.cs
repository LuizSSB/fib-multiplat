using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsDemo
{
    public partial class FlexLayoutPage : ContentPage
    {
        public FlexLayoutPage()
        {
            InitializeComponent();

            foreach (var hue in System.Linq.Enumerable.Range(0, 360)) {
                var boxView = new BoxView
                {
                    WidthRequest = 43,
                    HeightRequest = 43,
                    BackgroundColor = Color.FromHsla(
                        (float)hue / 360.0, 1, .5
                    )
                };
                Container.Children.Add(boxView);
            }
        }
    }
}
