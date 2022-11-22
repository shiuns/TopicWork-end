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
	public partial class EditPhone : Form
	{
		private int id;
		public EditPhone(int id)
		{
			InitializeComponent();
			this.id = id;
			BindData(id);
		}
		private void BindData(int id)
		{
			string sql = "SELECT * FROM Phone WHERE PId=@PId";
			var parameters = new SqlParameterBuilder()
				.AddInt("PId", id)
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

			PhoneBrandTextBox.Text = row.Field<string>("PhoneBrand");
			PhoneModelTextBox.Text = row.Field<string>("PhoneModel");

		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			string phoneBrand = PhoneBrandTextBox.Text;

			string phoneModel = PhoneModelTextBox.Text;
			if (string.IsNullOrEmpty(phoneBrand)) throw new Exception("手機品牌不可空白");
			if (string.IsNullOrEmpty(phoneModel)) throw new Exception("手機型號不可空白");
			try
			{
				string sql = @"UPDATE Phone
SET PhoneBrand=@PhoneBrand, PhoneModel=@PhoneModel
WHERE PId=@PId";

				var parameters = new SqlParameterBuilder()
					.AddNVarchar("PhoneBrand", 50, phoneBrand)
					.AddNVarchar("PhoneModel", 50, phoneModel)
					.AddInt("PId", this.id)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			string sql = @"DELETE FROM Phone WHERE PId=@PId";
			try
			{
				var parameters = new SqlParameterBuilder()
				.AddInt("PId", this.id)
				.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("存在用戶資料中.不可刪除");
			}
		}

		private void EditPhone_Load(object sender, EventArgs e)
		{

		}
	}
}
