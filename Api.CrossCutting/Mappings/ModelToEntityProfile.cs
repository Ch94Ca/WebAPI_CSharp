using Domain.Entities;
using Domain.Models;
using AutoMapper;

namespace CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserModel, UserEntity>()
                .ReverseMap();

            CreateMap<UfModel, UfEntity>()
                .ReverseMap();

            CreateMap<MunicipioModel, MunicipioEntity>()
                .ReverseMap();

            CreateMap<CepModel, CepEntity>()
                .ReverseMap();

        }
    }
}