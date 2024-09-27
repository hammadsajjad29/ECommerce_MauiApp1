namespace MauiApp1
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public string SelectedColor { get; set; }
        public string SelectedSize { get; set; }

        // Default quantity to 1 if not specified
        private int _selectedQuantity = 1;
        public int SelectedQuantity
        {
            get => _selectedQuantity;
            set => _selectedQuantity = value < 1 ? 1 : value; // Ensure it doesn't go below 1
        }

    }
}
