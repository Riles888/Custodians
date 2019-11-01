using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Property
{
    public partial class aboutPage : ContentPage
    {
        public aboutPage()
        {
            InitializeComponent();
        }
        private void Settings_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new settingsPage());
        }
    }
}