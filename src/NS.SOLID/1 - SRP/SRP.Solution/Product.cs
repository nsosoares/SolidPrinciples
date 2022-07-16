namespace NS.SOLID.SRP.Solution
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
            return ProductValidation.IsValid(this);
        }
    }
}
