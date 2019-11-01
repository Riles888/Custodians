using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Property
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SignUp_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new signupPage());
            //this.Frame.Navigate(typeof(AboutPage), null);
        }
        private void Login_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new loginPage());
            //this.Frame.Navigate(typeof(AboutPage), null);
        }
        private void AboutPage_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new aboutPage());
            //this.Frame.Navigate(typeof(AboutPage), null);
        }
    }

    //public static class SharedResources
    //{
    //    public static Color AppBackgroundColor
    //    {
    //        get { return Color.AliceBlue; }
    //    }
    //}
}
