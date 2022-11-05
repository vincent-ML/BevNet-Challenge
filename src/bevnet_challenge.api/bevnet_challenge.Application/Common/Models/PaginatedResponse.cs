namespace bevnet_challenge.Application.Common.Models
{
    public class PaginatedResponse<T>
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public int total_pages { get; set; }
        public IEnumerable<T>? data { get; set; }
    }
}
