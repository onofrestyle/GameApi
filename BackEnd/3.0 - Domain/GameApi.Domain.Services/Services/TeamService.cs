using System.Collections.Generic;
using GameApi.Domain.Core.Interfaces.Repositorys;
using GameApi.Domain.Core.Interfaces.Services;
using GameApi.Domain.Models;

namespace GameApi.Domain.Services.Services
{
    public class TeamService : ServiceBase<Team>, ITeamService
    {
        public readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository Repository)
            : base(Repository)
        {
            _teamRepository = Repository;
        }
    }
}