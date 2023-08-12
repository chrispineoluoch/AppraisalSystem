namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.personaldetails", "FullName", c => c.String());
            DropColumn("dbo.personaldetails", "FirstName");
            DropColumn("dbo.personaldetails", "MiddleName");
            DropColumn("dbo.personaldetails", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.personaldetails", "LastName", c => c.String());
            AddColumn("dbo.personaldetails", "MiddleName", c => c.String());
            AddColumn("dbo.personaldetails", "FirstName", c => c.String());
            DropColumn("dbo.personaldetails", "FullName");
        }
    }
}
