namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddateVC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.valuesandcompetencies", "DateofSubmission", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.valuesandcompetencies", "DateofSubmission");
        }
    }
}
