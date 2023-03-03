namespace LibraryApp.Models.DTO.PFS
{
    public class Filter
    {
        public string Property { get; set; } = string.Empty;
        public Connecting Connecting { get; set; } = Connecting.OR;
        public List<FilterValue> FilterValues { get; set; }
        public partial class FilterValue
        {
            public string Value { get; set; } = string.Empty;
            public FilterOperation Operation { get; set; } = FilterOperation.StringContains;
        }

        public override string? ToString()
        {
            string query = string.Empty;
            string connector = Connecting.Equals(Connecting.AND) ? " && " : " || ";
            foreach (FilterValue value in FilterValues)
            {
                query += Property + OperationToString(value);
                if (value.Equals(FilterValues.Last()))
                {
                    break;
                }
                query += connector;
            }
            return query;
        }
        private string OperationToString(FilterValue filterValue)
        {
            return filterValue.Operation switch
            {
                FilterOperation.StringContains => ".Contains(\"" + filterValue.Value + "\")",
                FilterOperation.StringEquals => ".Equals(\"" + filterValue.Value + "\")",
                FilterOperation.NumberEquals => "=" + filterValue.Value,
                FilterOperation.NumberLessThan => "<" + filterValue.Value,
                FilterOperation.NumberGreaterThan => ">" + filterValue.Value,
                _ => "",
            };
        }
    }
    public enum FilterOperation
    {
        StringContains,
        StringEquals,
        NumberEquals,
        NumberLessThan,
        NumberGreaterThan
    }
    public enum Connecting
    {
        AND,
        OR
    }
}
