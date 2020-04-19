namespace GameApi.Domain.Models
{
    public class Base
    {
        private int? _id;
        public int? Id
        {
            get { return  _id == 0 ? null : _id; }
            set { _id = value; }
        }
    }
}