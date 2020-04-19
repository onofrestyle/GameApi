using Autofac;
using GameApi.Application.Interfaces;
using GameApi.Application.Service;
using GameApi.Domain.Core.Interfaces.Repositorys;
using GameApi.Domain.Core.Interfaces.Services;
using GameApi.Domain.Services.Services;
using GameApi.Infrastructure.Repository.Repositorys;
using GameApi.Infrastruture.CrossCutting.Adapter.Interfaces;
using GameApi.Infrastruture.CrossCutting.Adapter.Map;

namespace GameApi.Infrastruture.CrossCutting.IOC
{
    public class Configuration
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServicePlayer>().As<IApplicationServicePlayer>();
            builder.RegisterType<ApplicationServiceTeam>().As<IApplicationServiceTeam>();
            builder.RegisterType<ApplicationServiceGame>().As<IApplicationServiceGame>();

            builder.RegisterType<PlayerService>().As<IPlayerService>();
            builder.RegisterType<TeamService>().As<ITeamService>();
            builder.RegisterType<GameService>().As<IGameService>();

            builder.RegisterType<PlayerRepository>().As<IPlayerRepository>();
            builder.RegisterType<TeamRepository>().As<ITeamRepository>();
            builder.RegisterType<GameRepository>().As<IGameRepository>();

            builder.RegisterType<PlayerMapper>().As<IPlayerMapper>();
            builder.RegisterType<TeamMapper>().As<ITeamMapper>();
            builder.RegisterType<GameMapper>().As<IGameMapper>();

        }
    }
}
