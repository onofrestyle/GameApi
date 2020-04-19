using System.Collections.Generic;
using GameApi.Domain.Models;

namespace GameApi.Domain.Core.Interfaces.Services
{
    public interface IPlayerService: IBaseService<Player>
    {
        IEnumerable<Player> GetByTeamId(int teamId);
    }
}