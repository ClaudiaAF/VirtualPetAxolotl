﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /*public void OnDrop(object sender, DropEventArgs e)
        {
            RestartReplaceFilterTimer();

            axolotl.replaceFitler();

            updateFilterUI();

        }*/
    }
}