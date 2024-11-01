using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Domain.Entities;
using CarBook.Dto.CarPricingDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.CarPricingInterfaces
{
    public interface ICarPricingRepository
    {
        Task<List<CarPricing>> GetCarPricingWithCars();
        Task<List<ResultCarPricingsWithTimePeriodsDto>> GetCarPricingWithTimePeriod();
    }
}
