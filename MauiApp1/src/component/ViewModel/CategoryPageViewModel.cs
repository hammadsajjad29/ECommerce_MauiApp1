using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public class CategoryPageViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public ICommand ProductTappedCommand { get; private set; }

        public CategoryPageViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Product 1", Description = "This is an awesome product.", Price = 19.99M, Image = "product1.jpeg" },
                new Product { Name = "Product 2", Description = "This product is even better.", Price = 29.99M, Image = "product2.jpeg" },
                new Product { Name = "Product 3", Description = "High quality and affordable.", Price = 39.99M, Image = "product3.jpeg" }
            };

            ProductTappedCommand = new Command<Product>(OnProductTapped);
        }

        private async void OnProductTapped(Product tappedProduct)
        {
            // Navigate to the ProductDetailPage with the tapped product
            await Application.Current.MainPage.Navigation.PushAsync(new ProductDetailPage(tappedProduct));
        }
    }
}
