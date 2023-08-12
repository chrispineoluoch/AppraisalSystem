namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FullName2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.valuesandcompetencies", "FullName", c => c.String());
            DropColumn("dbo.valuesandcompetencies", "PFNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.valuesandcompetencies", "PFNumber", c => c.String());
            DropColumn("dbo.valuesandcompetencies", "FullName");
        }
    }
}
