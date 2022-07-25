using NS.SOLID.DIP.Solution.Interfaces;

namespace NS.SOLID.DIP.Solution
{
    public class Product
    {
        private readonly IProductValidation _productValidation;
        public Product(IProductValidation productValidation)
        {
            _productValidation = productValidation;
        }

        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Name { get; set; }
        public string CustomerEmail { get; set; }
        public decimal Price { get; set; }

        public bool IsValid()
        {
            return _productValidation.IsValid(this);
        }
    }
}
