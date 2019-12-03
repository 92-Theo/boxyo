using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace boxyo.Views.Login
{
    /// <summary>
    /// Select login way (google, kakaotalk, naver, others)
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectLoginView : ContentPage
    {
        public SelectLoginView()
        {
            InitializeComponent();
        }
    }
}
