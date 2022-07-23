namespace NS.SOLID.OCP.Solution
{
    public class PaymentPix : Payment
    {
        public string KeyPix { get; set; }

        public override void Pay()
        {
            //Pay with pix
        }
    }
}
