using System;
using System.Collections.Generic;
using CloneRappiUI.ViewModels;
using Xamarin.Forms;

namespace CloneRappiUI.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
            this.BindingContext = new DetailPageViewModel();
        }
    }
}
