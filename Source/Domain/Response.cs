namespace Domain
{
    public class Response
    {
        public string Message { get; set; }
        public int Status { get; set; }

        public Response(string message, int status)
        {
            Message = message;
            Status = status;
        }
    }
}
