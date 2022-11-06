using AutoMapper;
using bevnet_challenge.Application.Common.Interfaces;
using bevnet_challenge.Application.Common.Models;
using bevnet_challenge.Application.UseCases.Movies.Dtos;
using MediatR;

namespace bevnet_challenge.Application.UseCases.Movies.GetMovies
{
    public class GetMoviesRequestHandler : IRequestHandler<GetMoviesRequest, PaginatedResponse<MovieDto>>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public GetMoviesRequestHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<PaginatedResponse<MovieDto>> Handle(GetMoviesRequest request, CancellationToken cancellationToken)
        {
            var movies = await _movieService.GetMovies(request.PaginatedRequest);
            var movieDtos = _mapper.Map<PaginatedResponse<MovieDto>>(movies);
            return movieDtos;
        }
    }
}
