namespace WebAppSwagger.Models
{
    public class ApiNotFoundResponse : ApiResponse
    {
        public ApiNotFoundResponse(string message)
          : base(404, message)
        {
        }
    }
}
