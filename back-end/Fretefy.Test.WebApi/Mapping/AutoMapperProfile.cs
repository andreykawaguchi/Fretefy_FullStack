using AutoMapper;
using Fretefy.Test.WebApi.Dtos;
using Fretefy.Test.Domain.Entities;
using System.Linq;

namespace Fretefy.Test.WebApi.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // Domain -> DTO
            CreateMap<Cidade, CidadeDto>();

            CreateMap<Regiao, RegiaoDto>()
                .ForMember(dest => dest.Cidades, opt => opt.MapFrom(src => src.RegiaoCidades.Select(rc => rc.Cidade)))
                .ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.Ativo));

            CreateMap<RegiaoCidade, RegiaoCidadeDto>()
                .ForMember(dest => dest.RegiaoNome, opt => opt.MapFrom(src => src.Regiao != null ? src.Regiao.Nome : null))
                .ForMember(dest => dest.CidadeNome, opt => opt.MapFrom(src => src.Cidade != null ? src.Cidade.Nome : null));

            // Input DTOs -> Domain
            CreateMap<RegiaoCidadeInputDto, RegiaoCidade>()
                .ConstructUsing(src => new RegiaoCidade(System.Guid.Empty, src.CidadeId));

            CreateMap<CreateRegiaoDto, Regiao>()
                .ConstructUsing(src => new Regiao(src.Nome))
                .ForMember(dest => dest.RegiaoCidades, opt => opt.MapFrom(src => src.RegiaoCidades))
                .AfterMap((src, dest) =>
                {
                    if (dest.RegiaoCidades != null)
                    {
                        foreach (var rc in dest.RegiaoCidades)
                        {
                            rc.RegiaoId = dest.Id;
                        }
                    }
                });

            CreateMap<UpdateRegiaoDto, Regiao>()
                .ConstructUsing(src => new Regiao(src.Nome))
                .ForMember(dest => dest.RegiaoCidades, opt => opt.MapFrom(src => src.RegiaoCidades))
                .AfterMap((src, dest) =>
                {
                    dest.Id = src.Id;
                    if (dest.RegiaoCidades != null)
                    {
                        foreach (var rc in dest.RegiaoCidades)
                        {
                            rc.RegiaoId = dest.Id;
                        }
                    }
                });
        }
    }
}
