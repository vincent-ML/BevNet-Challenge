using bevnet_challenge.Application.Common.Models;

namespace bevnet_challenge.Application.Common.Interfaces
{
    public interface IMovieService
    {
        Task<PaginatedResponse<Movie>> GetMovies();
        Task<PaginatedResponse<Movie>> GetMoviesByTitle(string title);
    }
}
