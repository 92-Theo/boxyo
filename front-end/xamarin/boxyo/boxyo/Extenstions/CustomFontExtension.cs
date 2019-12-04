using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace boxyo
{
    public class CustomFontExtension : IMarkupExtension
    {
        public string FontFileAndName { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            
            if (Device.RuntimePlatform == Device.Android)
                return FontFileAndName;

            return FontFileAndName.Split(new char[] { '#' })[1];
        }
    }
}
