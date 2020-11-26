using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using CloneRappiUI.Models;
using CloneRappiUI.ViewModels.Base;
using Xamarin.Forms;

namespace CloneRappiUI.ViewModels
{
    public class MasterPageViewModel : BindableBase
    {
        #region Properties
        public ObservableCollection<CategoryModel> ListCategory { get; set; }
        public ObservableCollection<ProductModel> ListProduct { get; set; }
        #endregion

        #region Constructor
        public MasterPageViewModel()
        {
            LoadCategory();
            LoadProduct();
            SendBasketCommand = new Command(SendBasketCommandExecuted);
        }
        #endregion

        #region Command
        public ICommand SendBasketCommand { get; set; }
        #endregion

        #region CommandExecuted
        private void SendBasketCommandExecuted()
        {
            try
            {
                App.Current.MainPage.Navigation.PushModalAsync(new Views.MyBasketPage());
            }
            catch(Exception ex)
            {

            }
        }

        public void SelectedItemProduct(ProductModel product)
        {
            try
            {
                if(!product.IsCategory)
                    App.Current.MainPage.Navigation.PushAsync(new Views.DetailPage(product));
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #region Methods
        private void LoadCategory()
        {
            try
            {
                ListCategory = new ObservableCollection<CategoryModel>();
                ListCategory.Add(new CategoryModel
                {
                    TextColor = Color.White,
                    BackgroundColor = Color.FromHex("#582D86"),
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
            catch(Exception ex)
            {

            }
        }

        public void ResetCategory(CategoryModel category)
        {
            try
            {
                foreach(var item in ListCategory)
                {
                    if(item.Id == category.Id)
                    {
                        item.BackgroundColor = Color.FromHex("#582D86");
                        item.TextColor = Color.White;
                    }
                    else
                    {
                        item.BackgroundColor = Color.White;
                        item.TextColor = Color.FromHex("#CED2D9");
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        public void LoadProduct()
        {
            try
            {
                ListProduct = new ObservableCollection<ProductModel>();
                ListProduct.Clear();
                ListProduct.Add(new ProductModel
                {
                    IsCategory = true,
                    IsDiscount = false,
                    Id = 0,
                    Name = "Pizza"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 1,
                    IsCategory = false,
                    IsDiscount = false,
                    Name = "Pizza Grande",
                    Price = "$200",
                    Url = "pizza1.jpg",
                    Discount = "10%"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 2,
                    IsCategory = false,
                    IsDiscount = true,
                    Name = "Pizza Mediana",
                    Price = "$150",
                    Url = "pizza2.jpg",
                    Discount = "10%"
                });


                ListProduct.Add(new ProductModel
                {
                    IsCategory = true,
                    IsDiscount = false,
                    Id = 1,
                    Name = "Frutas"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 3,
                    IsCategory = false,
                    IsDiscount = true,
                    Name = "Sandia y melon",
                    Price = "$200",
                    Url = "cosecha1.jpeg",
                    Discount = "15%"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 4,
                    IsCategory = false,
                    IsDiscount = true,
                    Name = "Manzanas",
                    Price = "$150",
                    Url = "cosecha2.jpg",
                    Discount = "30%"
                });

                ListProduct.Add(new ProductModel
                {
                    IsCategory = true,
                    IsDiscount = false,
                    Id = 2,
                    Name = "Burguer"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 5,
                    IsCategory = false,
                    IsDiscount = true,
                    Name = "Hamburguesa",
                    Price = "$200",
                    Url = "hamburguer1.jpg",
                    Discount = "20%"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 6,
                    IsCategory = false,
                    IsDiscount = false,
                    Name = "Hamburguesa Grande",
                    Price = "$250",
                    Url = "hamburguer2.jpg"
                });

                ListProduct.Add(new ProductModel
                {
                    IsCategory = true,
                    IsDiscount = false,
                    Id = 3,
                    Name = "Sandwich"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 7,
                    IsCategory = false,
                    IsDiscount = true,
                    Name = "Sandwich Mediano",
                    Price = "$200",
                    Url = "sandwich1.jpg",
                    Discount = "32%"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 8,
                    IsCategory = false,
                    IsDiscount = false,
                    Name = "Sandwich Grande",
                    Price = "$250",
                    Url = "sandwich2.jpg"
                });

                ListProduct.Add(new ProductModel
                {
                    IsCategory = true,
                    IsDiscount = false,
                    Id = 4,
                    Name = "Sushi"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 9,
                    IsCategory = false,
                    IsDiscount = false,
                    Name = "Sushi Mediano",
                    Price = "$200",
                    Url = "sushi1.jpg"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 10,
                    IsCategory = false,
                    IsDiscount = true,
                    Name = "Sushi Grande",
                    Price = "$250",
                    Url = "sushi2.jpg",
                    Discount = "10%"
                });

                ListProduct.Add(new ProductModel
                {
                    IsCategory = true,
                    IsDiscount = false,
                    Id = 5,
                    Name = "Tacos"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 11,
                    IsCategory = false,
                    IsDiscount = false,
                    Name = "Tacos Mediano",
                    Price = "$200",
                    Url = "tacos1.jpg"
                });
                ListProduct.Add(new ProductModel
                {
                    Description = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. ",
                    Id = 12,
                    IsCategory = false,
                    IsDiscount = true,
                    Name = "Tacos Grande",
                    Price = "$250",
                    Url = "tacos2.jpg",
                    Discount = "20%"
                });
            }
            catch(Exception ex)
            {

            }
        }
        #endregion
    }
}
