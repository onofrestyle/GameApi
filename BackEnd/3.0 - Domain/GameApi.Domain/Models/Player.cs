namespace GameApi.Domain.Models
{
    public class Player: Base
    {
        public string Name { get; set; }

        public int? TeamId { get; set; }

    }
}