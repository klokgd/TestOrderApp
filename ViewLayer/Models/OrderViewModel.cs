using System.ComponentModel.DataAnnotations;

namespace ViewLayer.Models
{
    public class OrderViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string CityOfSender { get; set; }
        [Required]
        public string AdressOfSender { get; set; }
        [Required]
        public string CityOfRecepient { get; set; }
        [Required]
        public string AdressOfRecepient { get; set; }
        [Required]
        public double GoodsWeight { get; set; }
        [Required]
        public DateTime DeliveryDate { get; set; }
    }
}
