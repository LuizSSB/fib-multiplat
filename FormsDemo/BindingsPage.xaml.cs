using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FormsDemo
{
    public partial class BindingsPage : ContentPage
    {
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
