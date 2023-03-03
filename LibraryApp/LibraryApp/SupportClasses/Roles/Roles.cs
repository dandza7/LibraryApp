namespace LibraryApp.SupportClasses.Roles
{
    public class Roles
    {
        public const string Admin = "ADMIN";
        public const string Librarian = "LIBRARIAN";
        public const string User = "USER";

        public const string AuthorizationLevelAdmin = Admin;
        public const string AuthorizationLevelLibrarian = Admin + ", " + Librarian;
        public const string AuthorizationLevelUser = Admin + ", " + Librarian + ", " + User;
    }
}
