namespace LibraryApp.Models.DTO
{
    public class PaginationResponseWrapper<T>
    {
        public List<T> Items { get; set; } = new List<T>();
        public int TotalCount { get; set; }
        public PaginationResponseWrapper(List<T> items, int totalCount)
        {
            Items = items;
            TotalCount = totalCount;
        }
    }
}
