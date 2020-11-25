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
    }
}
