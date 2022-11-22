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
	public partial class CreatePhone : Form
	{
		public CreatePhone()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string phoneBrand = PhoneBrandTextBox.Text;

			string phoneModel = PhoneModelTextBox.Text;
			try
			{
				if (string.IsNullOrEmpty(phoneBrand)) throw new Exception("手機品牌不可空白");
				if (string.IsNullOrEmpty(phoneModel)) throw new Exception("手機型號不可空白");
				string sql = @"INSERT INTO Phone
(PhoneBrand, PhoneModel)
VALUES
(@PhoneBrand, @PhoneModel)";

				var parameters = new SqlParameterBuilder()
					.AddNVarchar("PhoneBrand", 50, phoneBrand)
					.AddNVarchar("PhoneModel", 50, phoneModel)
					.Build();

				new SqlDbHelper("default").ExecuteNonQuery(sql, parameters);

				// MessageBox.Show("記錄已新增");
				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}
	}
}
