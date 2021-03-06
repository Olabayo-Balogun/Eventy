namespace Eventy.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class FixedMembershipSignUpFee : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
        }
    }
}