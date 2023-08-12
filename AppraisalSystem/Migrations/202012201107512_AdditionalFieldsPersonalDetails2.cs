namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalFieldsPersonalDetails2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.personaldetails", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.personaldetails", "UserName");
        }
    }
}
