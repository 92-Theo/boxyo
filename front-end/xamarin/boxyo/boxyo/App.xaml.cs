using Xamarin.Forms;
using boxyo.Controls;

namespace boxyo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new BoxyoNavigationPage(new Views.Sign.SignInView());
            //MainPage = new NavigationPage(new Views.Sign.SignInView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
