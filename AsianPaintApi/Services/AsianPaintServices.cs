using AsianPaintApi.DTO;
using AsianPaintApi.Models;
using AsianPaintApi.Repository;
using AutoMapper;

namespace AsianPaintApi.Services
{
    public class AsianPaintServices : IAsianPaintRepository
    {
        private readonly AsianPaintDbContext DB;
        IMapper Mapper;
        public AsianPaintServices(AsianPaintDbContext db, IMapper mapper)
        {
            DB = db;
            Mapper = mapper;
        }
        public List<AsianPaintDto> GetAllList()
        {
            List<AsianPaint> asianPaints= DB.AsianPaints.ToList();
            List<AsianPaintDto> Dto = Mapper.Map <List<AsianPaintDto>>(asianPaints);
            return Dto;
        }

        public AsianPaintDto InsertList(AsianPaintDto asianPaintDto)
        {
            AsianPaint asian = Mapper.Map<AsianPaint>(asianPaintDto);
            DB.AsianPaints.Add(asian);
            DB.SaveChanges();
            AsianPaintDto paintDto = Mapper.Map<AsianPaintDto>(asian);
            return paintDto;
        }
    }
}
