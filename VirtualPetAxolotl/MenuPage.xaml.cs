using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetAxolotl.AxolotlSpace;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualPetAxolotl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        async void exit_menu(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Dashboard());
        }

        async void rename_pet(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EnterNamePage());
        }

        async void help_tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HelpPage());
        }

    }
}