﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.CarDtos
{
    public class CreateCarDto
    {
            public int BrandId { get; set; }
            public string Model { get; set; }
            public string CoverImageUrl { get; set; }
            public int Mileage { get; set; }
            public string Transmission { get; set; }
            public int Seats { get; set; }
            public int Luggage { get; set; }
            public string Fuel { get; set; }
            public string BigImageUrl { get; set; }
    }
}
