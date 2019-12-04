using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace boxyo.ViewModels
{
    public class SignInViewModel : ViewModelBase
    {
        private bool isControlEnable = true;

        public ICommand SignInCommand { get; private set; }
        public ICommand SignInWithGoogleCommand { get; private set; }
        public ICommand SignInWithKakaoCommand { get; private set; }
        public ICommand SignInWithNaverCommand { get; private set; }
        public ICommand SignInWithEmailCommand { get; private set; }

        public SignInViewModel()
        {
            SignInCommand = new Command(async () => await SignIn("Normal"), () => IsControlEnable);
        }

        public bool IsControlEnable
        {
            get => isControlEnable;
            set => SetProperty(ref this.isControlEnable, value);
        }

        private async Task SignIn(string val)
        {
            bool result;
            IsBusy = true;
            IsControlEnable = false;
            (SignInCommand as Command).ChangeCanExecute();


            result = await Task.Run(() => SignInProcess());

            if (result)
            {
                Application.Current.MainPage.Navigation.InsertPageBefore(new Views.HomeView(), Application.Current.MainPage.Navigation.NavigationStack.Last());
                await Application.Current.MainPage.Navigation.PopAsync();
            }

            IsControlEnable = true;
            (SignInCommand as Command).ChangeCanExecute();
            IsBusy = false;
        }

        private bool SignInProcess()
        {
            // Simulate a 5 second pause
            Thread.Sleep(1000);
            //db연결

            return true;

            //var endTime = DateTime.Now.AddSeconds(5);
            //while (true)
            //{
            //    if (DateTime.Now >= endTime)
            //    {
            //        break;
            //    }
            //}
        }

    }
}
