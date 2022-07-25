using NS.SOLID.DIP.Solution.Interfaces;

namespace NS.SOLID.DIP.Solution
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IEmailService _emailService;
        public ProductService(IProductRepository productRepository, IEmailService emailService)
        {
            _productRepository = productRepository;
            _emailService = emailService;
        }

        public string AddProduct(Product product)
        {
            if (!product.IsValid())
                return "";

            _productRepository.AddProduct(product);

            _emailService.Send(
                "nsosoares@nsosoares.com"
                , product.CustomerEmail
                , "Product purchased"
                , "Congratulations! The product was successfully purchased");

            return "Product successfully purchased";
        }
    }
}
