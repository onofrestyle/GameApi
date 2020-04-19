using System.Collections.Generic;
using GameApi.Application.Dto.DTO;
using GameApi.Domain.Models;
using GameApi.Infrastruture.CrossCutting.Adapter.Interfaces;

namespace GameApi.Infrastruture.CrossCutting.Adapter.Map
{
    public class GameMapper : IGameMapper
    {
        public IEnumerable<GameDTO> MapperList(IEnumerable<Game> games)
        {
            foreach (var game in games)
            {
                yield return MapperToDTO(game);
            }
        }

        public GameDTO MapperToDTO(Game game)
        {
            return new GameDTO()
            {
                Id = game.Id,
                GameStart = game.GameStart,
                GameEnd = game.GameEnd,
                HomeScore = game.HomeScore,
                GuestScore = game.GuestScore,
                GuestTeamId = game.GuestTeamId,
                HomeTeamId = game.HomeTeamId
            };
        }

        public Game MapperToEntity(GameDTO gameDTO)
        {
            return new Game()
            {
                Id = gameDTO.Id,
                GameStart = gameDTO.GameStart,
                GameEnd = gameDTO.GameEnd,
                HomeScore = gameDTO.HomeScore,
                GuestScore = gameDTO.GuestScore,
                GuestTeamId = gameDTO.GuestTeamId,
                HomeTeamId = gameDTO.HomeTeamId
            };
        }
    }
}