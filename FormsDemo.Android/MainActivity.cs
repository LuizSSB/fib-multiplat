﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace FormsDemo.Droid
{
    [Activity(Label = "FormsDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static Android.Content.Context
            AppContext
                { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            AppContext = this;

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(
                this, savedInstanceState
            );
            Xamarin.Essentials.Platform.Init(
                this, savedInstanceState
            );
            LoadApplication(new App());
        }
    }
}