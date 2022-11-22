using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Models.ViewModels;

namespace TopicWork
{
	public partial class Phones : Form
	{
		private PhonesAll[] Phone;
		DataTable phones;
		public Phones()
		{
			InitializeComponent();
			DisplayPhoneAll();
			DisplayPhoneSearch();
		}

		private void DisplayPhoneAll()
		{
			string sql = @"SELECT Pid
      ,PhoneBrand
      ,PhoneModel FROM Phone ";

			phones = new SqlDbHelper("default").Select(sql, null);

			BindData(phones);
		}

		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}
		private void DisplayPhoneSearch()
		{
			string sql = @"SELECT  Pid
						,PhoneBrand
						,PhoneModel FROM Phone";
			SqlParameter[] parameters = new SqlParameter[] { };

			string searchText = searchTextBox.Text;

			if (searchText != string.Empty)
			{
				sql += " WHERE PhoneBrand=@PhoneBrand";
				parameters = new SqlParameterBuilder()
				.AddNVarchar("PhoneBrand",50 , searchText)
				.Build();
			}


			var dbHelper = new SqlDbHelper("default");
			Phone = dbHelper.Select(sql, parameters)
				.AsEnumerable()
				.Select(row => ParseToIndexVM(row))
				.ToArray();

			BindData1(Phone);
		}

		private PhonesAll ParseToIndexVM(DataRow row)
		{
			return new PhonesAll()
			{
				Pid = row.Field<int>("PId"),
				PhoneBrand = row.Field<string>("PhoneBrand"),
				PhoneModel = row.Field<string>("PhoneModel"),
			};
		}
		private void BindData1(PhonesAll[] data)
		{
			dataGridView1.DataSource = data;
		}
		private void searchButton_Click_1(object sender, EventArgs e)
		{
			DisplayPhoneSearch();
		}
		private void addButton_Click_1(object sender, EventArgs e)
		{
			var frm = new CreatePhone();
			
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayPhoneAll();
			}
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			DataRow row = this.phones.Rows[rowIndx]; 
			int id = row.Field<int>("PId"); 

			var frm = new EditPhone(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayPhoneAll();
			}
		}
	}
}
