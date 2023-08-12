namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalFieldsPersonalDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.personaldetails", "JobGroup", c => c.String());
            AddColumn("dbo.personaldetails", "SupervisorName", c => c.String());
            AddColumn("dbo.personaldetails", "SupervisorPFNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.personaldetails", "SupervisorPFNumber");
            DropColumn("dbo.personaldetails", "SupervisorName");
            DropColumn("dbo.personaldetails", "JobGroup");
        }
    }
}
