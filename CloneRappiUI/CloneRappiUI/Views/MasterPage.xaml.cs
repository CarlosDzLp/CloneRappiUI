using System;
using System.Collections.Generic;
using System.Linq;
using CloneRappiUI.Models;
using CloneRappiUI.ViewModels;
using Xamarin.Forms;

namespace CloneRappiUI.Views
{
    public partial class MasterPage : ContentPage
    {
        MasterPageViewModel master;
        public MasterPage()
        {
            InitializeComponent();
            this.BindingContext = master = new MasterPageViewModel();
        }

        void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            try
            {
                if(e.CurrentSelection.Count > 0)
                {
                    var item = e.CurrentSelection[0] as CategoryModel;
                    if (item == null)
                        return;
                    master.ResetCategory(item);
                    var itemProduct = master.ListProduct.Where(c => c.Id == item.Id && c.IsCategory).FirstOrDefault();
                    var indexProduct = master.ListProduct.IndexOf(itemProduct);
                    collectionViewProduct.ScrollTo(indexProduct, position: ScrollToPosition.Start, animate: true);
                }
            }
            catch(Exception ex)
            {

            }
        }

        void collectionViewProduct_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            try
            {
                if (e.CurrentSelection.Count > 0)
                {
                    var item = e.CurrentSelection[0] as ProductModel;
                    if (item == null)
                        return;
                    ((CollectionView)sender).SelectedItem = null;
                    master.SelectedItemProduct(item);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
