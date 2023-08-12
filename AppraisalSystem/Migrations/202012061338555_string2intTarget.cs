namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class string2intTarget : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.performancetargets", "IndividualRating", c => c.Int(nullable: false));
            AlterColumn("dbo.performancetargets", "SupervisorRating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.performancetargets", "SupervisorRating", c => c.String());
            AlterColumn("dbo.performancetargets", "IndividualRating", c => c.String());
        }
    }
}
