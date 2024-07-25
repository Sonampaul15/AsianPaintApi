using System.ComponentModel.DataAnnotations;

namespace AsianPaintApi.Models
{
    public class AsianPaint
    {
        [Key]
        public int id {  get; set; }

        [Required(ErrorMessage ="EnterNameHere")]
        public string PaintName { get; set; } = string.Empty;
        [Required(ErrorMessage = "EnterCodeHere")]
        public string PaintCode { get; set; }=string.Empty;
        [Required(ErrorMessage = "EnterTypeHere")]
        public string PaintType { get; set; } = string.Empty;   
    }
}
