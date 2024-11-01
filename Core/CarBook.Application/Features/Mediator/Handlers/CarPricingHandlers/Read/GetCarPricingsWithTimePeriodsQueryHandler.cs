using CarBook.Application.Features.Mediator.Queries.CarPricingQueries;
using CarBook.Application.Features.Mediator.Results.CarPricingResults;
using CarBook.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarPricingHandlers.Read
{
	public class GetCarPricingsWithTimePeriodsQueryHandler : IRequestHandler<GetCarPricingsWithTimePeriodsQuery, List<GetCarPricingsWithTimePeriodsQueryResult>>
	{
		private readonly ICarPricingRepository _repository;

		public GetCarPricingsWithTimePeriodsQueryHandler(ICarPricingRepository repository)
		{
			_repository = repository;
		}

		public async Task<List<GetCarPricingsWithTimePeriodsQueryResult>> Handle(GetCarPricingsWithTimePeriodsQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetCarPricingWithTimePeriod();
			return values.Select(x => new GetCarPricingsWithTimePeriodsQueryResult
			{
				CarId = x.CarId,
				BrandAndModel = x.BrandAndModel,
				DailyAmount = x.DailyAmount,
				MonthlyAmount = x.MonthlyAmount,
				CoverImageUrl = x.CoverImageUrl,
				HourlyAmount = x.HourlyAmount,
			}).ToList();
		}
	}
}
