namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Otherscores : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.performancetargets", "VCTotalScore", c => c.Int());
            AddColumn("dbo.performancetargets", "OverallScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.performancetargets", "OverallScore");
            DropColumn("dbo.performancetargets", "VCTotalScore");
        }
    }
}
