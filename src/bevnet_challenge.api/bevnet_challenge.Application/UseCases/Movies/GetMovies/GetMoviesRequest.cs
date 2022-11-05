using bevnet_challenge.Application.UseCases.Movies.Dtos;
using MediatR;

namespace bevnet_challenge.Application.UseCases.Movies.GetMovies
{
    public record GetMoviesRequest : IRequest<PaginatedResponseDto<MovieDto>>;
}
