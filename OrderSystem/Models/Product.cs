namespace OrderSystem.Models
{
    public class Product
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public string RegistrationDate { get; set; }
        public string Value { get; set; }

        public Product() { }

        public Product(int code, string description, string registrationDate, string value)
        {
            Code = code;
            Description = description;
            RegistrationDate = registrationDate;
            Value = value;
        }
    }
}
