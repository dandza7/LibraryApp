namespace LibraryApp.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string message = "Not found!") : base(message)
        { }
    }
}
