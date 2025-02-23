using FluentMigrator;
using Microsoft.AspNetCore.Http.HttpResults;

namespace houses_api.Data.Migrations
{
    [Migration(02022025)]
    public class CreateSchema : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Create.Table("house")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("model").AsString(120).NotNullable()
                .WithColumn("rooms").AsInt32().NotNullable()
                .WithColumn("price").AsInt32().NotNullable();

        }
    }
}
