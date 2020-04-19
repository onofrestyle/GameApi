using System.Collections.Generic;
using GameApi.Domain.Core.Interfaces.Repositorys;
using GameApi.Domain.Core.Interfaces.Services;
using GameApi.Domain.Models;

namespace GameApi.Domain.Services.Services
{
    public class PlayerService : ServiceBase<Player>, IPlayerService
    {
        public readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository Repository)
            : base(Repository)
        {
            _playerRepository = Repository;
        }

        public IEnumerable<Player> GetByTeamId(int teamId)
        {
           return _playerRepository.GetByTeamId(teamId);
        }
    }
}