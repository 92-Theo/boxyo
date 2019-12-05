using System;
using Android.Graphics;
using Android.OS;
using Android.Views;
using boxyo.Controls;
using boxyo.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(BoxyoNavigationPage), typeof(BoxyoNavigationPageRenderer))]
namespace boxyo.Droid.Renderers
{
    [Obsolete]
    public class BoxyoNavigationPageRenderer : NavigationPageRenderer
    {
        private Android.Support.V7.Widget.Toolbar toolbar;

        public override void OnViewAdded(Android.Views.View child)
        {
            base.OnViewAdded(child);
            if (child.GetType() == typeof(Android.Support.V7.Widget.Toolbar))
            {
                toolbar = (Android.Support.V7.Widget.Toolbar)child;
                toolbar.ChildViewAdded += Toolbar_ChildViewAdded;
            }
            
        }

        private void Toolbar_ChildViewAdded(object sender, ChildViewAddedEventArgs e)
        {
            var view = e.Child.GetType();
            if (e.Child.GetType() == typeof(Android.Support.V7.Widget.AppCompatTextView))
            {
                var textView = (Android.Widget.TextView)e.Child;
                // Title Font
                var spaceFont = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "BMHANNAAir.ttf");
                textView.Typeface = spaceFont;
                textView.TextSize = 25;
                textView.Gravity = GravityFlags.Center;

                toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
            }
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);
            
            for (int index = 0; index < toolbar.ChildCount; index++)
            {
                if (toolbar.GetChildAt(index) is Android.Support.V7.Widget.AppCompatTextView)
                {
                    var title = toolbar.GetChildAt(index) as Android.Support.V7.Widget.AppCompatTextView;
                    float toolbarCenter = toolbar.MeasuredWidth / 2;
                    float titleCenter = title.MeasuredWidth / 2;
                    title.SetX(toolbarCenter - titleCenter);
                }
            }
        }
    }
}
