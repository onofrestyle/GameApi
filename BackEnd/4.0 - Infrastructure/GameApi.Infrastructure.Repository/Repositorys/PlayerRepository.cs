using System.Collections.Generic;
using System.Linq;
using GameApi.Domain.Core.Interfaces.Repositorys;
using GameApi.Domain.Models;
using GameApi.Infrastructure.Data;

namespace GameApi.Infrastructure.Repository.Repositorys
{
    public class PlayerRepository: BaseRepository<Player>, IPlayerRepository
    {
        private readonly SqliteContext _context;

        public PlayerRepository(SqliteContext Context)
            : base(Context)
        {
            _context = Context;
        }

        public IEnumerable<Player> GetByTeamId(int teamId)
        {
           return _context.Player.Where(x=> x.TeamId == teamId);
        }
    }
}