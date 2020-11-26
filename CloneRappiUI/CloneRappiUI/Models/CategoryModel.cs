using System;
using Xamarin.Forms;
using CloneRappiUI.ViewModels.Base;

namespace CloneRappiUI.Models
{
    public class CategoryModel : BindableBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Count { get; set; }
        public Color BackgroundColor { get; set; }
        public Color TextColor { get; set; }
    }
}
