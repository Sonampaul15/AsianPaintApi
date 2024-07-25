namespace AsianPaintApi.DTO
{
    public class ResponseDto
    {
        public Object? Result { get; set; }

        public Boolean IsSuccess { get; set; } = true;

        public String Message { get; set; } = "";
    }
}
