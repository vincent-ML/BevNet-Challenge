using bevnet_challenge.Application.UseCases.Movies.Dtos;
using MediatR;

namespace bevnet_challenge.Application.UseCases.Movies.GetMoviesByTitle
{
    public record GetMoviesByTitleRequest(string title) : IRequest<PaginatedResponseDto<MovieDto>>;
}
