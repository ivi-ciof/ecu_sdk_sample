using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite;
using System.Data.SQLite.EF6;

namespace CIOFContractSample_Factory.Models
{
    public class SqliteDbContext : DbContext
    {
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'Model1' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の 'CIOFContractSample_Factory.Model1' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'Model1' 接続文字列を変更してください。
        public SqliteDbContext()
            : base("name=SqliteDbContext")
        {
        }

        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        /// <summary>
        /// センサーデータ
        /// </summary>
        public virtual DbSet<SensorDataModel> SensorDatas { get; set; }

        /// <summary>
        /// 取引データIDとセンサーデータIDのMap
        /// </summary>
        public virtual DbSet<ContractDataSensorDataMapModel> ContractDataSensorDataMaps { get; set; }

        /// <summary>
        /// 契約IDと取引データIDのマップ
        /// </summary>
        public virtual DbSet<ContractDataMapModel> ContractDataMaps { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 各テーブルに複数キーを指定したい場合、ここで定義する
            //modelBuilder.Entity<RecieverDataModel>().HasKey(c => new { c.ID, c.MeasureDate });


            //var sqliteConnectionInitializer = new SqliteCreateDatabaseIfNotExists<SqliteDbContext>(modelBuilder);
            //Database.SetInitializer(sqliteConnectionInitializer);
        }
    }

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