namespace LibraryApp.SupportClasses.ResponseMessagesDictionary
{
    static public class ResponseMessagesDictionary
    {
        private static string created = " is succesfully created.";
        private static string updated = " is succesfully updated.";
        private static string deleted = " is succesfully deleted.";
        static public partial class User
        {
            static public string Created(long id)
            {
                return "User with ID " + id + created;
            }

            static public string Updated(long id)
            {
                return "User with ID " + id + updated;
            }

            static public string Updated(string email)
            {
                return "User with email " + email + updated;
            }

            static public string Deleted(long id)
            {
                return "User with ID " + id + deleted;
            }

            static public partial class Avatar
            {
                static public string Updated(long id)
                {
                    return "Avatar of user with ID " + id + updated;
                }

                static public string Updated(string email)
                {
                    return "Avatar of user with email " + email + updated;
                }

                static public string Deleted(long id)
                {
                    return "Avatar of user with ID " + id + deleted;
                }

                static public string Deleted(string email)
                {
                    return "Avatar of user with email " + email + deleted;
                }
            }
        }

        static public partial class Book
        {
            static public string Created(long id)
            {
                return "Book with ID " + id + created;
            }

            static public string Updated(long id)
            {
                return "Book with ID " + id + updated;
            }

            static public string Deleted(long id)
            {
                return "Book with ID " + id + deleted;
            }

            static public string Rented(long id)
            {
                return "Book with ID " + id + " is successfully rented.";
            }

            static public partial class Cover
            {
                static public string Updated(long id)
                {
                    return "Cover of book with ID " + id + updated;
                }

                static public string Deleted(long id)
                {
                    return "Cover of book with ID " + id + deleted;
                }
            }
        }
        static public partial class Author
        {
            static public string Created(long id)
            {
                return "Author with ID " + id + created;
            }

            static public string Updated(long id)
            {
                return "Author with ID " + id + updated;
            }

            static public string Deleted(long id)
            {
                return "Author with ID " + id + deleted;
            }
        }
    }
}
