using AutoMapper;
using bevnet_challenge.Application.Common.Models;
using bevnet_challenge.Application.UseCases.Movies.Dtos;

namespace bevnet_challenge.Application.Common.Mappings
{
    public class MovieMappings : Profile
    {
        public MovieMappings()
        {
            CreateMap<Movie, MovieDto>().ConvertUsing((entity, dto) =>
            {
                if (entity == null) return null;
                if (dto == null) dto = new MovieDto();

                dto.Id = entity.imdbID;
                dto.Title = entity.Title;
                dto.Year = entity.Year;

                return dto;
            });

            CreateMap<PaginatedResponse<Movie>, PaginatedResponseDto<MovieDto>>().ConvertUsing((entity, dto, cfg) =>
            {
                if (entity == null) return null;
                if (dto == null) dto = new PaginatedResponseDto<MovieDto>();

                dto.Page = entity.page;
                dto.PerPage = entity.per_page;
                dto.Total = entity.total;
                dto.TotalPages = entity.total_pages;
                dto.Data = cfg.Mapper.Map<IEnumerable<MovieDto>>(entity.data);

                return dto;
            });
        }
    }
}
