namespace NS.SOLID.OCP.Solution
{
    public class PaymentCreditCard : Payment
    {
        public int Number { get; set; }
        public string CardholderName { get; set; }
        public int SecurityCode { get; set; }
        public override void Pay()
        {
            //Pay with money Credit Card
        }
    }
}
