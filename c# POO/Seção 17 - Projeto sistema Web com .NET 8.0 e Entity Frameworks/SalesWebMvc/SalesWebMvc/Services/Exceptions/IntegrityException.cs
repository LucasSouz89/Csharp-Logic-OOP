namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : ArgumentException
    {
        public IntegrityException(string message) :base(message){ }
    }
}
