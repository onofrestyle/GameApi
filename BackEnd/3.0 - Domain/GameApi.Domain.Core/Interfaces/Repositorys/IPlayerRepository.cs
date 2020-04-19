using System.Collections.Generic;
using GameApi.Domain.Models;

namespace GameApi.Domain.Core.Interfaces.Repositorys
{
    public interface IPlayerRepository: IBaseRepository<Player>
    {
       IEnumerable<Player> GetByTeamId(int teamId);
    }
}