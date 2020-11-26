using System;
using CloneRappiUI.iOS.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly:ExportRenderer(typeof(Entry),typeof(CustomEntryRenderer))]
namespace CloneRappiUI.iOS.Controls
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer()
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                Control.Layer.CornerRadius = 0;
                Control.BorderStyle = UIKit.UITextBorderStyle.None;
                Control.Layer.BorderWidth = 0;
                Control.ClipsToBounds = false;
            }
        }
    }
}
