using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class StarWarsCharactersResult
    {
        [JsonPropertyName("results")]
        public StarWarsCharacter[] StarWarsCharacters { get; set; }
    }
}
