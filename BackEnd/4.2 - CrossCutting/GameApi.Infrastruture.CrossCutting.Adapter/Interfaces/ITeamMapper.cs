using GameApi.Application.Dto.DTO;
using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Infrastruture.CrossCutting.Adapter.Interfaces
{
    public interface ITeamMapper
    {
        Team MapperToEntity(TeamDTO teamDTO);

        IEnumerable<TeamDTO> MapperList(IEnumerable<Team> teams);

        TeamDTO MapperToDTO(Team team);
    }
}