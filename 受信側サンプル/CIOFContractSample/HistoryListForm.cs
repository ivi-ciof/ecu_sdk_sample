using CIOF_SDK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIOFContractSample
{
	public partial class HistoryListForm : Form
	{
        /// <summary>
        /// コントローラモデル
        /// </summary>
        public ControllerModel controllerModel;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public HistoryListForm()
        {
            InitializeComponent();
            // 画面更新
            UpdateShowDatas();
        }

        public HistoryListForm(ControllerModel controller)
        {
            InitializeComponent();
            // 画面更新
            UpdateShowDatas();
            this.controllerModel = controller;
        }

        /// <summary>
        /// 画面表示データ更新
        /// </summary>
        private void UpdateShowDatas()
        {
            // 表示停止
            this.SuspendLayout();

            //  DBからデータを取得
            using (var db = new Models.SampleDBContext())
            {
                // 契約ID - 取引データID
                dgvContractMap.Rows.Clear();
                foreach (var dataMap in db.ContractDataMaps)
                {
                    dgvContractMap.Rows.Add(dataMap.ContractID, dataMap.ContractDataID, dataMap.CreateRecodeTime);
                }

                // 取引データID-センサーデータID
                dgvContractDataSensorDataMap.Rows.Clear();
                foreach (var dataMap in db.ContractDataSensorDataMaps)
                {
                    dgvContractDataSensorDataMap.Rows.Add(dataMap.ContractDataID, dataMap.SensoreDataId, dataMap.CreateRecodeTime);
                }

                // センサーデータ詳細
                dgvSensorData.Rows.Clear();
                foreach (var sensorData in db.DataRecords)
                {
                    dgvSensorData.Rows.Add(sensorData.Id, sensorData.Temperature, sensorData.Humidity, sensorData.TimeStamp);

                }
            }

            // 表示再開
            this.ResumeLayout();
        }


        /// <summary>
        /// 更新ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            UpdateShowDatas();
        }

        private void btnSendDeleteRequest_Click(object sender, System.EventArgs e)
        {
            var selectedContractDataId = dgvContractMap.SelectedRows[0].Cells[0].Value as string;
            var selectedTradeDataId = dgvContractMap.SelectedRows[0].Cells[1].Value as string;

            controllerModel.PostRequestParameter(selectedContractDataId, "delete", null, selectedTradeDataId);

            MessageBox.Show("削除リクエストを送信しました。");
        }
    }
}
