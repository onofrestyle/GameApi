using GameApi.Application.Dto.DTO;
using GameApi.Domain.Models;
using GameApi.Infrastruture.CrossCutting.Adapter.Interfaces;
using System.Collections.Generic;

namespace GameApi.Infrastruture.CrossCutting.Adapter.Map
{
    public class TeamMapper : ITeamMapper
    {
        public IEnumerable<TeamDTO> MapperList(IEnumerable<Team> teams)
        {
            foreach (var team in teams)
            {
                yield return MapperToDTO(team);
            }
        }

        public TeamDTO MapperToDTO(Team team)
        {
            return new TeamDTO()
            {
                Id = team.Id,
                Name = team.Name,
                Wins = team.Wins,
                Loses = team.Loses
            };
        }

        public Team MapperToEntity(TeamDTO teamDTO)
        {
            return new Team()
            {
                Id = teamDTO.Id,
                Name = teamDTO.Name,
                Wins = teamDTO.Wins,
                Loses = teamDTO.Loses
            };
        }
    }
}