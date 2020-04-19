using System;

namespace GameApi.Domain.Models
{
    public class Game: Base
    {
        public DateTime GameStart { get; set; }

        public DateTime? GameEnd { get; set; }

        public int HomeTeamId { get; set; }

        public int GuestTeamId { get; set; }

        public int HomeScore { get; set; }

        public int GuestScore { get; set; }

    }
}