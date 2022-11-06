using bevnet_challenge.Application.Common.Models;
using bevnet_challenge.Application.UseCases.Movies.Dtos;
using MediatR;

namespace bevnet_challenge.Application.UseCases.Movies.GetMovies
{
    public record GetMoviesRequest(PaginatedRequest PaginatedRequest) : IRequest<PaginatedResponse<MovieDto>>;
}
