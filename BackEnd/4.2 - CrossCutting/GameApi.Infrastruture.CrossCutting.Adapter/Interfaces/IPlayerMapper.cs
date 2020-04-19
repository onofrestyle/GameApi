using GameApi.Application.Dto.DTO;
using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IPlayerMapper
    {
        Player MapperToEntity(PlayerDTO playerDTO);

        IEnumerable<PlayerDTO> MapperList(IEnumerable<Player> players);

        PlayerDTO MapperToDTO(Player player);
    }
}