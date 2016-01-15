namespace IntercomIoRest.Exception
{
    public class NotInitializedException : System.Exception
    {
        public NotInitializedException() : base("Please initialize before using.") { }

    }
}
