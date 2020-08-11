namespace IG.Sample.Model
{
    public class Order
    {
        public bool? IsRushOrder { get; set; }
        public OrderEnums.OrderType OrderType { get; set; }
        public bool? IsNewCustomer { get; set; }
        public bool? IsLargeOrder { get; set; }
    }
}
