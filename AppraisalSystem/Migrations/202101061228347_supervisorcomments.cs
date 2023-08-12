namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supervisorcomments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.apraiseecomments", "EmployeeStrengths", c => c.String());
            AddColumn("dbo.apraiseecomments", "EmployeeDifficulties", c => c.String());
            AddColumn("dbo.apraiseecomments", "SupervisorPerformanceComments", c => c.String());
            AddColumn("dbo.apraiseecomments", "SupervisorName", c => c.String());
            AddColumn("dbo.apraiseecomments", "SupervisorDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.apraiseecomments", "SupervisorDate");
            DropColumn("dbo.apraiseecomments", "SupervisorName");
            DropColumn("dbo.apraiseecomments", "SupervisorPerformanceComments");
            DropColumn("dbo.apraiseecomments", "EmployeeDifficulties");
            DropColumn("dbo.apraiseecomments", "EmployeeStrengths");
        }
    }
}
