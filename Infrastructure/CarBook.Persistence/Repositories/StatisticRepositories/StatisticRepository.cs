using CarBook.Application.Interfaces.StatisticInterfaces;
using CarBook.Domain.Entities;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly CarBookContext _context;

        public StatisticRepository(CarBookContext context)
        {
            _context = context;
        }

        public string BlogTitleByMaxBlogComment()
        {
            var value = _context.Comments.GroupBy(x => x.BlogId).OrderByDescending(y => y.Count()).Select(y => y.FirstOrDefault().Blog.Title).FirstOrDefault();
            return value;
        }

        public string BrandNameByMaxCar()
        {
            var value = _context.Cars.GroupBy(x => x.BrandId).OrderByDescending(y => y.Count()).Select(y => y.FirstOrDefault().Brand.Name).FirstOrDefault();
            return value;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            var value = _context.CarPricings.Where(x => x.PricingId == 2).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {
            var value = _context.CarPricings.Where(x => x.PricingId == 6).Average(x => x.Amount);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            var value = _context.CarPricings.Where(x => x.PricingId == 3).Average(x => x.Amount);
            return value;
        }

        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            var value = _context.CarPricings
                         .Where(x => x.PricingId == 2)
                         .OrderByDescending(x => x.Amount)
                         .Select(x => new
                         {
                             AracModeli = x.Car.Model,
                             MarkaAdi = x.Car.Brand.Name
                         })
                         .FirstOrDefault();
            return $" {value.AracModeli} - {value.MarkaAdi}";
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            var value = _context.CarPricings
                         .Where(x => x.PricingId == 2)
                         .OrderBy(x => x.Amount)
                         .Select(x => new
                         {
                             AracModeli = x.Car.Model,
                             MarkaAdi = x.Car.Brand.Name
                         })
                         .FirstOrDefault();
            return $" {value.AracModeli} - {value.MarkaAdi}";
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektrik").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
            return value;
        }

        public int GetCarCountByKmLessThanAThousand()
        {
            var value = _context.Cars.Where(x => x.Mileage <= 1000).Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }

    }
}
