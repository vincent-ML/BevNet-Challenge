using AutoMapper;
using bevnet_challenge.Application.Common.Interfaces;
using bevnet_challenge.Application.UseCases.Movies.Dtos;
using MediatR;

namespace bevnet_challenge.Application.UseCases.Movies.GetMoviesByTitle
{
    public class GetMoviesByTitleRequestHandler : IRequestHandler<GetMoviesByTitleRequest, PaginatedResponseDto<MovieDto>>
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public GetMoviesByTitleRequestHandler(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        public async Task<PaginatedResponseDto<MovieDto>> Handle(GetMoviesByTitleRequest request, CancellationToken cancellationToken)
        {
            var movies = await _movieService.GetMoviesByTitle(request.title);
            var movieDtos = _mapper.Map<PaginatedResponseDto<MovieDto>>(movies);
            return movieDtos;
        }
    }
}
