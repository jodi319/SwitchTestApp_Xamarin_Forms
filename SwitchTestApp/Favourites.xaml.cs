using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwitchTestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favourites : ContentPage
    {
        public Favourites()
        {
            InitializeComponent();
            //DisplayAlert("Alert", "Start " , "OK");
            //switch02.IsToggled = true;
            //switch03.IsToggled = true;
            //switch04.IsToggled = true;
        }

        private void Switches_OnToggled(object sender, ToggledEventArgs e)
        {
            //DisplayAlert("Alert", switch03.ClassId + " Status is " + e.Value.ToString(), "OK");
            LblStatus.Text = LblStatus.Text + ", " + ((Switch)sender).ClassId + " = " + e.Value.ToString();
        }
    }
}