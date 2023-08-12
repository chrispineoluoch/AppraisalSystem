namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bool2stringProject : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.performancetargets", "Project", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.performancetargets", "Project", c => c.Boolean(nullable: false));
        }
    }
}
