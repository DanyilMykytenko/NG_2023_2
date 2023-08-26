namespace DAL.Entities
{
    public class Order : BaseEntity
    {
        public int  CustomerID { get; set; }
        public DateTime  OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string  ShippingAddress { get; set; }
        public virtual User User { get; set; }
    }
}
