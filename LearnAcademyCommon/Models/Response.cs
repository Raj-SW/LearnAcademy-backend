namespace LearnAcademy.Models
{
    public class Response
    {
        public int statusCode { get; set; }
        public string statusMessage { get; set; }

        public Response(int statuscode, string statusmessage) {
            
            statusCode = statuscode;
            statusMessage = statusmessage;
        }   
    }
}
