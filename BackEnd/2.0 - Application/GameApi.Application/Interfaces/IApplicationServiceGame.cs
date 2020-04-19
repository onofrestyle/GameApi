using System.Collections.Generic;
using GameApi.Application.Dto.DTO;

namespace GameApi.Application.Interfaces
{
    public interface IApplicationServiceGame
    {
        void Add(GameDTO obj);

        GameDTO GetById(int id);

        IEnumerable<GameDTO> GetAll();

        void Update(GameDTO obj);

        void Remove(GameDTO obj);

        void Dispose();
    }
}