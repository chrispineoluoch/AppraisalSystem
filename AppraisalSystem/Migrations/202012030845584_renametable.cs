namespace AppraisalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renametable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.personaldetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateFrom = c.DateTime(),
                        DateTo = c.DateTime(),
                        Firstname = c.String(),
                        Middlename = c.String(),
                        Lastname = c.String(),
                        PFNumber = c.Int(nullable: false),
                        Designation = c.String(),
                        Department = c.String(),
                        NatureofEmployment = c.Boolean(nullable: false),
                        StaffCategory = c.Boolean(nullable: false),
                        AcademicQualifications = c.String(),
                        ProfessionalCertifications = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.selfassessments");
        }
        
        public override void Down()
        {
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
            
            DropTable("dbo.personaldetails");
        }
    }
}
