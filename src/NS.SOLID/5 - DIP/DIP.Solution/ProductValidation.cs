using NS.SOLID.DIP.Solution.Interfaces;

namespace NS.SOLID.DIP.Solution
{
    public class ProductValidation : IProductValidation
    {
        private readonly IEmailService _emailService;
        public ProductValidation(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public bool IsValid(Product product)
        {
            return _emailService.IsValid(product.CustomerEmail) 
                && NameIsValid(product.Name)
                && PriceIsValid(product.Price);
        }

        private bool NameIsValid(string name)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name);
        }

        private bool PriceIsValid(decimal price)
        {
            return price > 0 && price < 1000;
        }
    }
}
