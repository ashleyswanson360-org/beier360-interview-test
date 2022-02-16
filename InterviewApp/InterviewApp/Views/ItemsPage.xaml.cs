using Xamarin.Forms;
using InterviewApp.ViewModels;

namespace InterviewApp.Views
{
    public partial class ItemsPage : ContentPage
    {
        public ItemsViewModel ViewModel => (ItemsViewModel) BindingContext;

        public ItemsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ViewModel.OnAppearing();
        }
    }
}