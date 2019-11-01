using PayNPark.Models;
using System.Data.Entity;

namespace PayNPark.Repository.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext():base("connectionString")
        {
                
        }
        public DbSet<UserMaster> UserMaster { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }

        public DbSet<ParkingLot> ParkingLot { get; set; }

        public DbSet<ParkingLotUserMapping> ParkingLotUserMapping { get; set; }
    }
}
