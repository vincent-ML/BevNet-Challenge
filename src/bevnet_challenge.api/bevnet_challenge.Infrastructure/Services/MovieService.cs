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

        public async Task<PaginatedResponse<Movie>> GetMovies()
        {
            if (string.IsNullOrEmpty(_settings.MovieApiUrl)) throw new ArgumentNullException(nameof(_settings.MovieApiUrl));

            var movies = new PaginatedResponse<Movie>();

            var httpResponse = await GetAsync(_settings.MovieApiUrl);
            var responseText = await httpResponse.Content.ReadAsStringAsync();

            if (httpResponse.IsSuccessStatusCode)
            {
                movies = JsonConvert.DeserializeObject<PaginatedResponse<Movie>>(responseText);
            }

            return movies;
        }

        public async Task<PaginatedResponse<Movie>> GetMoviesByTitle(string title)
        {
            if (string.IsNullOrEmpty(_settings.MovieApiUrl)) throw new ArgumentNullException(nameof(_settings.MovieApiUrl));

            var movies = new PaginatedResponse<Movie>();

            var httpResponse = await GetAsync($"{_settings.MovieApiUrl}?Title={title}");
            var responseText = await httpResponse.Content.ReadAsStringAsync();

            if (httpResponse.IsSuccessStatusCode)
            {
                movies = JsonConvert.DeserializeObject<PaginatedResponse<Movie>>(responseText);
            }

            return movies;
        }
    }
}
