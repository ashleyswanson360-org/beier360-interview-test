using Xamarin.Forms;
using InterviewApp.Models;
using InterviewApp.Services;
using InterviewApp.Interfaces;

namespace InterviewApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if ADVANCED
            DependencyService.Register<IDataStore<Item>, SqliteDataStore>();
#else
            DependencyService.Register<IDataStore<Item>, MockDataStore>();
#endif

            MainPage = new AppShell();
        }
    }
}
