using System;

namespace CIOFContractSample.Models
{
	public class BaseColumn
	{
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BaseColumn()
        {
            CreateRecodeTime = DateTime.Now;
            UpdateRecordTime = DateTime.Now;
            IsDeleted = false;
        }

        /// <summary>作成者</summary>
        public string CreateRecodeUser { get; set; }
        /// <summary>作成日時</summary>
        public DateTime CreateRecodeTime { get; set; }
        /// <summary>更新者</summary>
        public string UpdateRecodeUser { get; set; }
        /// <summary>更新時刻</summary>
        public DateTime UpdateRecordTime { get; set; }
        /// <summary>論理削除フラグ</summary>
        public bool IsDeleted { get; set; }
    }
}
