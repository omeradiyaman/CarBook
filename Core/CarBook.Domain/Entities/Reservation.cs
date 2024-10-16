﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? PickUpLocationId { get; set; }
        public int? DropOffLocationId { get; set; }
        public int CarId { get; set; }
        public int Age { get; set; }
        public int DriverLicenceYear { get; set; }
        public string? Description { get; set; }
        public Location PickUpLocation { get; set; }
        public Location DropOffLocation { get; set; }
        public Car Car { get; set; }
        public string Status { get; set; }
    }
}