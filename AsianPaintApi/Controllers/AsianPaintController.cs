using AsianPaintApi.DTO;
using AsianPaintApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsianPaintApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AsianPaintController : ControllerBase
    {
        private IAsianPaintRepository Repository;
        private ResponseDto Response;

        public AsianPaintController(IAsianPaintRepository repository)
        {
            Response = new ResponseDto();
            Repository = repository;
        }

        [HttpGet]
        public ResponseDto GetAllList()
        {
            List<AsianPaintDto> asians= Repository.GetAllList();
            Response.Result = asians;
            return Response;
        }

        [HttpPost] 
        public ResponseDto InsertList([FromBody]AsianPaintDto paintDto)
        {
            try
            {
                if (!string.IsNullOrEmpty(paintDto.PaintCode))
                {
                    AsianPaintDto asianPaintDto = Repository.InsertList(paintDto);
                    Response.Result=asianPaintDto;
                }

                else
                {
                    Response.Message = "Data Should Not Be Empty";
                }
            }
            catch (Exception ex)
            {

                Response.Result = false;
                Response.Message = ex.Message;
            }

            return Response;
        }
    }
}
