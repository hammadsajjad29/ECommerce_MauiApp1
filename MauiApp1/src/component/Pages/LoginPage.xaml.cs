using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (IsValidLogin(username, password))
            {
                await DisplayAlert("Login", "Login successful!", "OK");
                // Navigate to the main page
                //await Navigation.PushAsync(new CategoryPage());
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Error", "Invalid credentials", "OK");
            }
        }

        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        private bool IsValidLogin(string username, string password)
        {
            // Placeholder for actual login logic
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
    }
}
