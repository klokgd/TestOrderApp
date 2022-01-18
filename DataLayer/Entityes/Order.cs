namespace DataLayer
{
    public class Order
    {
        public int Id { get; set; }
        public string CityOfSender { get; set; }
        public string AdressOfSender { get; set; }
        public string CityOfRecepient { get; set; }
        public string AdressOfRecepient { get; set; }
        public double GoodsWeight { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}