using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Infra.Extensions;
using TopicWork.Models.ViewModels;

namespace TopicWork
{
	public partial class EditContract : Form
	{
		private int id;
		public EditContract(int id)
		{
			InitializeComponent();

			this.id = id;
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM Contract WHERE CId=@CId";
			var parameters = new SqlParameterBuilder()
				.AddInt("CId", id)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				MessageBox.Show("抱歉, 找不到要編輯的記錄");
				this.DialogResult = DialogResult.Abort;

				this.Close();
				return;
			}

			// 將欄位值放入控制項裡
			DataRow row = data.Rows[0];

			contractNameTextBox.Text = row.Field<string>("ContractName");
			contractTextBox.Text = row.Field<int>("Contract").ToString();

		}
		private void updateButton_Click_1(object sender, EventArgs e)
		{
			string contractName = contractNameTextBox.Text;
			try
			{
				int contract = contractTextBox.Text.ToInt(-1);
				if (string.IsNullOrEmpty(contractName)) throw new Exception("合約名稱不可空白");
				if (contract == -1) throw new Exception("請輸入整數");
				string sql = @"UPDATE Contract
SET ContractName=@ContractName, Contract=@Contract
WHERE CId=@CId";

				var parameters = new SqlParameterBuilder()
					.AddNVarchar("ContractName", 50, contractName)
					.AddInt("Contract", contract)
					.AddInt("CId", this.id)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}

		private void deleteButton_Click_1(object sender, EventArgs e)
		{

			try
			{
				if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
				{
					return;
				}

				string sql = @"DELETE FROM Contract WHERE CId=@CId";
				//if ()
				var parameters = new SqlParameterBuilder()
					.AddInt("CId", this.id)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("存在用戶資料中.不可刪除");
			}
		}


		private void EditContract_Load(object sender, EventArgs e)
		{

		}
	}
}
