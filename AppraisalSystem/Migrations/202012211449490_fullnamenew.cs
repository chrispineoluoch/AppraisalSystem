namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fullnamenew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.valuesandcompetencies", "FullName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.valuesandcompetencies", "FullName");
        }
    }
}
