using GameApi.Application.Dto.DTO;
using GameApi.Application.Interfaces;
using GameApi.Domain.Core.Interfaces.Services;
using GameApi.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Application.Service
{
    public class ApplicationServicePlayer : IApplicationServicePlayer
    {
        private readonly IPlayerService _playerService;

        private readonly IPlayerMapper _playerMapper;

         public ApplicationServicePlayer(IPlayerService PlayerService, IPlayerMapper PlayerMapper)
        {
            _playerService = PlayerService;
            _playerMapper = PlayerMapper;
        }

        public void Remove(PlayerDTO obj)
        {
            _playerService.Remove(_playerMapper.MapperToEntity(obj));
        }

        public IEnumerable<PlayerDTO> GetAll()
        {
            return _playerMapper.MapperList(_playerService.GetAll());
        }

        public PlayerDTO GetById(int id)
        {
            return _playerMapper.MapperToDTO(_playerService.GetById(id));
        }

        public void Add(PlayerDTO obj)
        {
            try
            {
                TeamCompletedException(obj);

                _playerService.Add(_playerMapper.MapperToEntity(obj));
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        public void Update(PlayerDTO obj)
        {
            TeamCompletedException(obj);

            _playerService.Update(_playerMapper.MapperToEntity(obj));
        }

        public void Dispose()
        {
            _playerService.Dispose();
        }

        private void TeamCompletedException(PlayerDTO obj)
        {
            if ((obj.TeamId.HasValue) && (obj.TeamId > 0))
            {
                var playersOnTeam = _playerService.GetByTeamId(obj.TeamId.Value);

                if ((playersOnTeam.Count() > 4) && !(playersOnTeam.Where(x=> x.Id == obj.Id) == null))
                    throw new System.Exception("Team is already completed");
            }
        }
    }
}