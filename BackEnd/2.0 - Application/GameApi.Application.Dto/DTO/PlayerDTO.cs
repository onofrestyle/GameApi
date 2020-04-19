namespace GameApi.Application.Dto.DTO
{
    public class PlayerDTO : BaseDTO
    {
        public string Name { get; set; }

        private int? _teamId;
        public int? TeamId
        {
            get { return _teamId == 0? null : _teamId; }
            set { _teamId = value; }
        }
    }
}