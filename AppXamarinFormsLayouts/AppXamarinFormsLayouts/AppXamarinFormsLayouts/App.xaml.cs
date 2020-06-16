﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamarinFormsLayouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StackLayoutPage();
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
