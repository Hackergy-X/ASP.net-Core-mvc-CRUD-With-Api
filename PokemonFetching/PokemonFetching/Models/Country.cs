﻿using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonFetching.Models
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }

        public string ownerName { get; set; }

        public ICollection<Owner> Owners { get; set; }
    }
}
