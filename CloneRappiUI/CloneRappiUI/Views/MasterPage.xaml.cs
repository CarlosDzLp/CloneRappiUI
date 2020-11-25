using System;
using System.Collections.Generic;
using CloneRappiUI.ViewModels;
using Xamarin.Forms;

namespace CloneRappiUI.Views
{
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
            this.BindingContext = new MasterPageViewModel();
        }
    }
}
