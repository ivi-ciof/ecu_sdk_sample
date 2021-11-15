namespace ECUContractSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataRecord",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataId = c.String(maxLength: 2147483647),
                        Temperature = c.Double(nullable: false),
                        Humidity = c.Double(nullable: false),
                        TimeStamp = c.String(maxLength: 2147483647),
                        CreateRecodeUser = c.String(maxLength: 2147483647),
                        CreateRecodeTime = c.DateTime(nullable: false),
                        UpdateRecodeUser = c.String(maxLength: 2147483647),
                        UpdateRecordTime = c.DateTime(nullable: false),
                        DeleteFlg = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DataRecord");
        }
    }
}
