using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;
            string confirmPassword = ConfirmPasswordEntry.Text;

            if (password == confirmPassword && !string.IsNullOrEmpty(username))
            {
                // Placeholder for actual sign-up logic
                await DisplayAlert("Sign Up", "Sign up successful!", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Error", "Passwords do not match or username is empty", "OK");
            }
        }
    }
}

