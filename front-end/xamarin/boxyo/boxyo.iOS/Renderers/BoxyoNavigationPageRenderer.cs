using System;
using boxyo.Controls;
using boxyo.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BoxyoNavigationPage), typeof(BoxyoNavigationPageRenderer))]
namespace boxyo.iOS.Renderers
{
    public class BoxyoNavigationPageRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var att = new UITextAttributes();
                att.Font = UIFont.FromName("BMHANNAAir", 25);
                UINavigationBar.Appearance.SetTitleTextAttributes(att);

                //UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                //if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
                //{
                //    statusBar.BackgroundColor = UIColor.Black;
                //}
            }
        }
    }
}
