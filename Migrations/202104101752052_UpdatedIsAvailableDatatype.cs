namespace Eventy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdatedIsAvailableDatatype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Materials", "IsAvailable", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Materials", "IsAvailable", c => c.Byte(nullable: false));
        }
    }
}