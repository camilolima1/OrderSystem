namespace OrderSystem.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int ProductCode { get; set; }
        public int RequestCode { get; set; }
        public int Quantity { get; set; }

        public OrderProduct() { }

        public OrderProduct(int id, int productCode, int requestCode)
        {
            Id = id;
            ProductCode = productCode;
            RequestCode = requestCode;
        }

    }
}
