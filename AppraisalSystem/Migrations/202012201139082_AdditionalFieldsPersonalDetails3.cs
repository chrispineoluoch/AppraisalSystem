namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdditionalFieldsPersonalDetails3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.performancetargets", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.performancetargets", "UserName");
        }
    }
}
