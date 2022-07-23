namespace NS.SOLID.OCP.Violation
{
    public class Payment
    {
        /*
         The OCP is being injured because if I had to 
         create another payment situation, the class 
         must be modified
         */

        public decimal Value { get; set; }
        public EPaymentType PaymentType { get; set; }
        public void Pay()
        {
            if(PaymentType == EPaymentType.CreditCard)
            {
                //Get credit card details
            }

            if(PaymentType == EPaymentType.Money)
            {

            }

            if(PaymentType == EPaymentType.Pix)
            {
                //Get value from pix key
            }
        }
    }
}
