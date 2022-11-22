using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Models.Services;
using TopicWork.Models.ViewModels;

namespace TopicWork
{
	public partial class UsersForm : Form
	{
		private UserIndexVM[] users = null;

		public UsersForm()
		{
			InitializeComponent();

			// 顯示記錄
			DisplayUsers();
		}
		private void DisplayUsers()
		{
			users = new UserService().GetAll().ToArray();
			BindData(users);
		}
		private void BindData(UserIndexVM[] data)
		{
			dataGridView1.DataSource = data;
		}

		private void addNewButton_Click(object sender, EventArgs e)
		{
			var frm = new CreateUserForm();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayUsers();
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndx = e.RowIndex;

			if (rowIndx < 0) return;

			UserIndexVM row = this.users[rowIndx]; // 使用者點到的那一筆記錄

			int id = row.Uid; // 使用者點到的那一筆記錄的id值

			// 把 id 傳給編輯表單的建構函數
			var frm = new EditUserForm(id);

			if (frm.ShowDialog() == DialogResult.OK)
			{
				DisplayUsers();
			}
		}

		private void UsersForm_Load(object sender, EventArgs e)
		{
			pictureBox2.Image = Properties.Resources.icons8_system_administrator_male_96;
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
		}
	}
}
