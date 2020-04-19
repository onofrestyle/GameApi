namespace GameApi.Application.Dto.DTO
{
    public class TeamDTO : BaseDTO
    {
        public string Name { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }
    }
}