using System.Collections.Generic;

namespace GameApi.Domain.Models
{
    public class Team: Base
    {
        public string Name { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

    }
}