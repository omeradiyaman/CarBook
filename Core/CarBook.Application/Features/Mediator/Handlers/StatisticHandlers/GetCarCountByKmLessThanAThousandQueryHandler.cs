using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Features.Mediator.Results.StatisticResults;
using CarBook.Application.Interfaces.StatisticInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetCarCountByKmLessThanAThousandQueryHandler : IRequestHandler<GetCarCountByKmLessThanAThousandQuery, GetCarCountByKmLessThanAThousandQueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetCarCountByKmLessThanAThousandQueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKmLessThanAThousandQueryResult> Handle(GetCarCountByKmLessThanAThousandQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKmLessThanAThousand();
            return new GetCarCountByKmLessThanAThousandQueryResult
            {
                CarCount = value,
            };
        }
    }
}
