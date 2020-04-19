using GameApi.Application.Dto.DTO;
using GameApi.Domain.Models;
using GameApi.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace GameApi.Infrastruture.CrossCutting.Adapter.Map
{
    public class PlayerMapper : IPlayerMapper
    {
        public IEnumerable<PlayerDTO> MapperList(IEnumerable<Player> players)
        {
            foreach (var player in players)
            {
                yield return MapperToDTO(player);
            }
        }

        public PlayerDTO MapperToDTO(Player player)
        {
            return new PlayerDTO()
            {
                Id = player.Id,
                Name = player.Name,
                TeamId = player.TeamId
            };
        }

        public Player MapperToEntity(PlayerDTO playerDTO)
        {
            return new Player()
            {
                Id = playerDTO.Id,
                Name = playerDTO.Name,
                TeamId = playerDTO.TeamId == 0? null: playerDTO.TeamId
            };
        }
    }
}