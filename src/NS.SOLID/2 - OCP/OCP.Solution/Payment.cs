namespace NS.SOLID.OCP.Solution
{
    public abstract class Payment
    {
        public decimal Value { get; set; }
        public abstract void Pay();
    }
}
