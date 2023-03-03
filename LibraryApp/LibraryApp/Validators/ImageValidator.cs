namespace LibraryApp.Validators
{
    static public class ImageValidator
    {
        private static readonly string[] _extensions = new string[4] { ".jpg", ".jpeg", ".png", ".gif" };
        private static readonly int _maxSize = 1024 * 1024 * 2;

        public static bool IsValid(IFormFile file)
        {
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!_extensions.Contains(extension.ToLower()) || file.Length > _maxSize)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
