using System.Collections.Generic;
using GameApi.Application.Dto.DTO;
using GameApi.Application.Interfaces;
using GameApi.Domain.Core.Interfaces.Services;
using GameApi.Infrastruture.CrossCutting.Adapter.Interfaces;

namespace GameApi.Application.Service
{
    public class ApplicationServiceGame : IApplicationServiceGame
    {
        private readonly IGameService _gameService;

         private readonly IGameMapper _gameMapper;

         public ApplicationServiceGame(IGameService GameService, IGameMapper GameMapper)
                                              
        {
            _gameService = GameService;
            _gameMapper = GameMapper;
        }

        public void Remove(GameDTO obj)
        {
            _gameService.Remove(_gameMapper.MapperToEntity(obj));
        }

        public IEnumerable<GameDTO> GetAll()
        {
            return _gameMapper.MapperList(_gameService.GetAll());
        }

        public GameDTO GetById(int id)
        {
            return _gameMapper.MapperToDTO(_gameService.GetById(id));
        }

        public void Add(GameDTO obj)
        {
            _gameService.Add(_gameMapper.MapperToEntity(obj));
        }

        public void Update(GameDTO obj)
        {
            _gameService.Update(_gameMapper.MapperToEntity(obj));
        }
        
        public void Dispose()
        {
            _gameService.Dispose();
        }

    }
}