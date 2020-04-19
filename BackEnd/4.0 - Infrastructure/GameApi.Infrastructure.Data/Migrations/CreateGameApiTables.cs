using System;
using FluentMigrator;

namespace GameApi.Infrastructure.Data.Migrations
{
    [Migration(1)]
    public class CreateGameApiTables: Migration
    {
        public override void Up()
        {
           Create.Table("Team")
           .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
           .WithColumn("Name").AsString().NotNullable()
           .WithColumn("Wins").AsInt32().NotNullable().WithDefaultValue(0)
           .WithColumn("Loses").AsInt32().NotNullable().WithDefaultValue(0);

            Create.Table("Player")
            .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
            .WithColumn("Name").AsString().NotNullable()
            .WithColumn("TeamId").AsInt32().ForeignKey("Team","Id");

            Create.Table("Game")
            .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
            .WithColumn("GameStart").AsDateTime().NotNullable().WithDefaultValue(DateTime.Now)
            .WithColumn("GameEnd").AsDateTime().Nullable()
            .WithColumn("HomeTeamId").AsInt32().NotNullable().ForeignKey("Team","Id")
            .WithColumn("GuestTeamId").AsInt32().NotNullable().ForeignKey("Team","Id")
            .WithColumn("HomeScore").AsInt32().NotNullable().WithDefaultValue(0)
            .WithColumn("GuestScore").AsInt32().NotNullable().WithDefaultValue(0);
        }

        public override void Down()
        {
            Delete.Table("Game");
            Delete.Table("Player");
            Delete.Table("Team");
        }
      }
}