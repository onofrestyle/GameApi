using GameApi.Domain.Core.Interfaces.Repositorys;
using GameApi.Domain.Models;
using GameApi.Infrastructure.Data;

namespace GameApi.Infrastructure.Repository.Repositorys
{
    public class TeamRepository: BaseRepository<Team>, ITeamRepository
    {
        private readonly SqliteContext _context;

        public TeamRepository(SqliteContext Context)
            : base(Context)
        {
            _context = Context;
        }
    }
}