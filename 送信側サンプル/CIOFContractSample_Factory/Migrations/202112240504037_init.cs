namespace CIOFContractSample_Factory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractDataMap",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ContractID = c.String(maxLength: 2147483647),
                        TradeDataID = c.String(maxLength: 2147483647),
                        CreateRecodeUser = c.String(maxLength: 2147483647),
                        CreateRecodeTime = c.DateTime(nullable: false),
                        UpdateRecodeUser = c.String(maxLength: 2147483647),
                        UpdateRecordTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ContractDataSensorDataMap",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TradeDataID = c.String(maxLength: 2147483647),
                        RecordId = c.Int(nullable: false),
                        CreateRecodeUser = c.String(maxLength: 2147483647),
                        CreateRecodeTime = c.DateTime(nullable: false),
                        UpdateRecodeUser = c.String(maxLength: 2147483647),
                        UpdateRecordTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.SensorData",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Tempareture = c.Double(nullable: false),
                        Humidity = c.Double(nullable: false),
                        CO2 = c.Double(nullable: false),
                        MeasureDate = c.String(maxLength: 2147483647),
                        CreateRecodeUser = c.String(maxLength: 2147483647),
                        CreateRecodeTime = c.DateTime(nullable: false),
                        UpdateRecodeUser = c.String(maxLength: 2147483647),
                        UpdateRecordTime = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SensorData");
            DropTable("dbo.ContractDataSensorDataMap");
            DropTable("dbo.ContractDataMap");
        }
    }
}
