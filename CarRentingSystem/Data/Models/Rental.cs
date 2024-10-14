using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentingSystem.Data.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
