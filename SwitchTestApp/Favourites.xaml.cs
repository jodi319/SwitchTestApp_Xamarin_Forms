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
        public bool isOn { get; set; }
        public Favourites()
        {
            InitializeComponent();
        }

        void isOn1(object sender, ToggledEventArgs e)
        {
            //lbldisp.Text = "Switch Status is " + e.Value.ToString();
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch2_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch3_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch4_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch5_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch6_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch7_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch8_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch9_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch10_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch11_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }

        private void Switch12_OnToggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Switch Status is " + e.Value.ToString(), "OK");
        }
    }
}