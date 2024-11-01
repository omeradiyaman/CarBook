using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using CarBook.Domain.Entities;
using CarBook.Dto.CarPricingDtos;
using CarBook.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Persistence.Repositories.CarPricingRepositories
{
	public class CarPricingRepository : ICarPricingRepository
	{
		private readonly CarBookContext _context;

		public CarPricingRepository(CarBookContext context)
		{
			_context = context;
		}

		public async Task<List<CarPricing>> GetCarPricingWithCars()
		{
			var values = await _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(x => x.Pricing).Where(z => z.PricingId == 2).ToListAsync();
			return values;
		}

		public async Task<List<ResultCarPricingsWithTimePeriodsDto>> GetCarPricingWithTimePeriod()
		{
			var values = await _context.Cars.Include(x => x.CarPricings)
											.ThenInclude(x => x.Pricing)
											.Select(x => new
											{
												x.CarId,
												x.Brand.Name,
												x.Model,
												x.CoverImageUrl,
												HourlyAmount = x.CarPricings

													  .Where(cp => cp.PricingId == 1)

													  .Select(cp => cp.Amount)

													  .FirstOrDefault(),

												DailyAmount = x.CarPricings

													  .Where(cp => cp.PricingId == 2)

													  .Select(cp => cp.Amount)

													  .FirstOrDefault(),

												WeeklyAmount = x.CarPricings

													  .Where(cp => cp.PricingId == 3)

													  .Select(cp => cp.Amount)

													  .FirstOrDefault(),
												MonthlyAmount = x.CarPricings
													   .Where(cp => cp.PricingId == 6)
													   .Select(cp => cp.Amount)
													   .FirstOrDefault(),
											}).ToListAsync();

			var carPricings = values.Select(x => new ResultCarPricingsWithTimePeriodsDto
			{
				CarId = x.CarId,
				BrandAndModel = x.Name + " " + x.Model,
				CoverImageUrl = x.CoverImageUrl,
				DailyAmount = x.DailyAmount,
				WeeklyAmount = x.WeeklyAmount,
				HourlyAmount = x.HourlyAmount,
				MonthlyAmount = x.MonthlyAmount,

			}).ToList();
			return carPricings;
		}
	}
}
