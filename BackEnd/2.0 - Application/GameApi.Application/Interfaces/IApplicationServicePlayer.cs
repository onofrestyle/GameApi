using System.Collections.Generic;
using GameApi.Application.Dto.DTO;

namespace GameApi.Application.Interfaces
{
    public interface IApplicationServicePlayer
    {
        void Add(PlayerDTO obj);

        PlayerDTO GetById(int id);

        IEnumerable<PlayerDTO> GetAll();

        void Update(PlayerDTO obj);

        void Remove(PlayerDTO obj);

        void Dispose();
    }
}