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

            CreateMap<PaginatedResponse<Movie>, PaginatedResponse<MovieDto>>().ConvertUsing((entity, dto, cfg) =>
            {
                if (entity == null) return null;
                if (dto == null) dto = new PaginatedResponse<MovieDto>();

                dto.page = entity.page;
                dto.per_page = entity.per_page;
                dto.total = entity.total;
                dto.total_pages = entity.total_pages;
                dto.data = cfg.Mapper.Map<IEnumerable<MovieDto>>(entity.data);

                return dto;
            });
        }
    }
}
