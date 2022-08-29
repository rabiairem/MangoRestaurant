namespace Mango.Services.CouponAPI.Models.Dto
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; }
        public string DiplayMessages { get; set; } = "";
        public List<string> ErrorMessages { get; set; }
    }
}
