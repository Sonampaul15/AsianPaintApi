using System.ComponentModel.DataAnnotations;

namespace AsianPaintApi.DTO
{
    public class AsianPaintDto
    {
        public int id { get; set; }

        public string PaintName { get; set; } = string.Empty;
      
        public string PaintCode { get; set; } = string.Empty;
       
        public string PaintType { get; set; } = string.Empty;
    }
}
