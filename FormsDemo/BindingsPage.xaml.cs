using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsDemo
{
    public partial class BindingsPage : ContentPage
    {
        async void Handle_Back(
            object sender, EventArgs e
        ) {
            await Navigation.PopAsync();
        }
        public BindingsPage()
        {
            InitializeComponent();
            RotationXSlider
                .BindingContext =
                    MainLabel;
            RotationXSlider.SetBinding(
                Slider.ValueProperty,
                "RotationX",
                BindingMode.OneWayToSource
            );
        }
    }
}
