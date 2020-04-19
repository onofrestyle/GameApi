namespace GameApi.Application.Dto.DTO
{
    public class PlayerDTO : BaseDTO
    {
        public string Name { get; set; }

        private int? _teamId;
        public int? TeamId
        {
            get { return TeamId == 0? null : TeamId; }
            set { _teamId = value; }
        }
    }
}