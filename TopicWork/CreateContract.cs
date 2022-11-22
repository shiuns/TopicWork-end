using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Infra.Extensions;
using TopicWork.Models.Services;

namespace TopicWork
{
	public partial class CreateContract : Form
	{
		public CreateContract()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			try
			{
				//new UserService().Create(model);

				//this.DialogResult = DialogResult.OK;
			string contractName = ContractNameTextBox.Text;

			// ToInt可以將字串轉換成int,若轉換失敗,傳回預設值 -1
			int contract = ContractTextBox.Text.ToInt(-1);
			if (string.IsNullOrEmpty(contractName)) throw new Exception("合約名稱不可空白");
			if (contract == -1) throw new Exception("請輸入整數");
			 
			string sql = @"INSERT INTO Contract
(ContractName, Contract)
VALUES
(@ContractName, @Contract)";

			var parameters = new SqlParameterBuilder()
				.AddNVarchar("ContractName", 50, contractName)
				.AddInt("Contract", contract)
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
