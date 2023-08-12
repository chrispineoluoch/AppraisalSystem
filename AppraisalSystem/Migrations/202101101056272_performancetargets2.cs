namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class performancetargets2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.performancetargets", "ResultAchieved_1", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_2", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_3", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_4", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_5", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_6", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_7", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_8", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_9", c => c.String());
            AddColumn("dbo.performancetargets", "ResultAchieved_10", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.performancetargets", "ResultAchieved_10");
            DropColumn("dbo.performancetargets", "ResultAchieved_9");
            DropColumn("dbo.performancetargets", "ResultAchieved_8");
            DropColumn("dbo.performancetargets", "ResultAchieved_7");
            DropColumn("dbo.performancetargets", "ResultAchieved_6");
            DropColumn("dbo.performancetargets", "ResultAchieved_5");
            DropColumn("dbo.performancetargets", "ResultAchieved_4");
            DropColumn("dbo.performancetargets", "ResultAchieved_3");
            DropColumn("dbo.performancetargets", "ResultAchieved_2");
            DropColumn("dbo.performancetargets", "ResultAchieved_1");
        }
    }
}
