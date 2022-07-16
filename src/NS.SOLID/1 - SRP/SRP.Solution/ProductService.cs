namespace NS.SOLID.SRP.Solution
{
    public class ProductService 
    {
        public string AddProduct(Product product)
        {
            if (!product.IsValid())
                return "";

            var repo = new ProductRepository();
            repo.AddProduct(product);

            EmailService.Send(
                "nsosoares@nsosoares.com"
                , product.CustomerEmail
                , "Product purchased"
                , "Congratulations! The product was successfully purchased");

            return "Product successfully purchased";
        }
    }
}
