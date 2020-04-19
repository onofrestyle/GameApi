using System;

namespace GameApi.Application.Dto.DTO
{
    public class GameDTO : BaseDTO
    {
        public DateTime GameStart { get; set; }

        public DateTime? GameEnd { get; set; }

        public int HomeTeamId { get; set; }

        public int GuestTeamId { get; set; }

        public int HomeScore { get; set; }

        public int GuestScore { get; set; }
    }
}