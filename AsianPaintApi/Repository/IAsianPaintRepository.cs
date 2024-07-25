using AsianPaintApi.DTO;

namespace AsianPaintApi.Repository
{
    public interface IAsianPaintRepository
    {
        List<AsianPaintDto > GetAllList();

        AsianPaintDto InsertList(AsianPaintDto asianPaintDto);
    }
}
