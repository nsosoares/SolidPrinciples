namespace NS.SOLID.DIP.Violation
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Name { get; set; }
        public string CustomerEmail { get; set; }
        public decimal Price { get; set; }

        public bool IsValid()
        {
            /*
             This class is coupled to ProductValidation
             */
            return ProductValidation.IsValid(this);
        }
    }
}
