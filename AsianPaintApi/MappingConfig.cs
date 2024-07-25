using AsianPaintApi.DTO;
using AsianPaintApi.Models;
using AutoMapper;

namespace AsianPaintApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMap()
        {

            var mappingConfig = new MapperConfiguration(Config =>
            {
             Config.CreateMap<AsianPaint, AsianPaintDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
