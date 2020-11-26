using System;
using CloneRappiUI.Models;
using CloneRappiUI.Views.Template;
using Xamarin.Forms;

namespace CloneRappiUI.Controls
{
    public class ProductDataTemplate : DataTemplateSelector
    {
        public DataTemplate Category { get; set; }
        public DataTemplate Product { get; set; }
        public DataTemplate ProductDiscount { get; set; }

        public ProductDataTemplate()
        {
            this.Category = new DataTemplate(typeof(CategoryViewTemplate));
            this.Product = new DataTemplate(typeof(ProductViewTemplate));
            this.ProductDiscount = new DataTemplate(typeof(ProductDiscountViewTemplate));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            try
            {
                var data = item as ProductModel;
                if (data == null)
                    return null;
                if (data.IsCategory)
                    return Category;
                else
                {
                    if (data.IsDiscount)
                        return ProductDiscount;
                    else
                        return Product;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
