using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
            BindingContext = new CategoryPageViewModel();
        }
    }
}
