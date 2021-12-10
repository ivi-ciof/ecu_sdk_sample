namespace ECUContractSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tradedata : DbMigration
    {
        public override void Up()
        {
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
        }
    }
}
