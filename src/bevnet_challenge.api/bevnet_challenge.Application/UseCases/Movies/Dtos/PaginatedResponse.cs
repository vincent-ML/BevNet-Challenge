namespace bevnet_challenge.Application.UseCases.Movies.Dtos
{
    public class PaginatedResponseDto<T>
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int Total { get; set; }
        public int TotalPages { get; set; }
        public IEnumerable<T>? Data { get; set; }
    }
}
