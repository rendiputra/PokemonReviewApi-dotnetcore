using AutoMapper;
using PokemonReviewApi.Dto;
using PokemonReviewApi.Models;

namespace PokemonReviewApi.Helper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
