using System;
using System.Collections.ObjectModel;
using CloneRappiUI.Models;
using CloneRappiUI.ViewModels.Base;
using Xamarin.Forms;

namespace CloneRappiUI.ViewModels
{
    public class MyBasketPageViewModel : BindableBase
    {
        public ObservableCollection<CategoryModel> ListCategory { get; set; }

        public MyBasketPageViewModel()
        {
            LoadCategory();
        }

        private void LoadCategory()
        {
            try
            {
                ListCategory = new ObservableCollection<CategoryModel>();
                ListCategory.Add(new CategoryModel
                {
                    TextColor = Color.FromHex("#CED2D9"),
                    BackgroundColor = Color.White,
                    Count = 2,
                    Id = 0,
                    Name = "Pizza",
                    Url = "pizzacat"
                });
                ListCategory.Add(new CategoryModel
                {
                    TextColor = Color.FromHex("#CED2D9"),
                    BackgroundColor = Color.White,
                    Count = 2,
                    Id = 1,
                    Name = "Frutas",
                    Url = "cosechacat"
                });
                ListCategory.Add(new CategoryModel
                {
                    TextColor = Color.FromHex("#CED2D9"),
                    BackgroundColor = Color.White,
                    Count = 2,
                    Id = 2,
                    Name = "Burguer",
                    Url = "hamburguercat"
                });
                ListCategory.Add(new CategoryModel
                {
                    TextColor = Color.FromHex("#CED2D9"),
                    BackgroundColor = Color.White,
                    Count = 2,
                    Id = 3,
                    Name = "Sandwich",
                    Url = "sandwichcat"
                });
                ListCategory.Add(new CategoryModel
                {
                    TextColor = Color.FromHex("#CED2D9"),
                    BackgroundColor = Color.White,
                    Count = 2,
                    Id = 4,
                    Name = "Sushi",
                    Url = "sushicat"
                });
                ListCategory.Add(new CategoryModel
                {
                    TextColor = Color.FromHex("#CED2D9"),
                    BackgroundColor = Color.White,
                    Count = 2,
                    Id = 5,
                    Name = "Tacos",
                    Url = "tacoscat"
                });
            }
            catch (Exception ex)
            {

            }
        }
    }
}
