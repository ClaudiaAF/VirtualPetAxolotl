using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualPetAxolotl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnterNamePage : ContentPage
    {
        public EnterNamePage()
        {
            InitializeComponent();
        }

        async void NameSubmit(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Dashboard());
           
        }
    }
}