using System;
using Xamarin.Forms;
using MvvmHelpers;
using InterviewApp.Views;

namespace InterviewApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage),    typeof(NewItemPage));
        }

        private void OnMenuItemClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//LoginPage").SafeFireAndForget();
        }
    }
}
