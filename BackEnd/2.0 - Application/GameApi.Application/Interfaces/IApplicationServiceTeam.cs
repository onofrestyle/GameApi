using GameApi.Application.Dto.DTO;
using System.Collections.Generic;

namespace GameApi.Application.Interfaces
{
    public interface IApplicationServiceTeam
    {
        void Add(TeamDTO obj);

        TeamDTO GetById(int id);

        IEnumerable<TeamDTO> GetAll();

        void Update(TeamDTO obj);

        void Remove(TeamDTO obj);

        void Dispose();
    }
}