using bevnet_challenge.Application.Common.Exceptions;
using bevnet_challenge.Application.Common.Interfaces;
using bevnet_challenge.Application.Common.Models;
using bevnet_challenge.Infrastructure.Settings;
using Newtonsoft.Json;

namespace bevnet_challenge.Infrastructure.Services
{
    public class MovieService : BaseService, IMovieService
    {
        private readonly ApiSettings _settings;

        public MovieService(ApiSettings settings)
        {
            _settings = settings;
        }

        public async Task<PaginatedResponse<Movie>> GetMovies(PaginatedRequest paginatedRequest)
        {
            string dataQuery = $"page={paginatedRequest.PageNumber}";
            var movies = await GetMoviesBase(dataQuery);
            return movies;
        }

        public async Task<PaginatedResponse<Movie>> GetMoviesByTitle(string title, PaginatedRequest paginatedRequest)
        {
            string dataQuery = $"Title={title}&page={paginatedRequest.PageNumber}";
            var movies = await GetMoviesBase(dataQuery);
            return movies;
        }

        private async Task<PaginatedResponse<Movie>> GetMoviesBase(string queryParams)
        {
            if (string.IsNullOrEmpty(_settings.MovieApiUrl)) throw new ArgumentNullException(nameof(_settings.MovieApiUrl));

            var httpResponse = await GetAsync($"{_settings.MovieApiUrl}?{queryParams}");
            var responseText = await httpResponse.Content.ReadAsStringAsync();

            if (httpResponse.IsSuccessStatusCode)
            {
                var movies = JsonConvert.DeserializeObject<PaginatedResponse<Movie>>(responseText);
                return movies;
            }

            throw new AppException("Error searching your favorite movie", System.Net.HttpStatusCode.InternalServerError);
        }
    }
}
