using System.Collections.ObjectModel;

namespace MauiApp1
{
    public class CartService
    {
        private static CartService _instance;
        public static CartService Instance => _instance ??= new CartService();

        public ObservableCollection<Product> CartItems { get; set; } = new ObservableCollection<Product>();
        public decimal TotalAmount => CalculateTotalAmount(); // Add this line

        private CartService()
        {
            CartItems = new ObservableCollection<Product>();
        }

        public void AddToCart(Product product)
        {
            if (product != null)
            {
                // Check if the product with the same name, color, and size already exists in the cart
                var existingProduct = CartItems.FirstOrDefault(p => p.Name == product.Name &&
                                                                    p.SelectedColor == product.SelectedColor &&
                                                                    p.SelectedSize == product.SelectedSize);

                if (existingProduct != null)
                {
                    // If the product exists, only increment the quantity by 1
                    existingProduct.SelectedQuantity += 1; // You can change this logic as needed
                }
                else
                {
                    // If the product doesn't exist, set its quantity to 1 and add it to the cart
                    product.SelectedQuantity = 1;  // Ensure it's 1 by default
                    CartItems.Add(product);
                }
            }
        }

        public void RemoveFromCart(Product product)
        {
            if (CartItems.Contains(product))
            {
                CartItems.Remove(product);
            }
        }

        private decimal CalculateTotalAmount()
        {
            decimal total = 0;
            foreach (var item in CartItems)
            {
                total += item.Price * item.SelectedQuantity;
            }
            return total;
        }

        public void ClearCart()
        {
            CartItems.Clear();
        }
    }
}
