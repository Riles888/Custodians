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

        private void HomePage_Clicked(object sender, EventArgs eventArgs)
        {
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
