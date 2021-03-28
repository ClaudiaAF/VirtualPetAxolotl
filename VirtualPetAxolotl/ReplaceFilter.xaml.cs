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
    public partial class ReplaceFilter : ContentPage
    {
        public ReplaceFilter()
        {
            InitializeComponent();
        }

        async void backToDashboard(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Dashboard());
        }

        
    }
}