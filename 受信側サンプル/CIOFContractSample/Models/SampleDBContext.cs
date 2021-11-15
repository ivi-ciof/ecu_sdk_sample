using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite;
using System.Data.SQLite.EF6;

namespace CIOFContractSample.Models
{
	public class SampleDBContext : DbContext
	{
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'Model1' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の 'ECU_Sample.Models.Model1' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'Model1' 接続文字列を変更してください。0
        public SampleDBContext()
            : base("name=SampleDBContext")
        {
        }

        /// <summary>
        /// データ受信サービス用テーブル
        /// </summary>
        public virtual DbSet<DataRecord> DataRecords { get; set; }

        public virtual DbSet<TradeDataRecord> TradeDataRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 各テーブルに複数キーを指定したい場合、ここで定義する
            //modelBuilder.Entity<RecieverDataModel>().HasKey(c => new { c.ID, c.MeasureDate });


            //var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<SqliteDbContext>(modelBuilder);
            //Database.SetInitializer(sqliteConnectionInitializer);
        }

        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        /// <summary>
        /// SQLiteのコンフィグクラス
        /// </summary>
        public class SQLiteConfiguration : DbConfiguration
        {
            public SQLiteConfiguration()
            {
                SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
                SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
                SetProviderServices("System.Data.SQLite.EF6", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
                SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
            }
        }
    }
}
