using MauiApp1;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiApp1
{
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<Product> FeaturedProducts { get; set; }
        public ObservableCollection<Product> BestSellers { get; set; }

        public HomePage()
        {
            InitializeComponent();

            FeaturedProducts = new ObservableCollection<Product>
            {
                new Product { Image = "featured1.jpeg" }, 
                new Product { Image = "featured2.jpeg" },
                new Product { Image = "featured3.jpeg" },
                new Product { Image = "featured2.jpeg" }
            };

            BestSellers = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "Best Seller 1",
                    Description = "This is a description for the best seller.",
                    Price = 19.99M,
                    Image = "bestseller1.jpeg"
                },
                new Product
                {
                    Name = "Best Seller 2",
                    Description = "This is a description for another best seller.",
                    Price = 29.99M,
                    Image = "bestseller2.jpg"
                },
                new Product
                {
                    Name = "Best Seller 3",
                    Description = "This is a description for a third best seller.",
                    Price = 39.99M,
                    Image = "bestseller3.jpeg"
                },
                new Product
                {
                    Name = "Best Seller 4",
                    Description = "This is a description for a third best seller.",
                    Price = 39.99M,
                    Image = "bestseller1.jpeg"
                }
            };

            BindingContext = this;
        }
        private async void StartShoppingButton(object sender, EventArgs e)
        {
            // Navigate to another page
            await Navigation.PushAsync(new CategoryPage());
        }
    }
}
