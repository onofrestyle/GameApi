namespace GameApi.Application.Dto.DTO
{
    public class BaseDTO
    {
        private int? _id;
        public int? Id
        {
            get { return _id == 0 ? null : _id; }
            set { _id = value; }
        }
    }
}