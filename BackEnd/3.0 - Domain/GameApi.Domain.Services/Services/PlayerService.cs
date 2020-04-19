using GameApi.Domain.Core.Interfaces.Repositorys;
using GameApi.Domain.Core.Interfaces.Services;
using GameApi.Domain.Models;

namespace GameApi.Domain.Services.Services
{
    public class PlayerService : ServiceBase<Player>, IPlayerService
    {
        public readonly IPlayerRepository _gameRepository;

        public PlayerService(IPlayerRepository Repository)
            : base(Repository)
        {
            _gameRepository = Repository;
        }
    }
}