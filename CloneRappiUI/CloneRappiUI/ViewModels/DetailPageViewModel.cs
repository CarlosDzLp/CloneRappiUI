using System;
using CloneRappiUI.Models;
using CloneRappiUI.ViewModels.Base;

namespace CloneRappiUI.ViewModels
{
    public class DetailPageViewModel : BindableBase
    {
        public ProductModel Product { get; set; }

        public DetailPageViewModel(ProductModel product)
        {
            this.Product = product;
        }
    }
}
