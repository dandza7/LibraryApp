namespace LibraryApp.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class NoAvatarFoundException : Exception
    {
        public NoAvatarFoundException(string message = "User does not have avatar saved!") : base(message)
        { }
    }
}
