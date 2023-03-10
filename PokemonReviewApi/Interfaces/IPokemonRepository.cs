using PokemonReviewApi.Models;

namespace PokemonReviewApi.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();


    }
}
