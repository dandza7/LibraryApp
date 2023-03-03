namespace LibraryApp.SupportClasses.GlobalExceptionHandler.CustomExceptions
{
    public class EmptyCollectionException : Exception
    {
        public EmptyCollectionException(string message = "Collection is empty!") : base(message)
        { }
    }
}
