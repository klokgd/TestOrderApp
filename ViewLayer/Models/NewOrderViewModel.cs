using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewLayer.Models
{
    public class NewOrderViewModel
    {
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
