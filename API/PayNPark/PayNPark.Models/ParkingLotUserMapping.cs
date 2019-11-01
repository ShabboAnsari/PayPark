using System.ComponentModel.DataAnnotations;

namespace PayNPark.Models
{
    public class ParkingLotUserMapping
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ParkingLotId { get; set; }
        public string DateOfAssignment { get; set; }
    }
}
