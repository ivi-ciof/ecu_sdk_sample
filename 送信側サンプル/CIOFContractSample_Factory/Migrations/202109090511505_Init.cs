namespace CIOFContractSample_Factory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractDataSensorDataMap",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ContractDataID = c.String(maxLength: 2147483647),
                        SensoreDataId = c.Int(nullable: false),
                        CreateRecodeUser = c.String(maxLength: 2147483647),
                        CreateRecodeTime = c.DateTime(nullable: false),
                        UpdateRecodeUser = c.String(maxLength: 2147483647),
                        UpdateRecordTime = c.DateTime(nullable: false),
                        DeleteFlg = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ContractDataMap",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ContractID = c.String(maxLength: 2147483647),
                        ContractDataID = c.String(maxLength: 2147483647),
                        CreateRecodeUser = c.String(maxLength: 2147483647),
                        CreateRecodeTime = c.DateTime(nullable: false),
                        UpdateRecodeUser = c.String(maxLength: 2147483647),
                        UpdateRecordTime = c.DateTime(nullable: false),
                        DeleteFlg = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SensorData",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Tempareture = c.Double(nullable: false),
                        Humidity = c.Double(nullable: false),
                        MeasureDate = c.String(maxLength: 2147483647),
                        CreateRecodeUser = c.String(maxLength: 2147483647),
                        CreateRecodeTime = c.DateTime(nullable: false),
                        UpdateRecodeUser = c.String(maxLength: 2147483647),
                        UpdateRecordTime = c.DateTime(nullable: false),
                        DeleteFlg = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SensorData");
            DropTable("dbo.ContractDataMap");
            DropTable("dbo.ContractDataSensorDataMap");
        }
    }
}
