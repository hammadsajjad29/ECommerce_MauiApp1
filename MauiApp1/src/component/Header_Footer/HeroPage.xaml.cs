using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class HeroPage : ContentPage
    {
        public HeroPage()
        {
            InitializeComponent();
            // Attach event handler
            var startShoppingButton = this.FindByName<Button>("StartShoppingButton"); // Ensure you name the button
            if (startShoppingButton != null)
            {
                startShoppingButton.Clicked += StartShoppingButton_Clicked;
            }
        }

        private async void StartShoppingButton_Clicked(object sender, EventArgs e)
        {
            // Navigate to another page
            await Navigation.PushAsync(new CategoryPage()); // Change to your actual shopping page
        }
    }
}
