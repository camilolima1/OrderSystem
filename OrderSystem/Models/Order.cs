namespace OrderSystem.Models
{
    public class Order
    {
        public int RequestCode { get; set; }
        public DateTime DateOfOrder { get; set; }
        public int ProductCode { get; set; }
        public string ProviderCode { get; set; }
        public double Amount { get; set; }

        public Order() { }

        public Order(int requestCode, DateTime dateOfOrder, int productCode, string providerCode, double amount)
        {
            RequestCode = RequestCode;
            DateOfOrder = dateOfOrder;
            ProductCode = productCode;
            ProviderCode = providerCode;
            Amount = amount;
        }

    }
}
