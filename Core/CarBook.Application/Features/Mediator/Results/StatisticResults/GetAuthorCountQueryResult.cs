using CarBook.Application.Features.Mediator.Queries.StatisticQueries;
using CarBook.Application.Interfaces.StatisticInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Results.StatisticResults
{
    public class GetAuthorCountQueryResult
    {
        public int AuthorCount { get; set; }
    }
}
