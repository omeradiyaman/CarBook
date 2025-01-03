﻿using CarBook.Domain.Entities;
using CarBook.Dto.CarPricingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarInterfaces
{
    public interface ICarRepository
    {
        Task<List<Car>> GetCarsListWithBrands();
        Task<List<Car>> GetLast5CarsWithBrands();
        
    }
}
