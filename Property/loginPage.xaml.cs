using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Property
{
    public partial class loginPage : ContentPage
    {
        public loginPage()
        {
            InitializeComponent();
        }
        private void Settings_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new settingsPage());
        }
    }
}
