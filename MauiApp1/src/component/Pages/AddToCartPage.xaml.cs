using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp1
{
    public partial class AddToCartPage : ContentPage
    {
        public ObservableCollection<Product> CartItems { get; set; }
        public ICommand RemoveFromCartCommand { get; set; }
        public ICommand PlaceOrderCommand { get; set; }
        public ICommand AddMoreProductsCommand { get; set; }

        public decimal TotalAmount => CartService.Instance.TotalAmount;

        public AddToCartPage()
        {
            InitializeComponent();

            CartItems = CartService.Instance.CartItems;

            RemoveFromCartCommand = new Command<Product>(RemoveFromCart);
            PlaceOrderCommand = new Command(PlaceOrder);
            AddMoreProductsCommand = new Command(NavigateToProductSelection);

            BindingContext = this;
        }

        private void RemoveFromCart(Product product)
        {
            if (product != null && CartItems.Contains(product))
            {
                CartService.Instance.RemoveFromCart(product);
                OnPropertyChanged(nameof(TotalAmount)); // Refresh total amount
            }
        }

        private async void PlaceOrder()
        {
            if (CartItems.Count > 0)
            {
                DisplayAlert("Order Placed", "Your order has been placed successfully!", "OK");
                CartService.Instance.ClearCart();
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                DisplayAlert("Cart Empty", "Your cart is empty. Please add items to the cart.", "OK");
            }
        }

        public void AddToCart(Product product)
        {
            if (product != null)
            {
                CartService.Instance.AddToCart(product);
                OnPropertyChanged(nameof(TotalAmount)); // Refresh total amount
            }
        }

        private async void NavigateToProductSelection()
        {
            await Navigation.PushAsync(new CategoryPage());
        }
    }
}
