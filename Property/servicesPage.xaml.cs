using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Property
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class servicesPage : TabbedPage
    {
        public servicesPage()
        {
            InitializeComponent();
        }

        private void Calendar_Clicked(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new calendarPage());
        }
    }
}