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
using TopicWork.Infra;
using TopicWork.Infra.Extensions;
using TopicWork.Models.Services;
using TopicWork.Models.ViewModels;

namespace TopicWork
{
	public partial class LoginForm : Form
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			pictureBox1.Image = Properties.Resources.icons8_male_user_100;
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			LoginVM model = new LoginVM
			{
				Account = accountTextBox.Text,
				Password = passwordTextBox.Text
			};

			// 驗證欄位輸入是否正確
			Dictionary<string, Control> map = new Dictionary<string, Control>(StringComparer.CurrentCultureIgnoreCase)
			{
				{"Account", accountTextBox},
				{"Password", passwordTextBox},
			};

			bool isValid = ValidationHelper.Validate(model, map, errorProvider1);
			if (!isValid) return;

			// 判斷帳密是否正確
			bool result = new UserService().Authenticate(model);
			if (result == false)
			{
				MessageBox.Show("帳號或密碼錯誤");
				return;
			}

			// 若正確, 就開啟MainForm
			accountTextBox.Text = String.Empty;
			passwordTextBox.Text = String.Empty;

			var frm = new Members();
			frm.Owner = this;

			frm.Show();
			this.Hide();
		}

		

		public UserVM Get(string account)
		{
			string sql = "SELECT * FROM Users WHERE Account=@Account";
			var parameters = new SqlParameterBuilder()
				.AddNVarchar("Account", 50, account)
				.Build();

			DataTable data = new SqlDbHelper("default").Select(sql, parameters);

			if (data.Rows.Count == 0)
			{
				return null;
			}

			// 將找到的一筆記錄由DataTable 轉換到 UserVM
			return ToUserVM(data.Rows[0]);
		}
		private UserVM ToUserVM(DataRow row)
		{
			return new UserVM
			{
				Uid = row.Field<int>("UId"),
				Account = row.Field<string>("Account"),
				Password = row.Field<string>("Password"),
			};
		}

	}
}
