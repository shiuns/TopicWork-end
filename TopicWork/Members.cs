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
    public partial class Members : Form
    {
        private MemberIndexVM[] Member;
        public Members()
        {
            InitializeComponent();
            DisplayMembers();
		}

		private MemberIndexVM ParseToIndexVM(DataRow row)
        {
            return new MemberIndexVM()
            {
                mId = row.Field<int>("mId"),
                Name = row.Field<string>("Name"),
                IdentityNumber = row.Field<string>("IdentityNumber"),
                PhoneNumber = row.Field<string>("PhoneNumber"),
                ContractExpired = row.Field<DateTime>("ContractExpired"),
                ContractName = row.Field<string>("ContractName"),
                Contract = row.Field<int>("Contract"),
                PhoneBrand = row.Field<string>("PhoneBrand"),
                PhoneModel = row.Field<string>("PhoneModel"),
            };
        }

        private void DisplayMembers()
        {
            string sql = @"SELECT * 
						FROM Member M
						left join Contract C ON M.Contract_id = C.Cid
						left join Phone P ON M.Phone_id = P.Pid";


            SqlParameter[] parameters = new SqlParameter[] { };

            //取得篩選值
            string searchText = searchTextBox.Text;

            if (searchText != string.Empty)
            {
                sql += " WHERE PhoneNumber=@PhoneNumber";
                parameters = new SqlParameterBuilder()
                .AddNVarchar("PhoneNumber", 10, searchText)
                .Build();
            }


            var dbHelper = new SqlDbHelper("default");
            Member = dbHelper.Select(sql, parameters)
                .AsEnumerable()
                .Select(row => ParseToIndexVM(row))
                .ToArray();

            BindData(Member);
        }

        private void BindData(MemberIndexVM[] data)
        {
            dataGridView1.DataSource = data;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row < 0) return;
            MemberIndexVM item = Member[row];
            int mid = item.mId;
            EditMember editUsers = new EditMember(mid);
            if (editUsers.ShowDialog() == DialogResult.OK) DisplayMembers();
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            DisplayMembers();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
			var frm = new CreateMember();
			DialogResult result = frm.ShowDialog();

			if (result == DialogResult.OK)
			{
				DisplayMembers();
			}
		}

        private void Members_FormClosing(object sender, FormClosingEventArgs e)
        {
			this.Owner.Show();
		}

        private void 合約與月租編輯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var frm = new Contracts();
			//frm.MdiParent = this;
			frm.Show();
		}

        private void 手機品牌與型號編輯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var frm = new Phones();
			//frm.MdiParent = this;
			frm.Show();
		}

        private void 管理者編輯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var frm = new UsersForm();
			//frm.MdiParent = this;
			frm.Show();
		}

        private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
			DialogResult result = MessageBox.Show("您確定要登出嗎?",
				"登出",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}
    }
}
