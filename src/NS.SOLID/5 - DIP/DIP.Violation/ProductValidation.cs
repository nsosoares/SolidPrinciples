namespace NS.SOLID.DIP.Violation
{
    public class ProductValidation
    {
        public static bool IsValid(Product product)
        {
            /*
                This class is coupled to email services
             */
            return EmailService.IsValid(product.CustomerEmail) 
                && NameIsValid(product.Name)
                && PriceIsValid(product.Price);
        }

        private static bool NameIsValid(string name)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrWhiteSpace(name);
        }

        private static bool PriceIsValid(decimal price)
        {
            return price > 0 && price < 1000;
        }
    }
}
