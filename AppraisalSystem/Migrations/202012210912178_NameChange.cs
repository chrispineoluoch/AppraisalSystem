namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.valuesandcompetencies", "PFNumber", c => c.String());
            DropColumn("dbo.valuesandcompetencies", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.valuesandcompetencies", "FullName", c => c.String());
            DropColumn("dbo.valuesandcompetencies", "PFNumber");
        }
    }
}
