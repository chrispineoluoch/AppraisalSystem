namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Counties",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CountyId = c.Int(nullable: false),
                        CountyName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCounties",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CountyId = c.Int(nullable: false),
                        SubCountyId = c.Int(nullable: false),
                        SubCountyName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Counties", t => t.CountyId, cascadeDelete: true)
                .Index(t => t.CountyId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.selfassessments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Othernames = c.String(),
                        Phonenumber = c.String(),
                        County = c.String(),
                        SubCounty = c.String(),
                        Organization = c.String(),
                        StudentID = c.String(),
                        Q1_proximity_exposure = c.String(),
                        Q2_period_exposure = c.String(),
                        Q3_chronic_conditions = c.String(),
                        Q4_above60yrs = c.String(),
                        Q5_smoker = c.String(),
                        Q6_pregnancyhistory = c.String(),
                        Q7_feverof104dg = c.String(),
                        Q8_feverresponding = c.String(),
                        Q9_worsecough = c.String(),
                        Q10_coughingblood = c.String(),
                        Q11_ratebreathlessness = c.String(),
                        Q12_unusualconfusion = c.String(),
                        Q13_fainting = c.String(),
                        Q14_lightheadedness = c.String(),
                        Q15_accuratedata = c.String(),
                        chronic_kidney_disease = c.Boolean(nullable: false),
                        organ_bonemarrow_transplant = c.Boolean(nullable: false),
                        active_hepB = c.Boolean(nullable: false),
                        chronic_liver_disease = c.Boolean(nullable: false),
                        cardiovascular_diseases = c.Boolean(nullable: false),
                        diabetes = c.Boolean(nullable: false),
                        chronic_lung_disease = c.Boolean(nullable: false),
                        blood_disorder = c.Boolean(nullable: false),
                        metabolic_disorder = c.Boolean(nullable: false),
                        neurological_condition = c.Boolean(nullable: false),
                        immunocompromising_diseases = c.Boolean(nullable: false),
                        fever = c.Boolean(nullable: false),
                        cough = c.Boolean(nullable: false),
                        breathing_difficulties = c.Boolean(nullable: false),
                        lightheadedness = c.Boolean(nullable: false),
                        confusion = c.Boolean(nullable: false),
                        none = c.Boolean(nullable: false),
                        DOS = c.DateTime(),
                        exposurefeedback = c.String(),
                        riskfeedback = c.String(),
                        symptomfeedback = c.String(),
                        progresstestfeedback = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        County = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.SubCounties", "CountyId", "dbo.Counties");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.SubCounties", new[] { "CountyId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.selfassessments");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.SubCounties");
            DropTable("dbo.Counties");
        }
    }
}
