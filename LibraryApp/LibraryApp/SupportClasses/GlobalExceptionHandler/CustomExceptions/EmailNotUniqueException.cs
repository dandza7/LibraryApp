namespace LibraryApp.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class EmailNotUniqueException : Exception
    {
        public EmailNotUniqueException(string message = "Email already exists in database!") : base(message)
        { }
    }
}
