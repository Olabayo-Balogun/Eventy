namespace Eventy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class UpdatedMaterialClassProperties : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Materials", "Name", c => c.String(nullable: false));
        }

        public override void Down()
        {
            AlterColumn("dbo.Materials", "Name", c => c.String());
        }
    }
}