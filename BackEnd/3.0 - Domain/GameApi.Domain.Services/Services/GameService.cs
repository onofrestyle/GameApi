using GameApi.Domain.Core.Interfaces.Repositorys;
using GameApi.Domain.Core.Interfaces.Services;
using GameApi.Domain.Models;

namespace GameApi.Domain.Services.Services
{
    public class GameService : ServiceBase<Game>, IGameService
    {
        public readonly IGameRepository _gameRepository;

        public GameService(IGameRepository Repository) 
            : base(Repository)
        {
            _gameRepository = Repository;
        }
    }
}