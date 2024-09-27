using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public class ProductDetailViewModel : BindableObject
    {
        private Product selectedProduct;
        public Product SelectedProduct
        {
            get => selectedProduct;
            private set
            {
                selectedProduct = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Image));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Description));
                OnPropertyChanged(nameof(Price));
            }
        }

        public string Image => SelectedProduct?.Image;
        public string Name => SelectedProduct?.Name;
        public string Description => SelectedProduct?.Description;
        public decimal Price => (decimal)(SelectedProduct?.Price ?? 0);

        public ObservableCollection<string> AvailableColors { get; set; }
        public ObservableCollection<string> AvailableSizes { get; set; }

        private string selectedColor;
        public string SelectedColor
        {
            get => selectedColor;
            set
            {
                selectedColor = value;
                OnPropertyChanged();
            }
        }

        private string selectedSize;
        public string SelectedSize
        {
            get => selectedSize;
            set
            {
                selectedSize = value;
                OnPropertyChanged();
            }
        }

        private int selectedQuantity;
        public int SelectedQuantity
        {
            get => selectedQuantity;
            set
            {
                selectedQuantity = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddToCartCommand { get; private set; }

        public ProductDetailViewModel(Product product)
        {
            SelectedProduct = product;
            AvailableColors = new ObservableCollection<string> { "Red", "Blue", "Green" };
            AvailableSizes = new ObservableCollection<string> { "S", "M", "L", "XL" };
            SelectedQuantity = 1;

            AddToCartCommand = new Command(AddToCart);
        }

        private void AddToCart()
        {
            if (SelectedProduct != null)
            {
                var productToAdd = new Product
                {
                    Image = SelectedProduct.Image,
                    Name = SelectedProduct.Name,
                    Description = SelectedProduct.Description,
                    Price = SelectedProduct.Price,
                    SelectedColor = SelectedColor,
                    SelectedSize = SelectedSize,
                    SelectedQuantity = SelectedQuantity
                };

                CartService.Instance.AddToCart(productToAdd); // Add to CartService
            }
        }
    }
}
