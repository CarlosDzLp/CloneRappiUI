using System;
namespace CloneRappiUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCategory { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public bool IsDiscount { get; set; }
        public string Url { get; set; }
        public string Discount { get; set; }
    }
}
