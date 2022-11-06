using bevnet_challenge.Application.Common.Models;
using bevnet_challenge.Application.UseCases.Movies.Dtos;
using MediatR;

namespace bevnet_challenge.Application.UseCases.Movies.GetMoviesByTitle
{
    public record GetMoviesByTitleRequest(string Title, PaginatedRequest PaginatedRequest) : IRequest<PaginatedResponse<MovieDto>>;
}
