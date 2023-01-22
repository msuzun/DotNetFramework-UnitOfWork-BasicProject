namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departmans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        isActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Personels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        DepartmentId = c.Int(nullable: false),
                        CreateDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        isActive = c.Boolean(nullable: false),
                        Departmans_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departmans", t => t.Departmans_Id)
                .Index(t => t.Departmans_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Personels", "Departmans_Id", "dbo.Departmans");
            DropIndex("dbo.Personels", new[] { "Departmans_Id" });
            DropTable("dbo.Personels");
            DropTable("dbo.Departmans");
        }
    }
}
