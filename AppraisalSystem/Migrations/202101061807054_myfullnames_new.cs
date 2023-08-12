namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myfullnames_new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.apraiseeandsupervisorcomments", "FullName", c => c.String());
            AddColumn("dbo.traininganddevelopmentplans", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.traininganddevelopmentplans", "FullName");
            DropColumn("dbo.apraiseeandsupervisorcomments", "FullName");
        }
    }
}
