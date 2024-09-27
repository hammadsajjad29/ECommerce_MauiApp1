using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class ProductDetailPage : ContentPage
    {
        public ProductDetailPage(Product product)
        {
            InitializeComponent();
            BindingContext = new ProductDetailViewModel(product);
        }

        private async void OnAddToCartClicked(object sender, EventArgs e)
        {
            if (BindingContext is ProductDetailViewModel viewModel)
            {
                // Add product to CartService's cart
                CartService.Instance.AddToCart(new Product
                {
                    Image = viewModel.Image,
                    Name = viewModel.Name,
                    Description = viewModel.Description,
                    Price = viewModel.Price,
                    SelectedColor = viewModel.SelectedColor,
                    SelectedSize = viewModel.SelectedSize,
                    SelectedQuantity = viewModel.SelectedQuantity
                });

                // Navigate to the cart page
                await Application.Current.MainPage.Navigation.PushAsync(new AddToCartPage());
            }
        }
    }
}
