using GameApi.Application.Dto.DTO;
using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface IGameMapper
    {
        Game MapperToEntity(GameDTO gameDTO);

        IEnumerable<GameDTO> MapperList(IEnumerable<Game> games);

        GameDTO MapperToDTO(Game game);
    }
}