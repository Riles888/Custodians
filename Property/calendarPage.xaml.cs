using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Property
{
    public partial class calendarPage : ContentPage
    {
        public calendarPage()
        {
            InitializeComponent();
        }

        private void OnPaymentButtonClicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new paymentPage());
        }
    }
}
