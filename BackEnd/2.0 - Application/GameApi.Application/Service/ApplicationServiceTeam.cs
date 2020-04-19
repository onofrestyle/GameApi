using System.Collections.Generic;
using GameApi.Application.Dto.DTO;
using GameApi.Application.Interfaces;
using GameApi.Domain.Core.Interfaces.Services;
using GameApi.Infrastruture.CrossCutting.Adapter.Interfaces;

namespace GameApi.Application.Service
{
    public class ApplicationServiceTeam : IApplicationServiceTeam
    {
        private readonly ITeamService _teamService;

         private readonly ITeamMapper _teamMapper;

         public ApplicationServiceTeam(ITeamService TeamService, ITeamMapper TeamMapper)
        {
            _teamService = TeamService;
            _teamMapper = TeamMapper;
        }

        public void Remove(TeamDTO obj)
        {
            _teamService.Remove(_teamMapper.MapperToEntity(obj));
        }

        public IEnumerable<TeamDTO> GetAll()
        {
            return _teamMapper.MapperList(_teamService.GetAll());
        }

        public TeamDTO GetById(int id)
        {
            return _teamMapper.MapperToDTO(_teamService.GetById(id));
        }

        public void Add(TeamDTO obj)
        {
            _teamService.Add(_teamMapper.MapperToEntity(obj));
        }

        public void Update(TeamDTO obj)
        {
            _teamService.Update(_teamMapper.MapperToEntity(obj));
        }

        public void Dispose()
        {
            _teamService.Dispose();
        }

    }
}