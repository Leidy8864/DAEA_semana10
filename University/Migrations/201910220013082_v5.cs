namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Active", c => c.Int());
            AlterColumn("dbo.OfficeAssignments", "Active", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OfficeAssignments", "Active", c => c.Boolean(nullable: false));
            AlterColumn("dbo.People", "Active", c => c.Boolean());
        }
    }
}
