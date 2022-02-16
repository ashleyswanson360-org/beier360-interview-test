using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace InterviewApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string _platformString = "";
        public string PlatformString
        {
            get => _platformString;
            set => SetProperty(ref _platformString, value);
        }

        public ICommand UpdateCommand  { get; }
        public ICommand OpenWebCommand { get; }

        public AboutViewModel()
        {
            Title = "About";

            UpdateCommand  = new Command(Update);
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        private void Update()
        {
            PlatformString = Platform.GetPlatformSpecificString();
        }
    }
}