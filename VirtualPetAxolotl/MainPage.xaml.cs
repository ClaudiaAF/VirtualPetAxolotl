using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VirtualPetAxolotl
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void MeetPetClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new EnterNamePage());
        }

    }
}
