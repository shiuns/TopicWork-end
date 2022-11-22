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
	public partial class CreateUserForm : Form
	{
		public CreateUserForm()
		{
			InitializeComponent();
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string account = accountTextBox.Text;
			string password = passwordTextBox.Text;

			// 將它們繫結到ViewModel
			UserVM model = new UserVM
			{
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


			// 如果通過驗證,就新增記錄
			try
			{
				new UserService().Create(model);

				this.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("新增失敗, 原因: " + ex.Message);
			}
		}
	}
}
