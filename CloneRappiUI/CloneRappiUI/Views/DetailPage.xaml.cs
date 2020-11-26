using System;
using System.Collections.Generic;
using CloneRappiUI.Models;
using CloneRappiUI.ViewModels;
using Xamarin.Forms;

namespace CloneRappiUI.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(ProductModel product)
        {
            InitializeComponent();
            this.BindingContext = new DetailPageViewModel(product);
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.RemovePage(this);
        }
    }
}
