namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appraisalandsupervisorcomments : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.apraiseecomments", newName: "apraiseeandsupervisorcomments");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.apraiseeandsupervisorcomments", newName: "apraiseecomments");
        }
    }
}
