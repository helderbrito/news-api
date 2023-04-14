namespace ListArticles.Domain.Validation
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error)
        { }

        public DomainExceptionValidation(string message, Exception innerException) : base(message, innerException)
        { }
    }
}