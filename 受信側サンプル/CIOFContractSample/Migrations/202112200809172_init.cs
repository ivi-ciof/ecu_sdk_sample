namespace CIOFContractSample.Migrations
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
                        ContractDataID = c.String(maxLength: 2147483647),
                        CreateRecodeUser = c.String(maxLength: 2147483647),
                        CreateRecodeTime = c.DateTime(nullable: false),
                        UpdateRecodeUser = c.String(maxLength: 2147483647),
                        UpdateRecordTime = c.DateTime(nullable: false),
                        DeleteFlg = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
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
            
            CreateTable(
                "dbo.TradeDataRecord",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TradeContractId = c.String(maxLength: 2147483647),
                        DataId = c.String(maxLength: 2147483647),
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
            DropTable("dbo.TradeDataRecord");
            DropTable("dbo.DataRecord");
            DropTable("dbo.ContractDataSensorDataMap");
            DropTable("dbo.ContractDataMap");
        }
    }
}
