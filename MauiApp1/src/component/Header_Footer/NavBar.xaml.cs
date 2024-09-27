using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class NavBar : ContentView
    {
        public NavBar()
        {
            InitializeComponent();
        }

        private async void OnHomeClicked(object sender, EventArgs e)
        {
            // Navigate to Home Page
            await Navigation.PushAsync(new HomePage());
        }

        private async void OnCategoryClicked(object sender, EventArgs e)
        {
            // Navigate to Category Page
            //await Shell.Current.GoToAsync(new CategoryPage());

            await Navigation.PushAsync(new CategoryPage());
        }

        private async void OnCartClicked(object sender, EventArgs e)
        {
            // Navigate to Cart Page
            await Navigation.PushAsync(new AddToCartPage());
        }
        private void OnUserClicked(object sender, EventArgs e)
        {
            // Handle the user click event here
            // For example, navigate to the account page or show a popup
            // Navigation.PushAsync(new AccountPage());
        }
    }
}
