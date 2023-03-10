using Microsoft.AspNetCore.Mvc;
using PokemonReviewApi.Data;
using PokemonReviewApi.Interfaces;
using PokemonReviewApi.Models;

namespace PokemonReviewApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonController;

        public PokemonController (IPokemonRepository pokemonController, DataContext context)
        {
            _pokemonController = pokemonController;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemon()
        {
            var pokemons = _pokemonController.GetPokemons();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);

            }

            return Ok(pokemons);
        }

    }
}
