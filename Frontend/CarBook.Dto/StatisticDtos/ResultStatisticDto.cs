using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Dto.StatisticDtos
{
    public class ResultStatisticDto
    {
        public int CarCount { get; set; }
        public int LocationCount { get; set; }
        public int AuthorCount { get; set; }
        public int BlogCount { get; set; }
        public int BrandCount { get; set; }
        public decimal AvgPriceDaily { get; set; }
        public decimal AvgPriceWeekly { get; set; }
        public decimal AvgPriceHourly { get; set; }
        public int AutoTransmissionCarCount { get; set; }
        public string BrandName { get; set; }
        public string BlogTitle { get; set; }
        public int CarCountByLessThanAThousandKm { get; set; }
        public int FuelGasolineOrDieselCarCount { get; set; }
        public int FuelElectricCarCount { get; set; }
        public string MaxPriceCarBrandAndModel { get; set; }
        public string MinPriceCarBrandAndModel { get; set; }
    }
}
