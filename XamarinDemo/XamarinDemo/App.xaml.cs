﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.Views;

namespace XamarinDemo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
