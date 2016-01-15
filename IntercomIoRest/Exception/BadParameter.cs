namespace IntercomIoRest.Exception
{
    public class ApiException : System.Exception
    {
        public string Code { get; set; }
        public string Message { get; set; }

        public ApiException(string code, string message)
            : base(message)
        {
            Code = code;
            Message = message;
        }
    }
}
