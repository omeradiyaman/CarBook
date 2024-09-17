using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Features.CQRS.Results.CarResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers.Read
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Brand> _brandRepository;

        public GetCarWithBrandQueryHandler(IRepository<Car> repository)
        {
            _carRepository = repository;
        }
        public async Task<List<GetCarWithBrandQueryResult>> Handle()
        {
            
            
        }
    }
}
