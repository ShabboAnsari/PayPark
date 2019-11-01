using System.ComponentModel.DataAnnotations;

namespace PayNPark.Models
{
    public  class VehicleType
    {
        [Key]
        public int ID { get; set; }

        public string Type { get; set; }
    }
}