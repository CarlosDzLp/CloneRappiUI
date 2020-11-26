using System;
using System.Collections.Generic;
using CloneRappiUI.ViewModels;
using Xamarin.Forms;

namespace CloneRappiUI.Views
{
    public partial class MyBasketPage : ContentPage
    {
        public MyBasketPage()
        {
            InitializeComponent();
            this.BindingContext = new MyBasketPageViewModel();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.PopModalAsync(true);
        }
    }
}
