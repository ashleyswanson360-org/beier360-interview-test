using Xamarin.Forms;
using MvvmHelpers;
using InterviewApp.Views;

namespace InterviewApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
        }

        private void Login()
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            Shell.Current.GoToAsync($"//{nameof(AboutPage)}").SafeFireAndForget();
        }
    }
}
