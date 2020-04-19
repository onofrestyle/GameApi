using GameApi.Domain.Core.Interfaces.Repositorys;
using GameApi.Domain.Models;
using GameApi.Infrastructure.Data;

namespace GameApi.Infrastructure.Repository.Repositorys
{
    public class GameRepository: BaseRepository<Game>, IGameRepository
    {
        private readonly SqliteContext _context;

        public GameRepository(SqliteContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}