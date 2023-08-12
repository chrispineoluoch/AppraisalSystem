namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class apraiseebool2string : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.apraiseecomments", "DiscussionConfirmation", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.apraiseecomments", "DiscussionConfirmation", c => c.Boolean(nullable: false));
        }
    }
}
