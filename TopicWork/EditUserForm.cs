using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TopicWork.Infra;
using TopicWork.Models.Services;
using TopicWork.Models.ViewModels;

namespace TopicWork
{
	public partial class EditUserForm : Form
	{
		private int id;
		public EditUserForm(int id)
		{
			InitializeComponent();

			this.Load += EditUserForm_Load;
			this.id = id;
		}

		private void EditUserForm_Load(object sender, EventArgs e)
		{
			BindData(id);
		}

		private void BindData(int id)
		{
			UserVM model = new UserService().Get(id);

			// 再將 viewModel值繫結到各控制項
			accountTextBox.Text = model.Account;
			passwordTextBox.Text = model.Password;
		}
		private void updateButton_Click_1(object sender, EventArgs e)
		{
			// 取得表單的各欄位值
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;

			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
				Uid = this.id,
				Account = account,
				Password = password,
			};

			// 針對ViewModel進行欄位驗證
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// update record
			try
			{
				new UserService().Update(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void deleteButton_Click_1(object sender, EventArgs e)
		{
			if (MessageBox
				.Show("您真的要刪除嗎?",
						"刪除記錄",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}

			new UserService().Delete(this.id);

			this.DialogResult = DialogResult.OK;
		}
	}
}
