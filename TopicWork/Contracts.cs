using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Models.ViewModels;

namespace TopicWork
{
	public partial class Contracts : Form
	{
		private ContractsAll[] Contract;
		DataTable contracts;
		public Contracts()
		{
			InitializeComponent();
			DisplayContractAll();
			DisplayContractSearch();
		}

		private void DisplayContractAll()
		{
			string sql = @"SELECT Cid
      ,ContractName
      ,Contract FROM Contract ";

			contracts = new SqlDbHelper("default").Select(sql, null);

			BindData(contracts);
		}

		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			DataRow row = this.contracts.Rows[rowIndx]; // 使用者點到的那一筆記錄
			int id = row.Field<int>("CId"); // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditContract(id);
			// frm.Show();
			// DialogResult result = frm.ShowDialog();

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayContractAll();
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateContract();
			// frm.Show();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayContractAll();
			}
		}

		private void DisplayContractSearch()
		{
			string sql = @"SELECT Cid
						,ContractName
						,Contract FROM Contract";
			SqlParameter[] parameters = new SqlParameter[] { };

			//取得篩選值
			string searchText = searchTextBox.Text;

			if (searchText != string.Empty)
			{
				sql += " WHERE Contract=@Contract";
				parameters = new SqlParameterBuilder()
				.AddInt("Contract", Convert.ToInt32(searchText))
				.Build();
			}


			var dbHelper = new SqlDbHelper("default");
			Contract = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();

			BindData1(Contract);
		}

		private ContractsAll ParseToIndexVM(DataRow row)
		{
			return new ContractsAll()
			{
				Cid = row.Field<int>("CId"),
				ContractName = row.Field<string>("ContractName"),
				Contract = row.Field<int>("Contract"),
			};
		}
		private void BindData1(ContractsAll[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			DisplayContractSearch();
		}
	}
}