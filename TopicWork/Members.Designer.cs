namespace TopicWork
{
	partial class Members
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.addButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.合約與月租編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.手機品牌與型號編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.管理者編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.identityNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractExpiredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.memberIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.memberIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.identityNumberDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.contractExpiredDataGridViewTextBoxColumn,
            this.contractNameDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn,
            this.phoneBrandDataGridViewTextBoxColumn,
            this.phoneModelDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.memberIndexVMBindingSource;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
			this.dataGridView1.Location = new System.Drawing.Point(51, 117);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(995, 484);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.searchButton.Location = new System.Drawing.Point(356, 61);
			this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(120, 28);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "搜尋電話號碼";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(51, 61);
			this.searchTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.searchTextBox.MaxLength = 10;
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(264, 27);
			this.searchTextBox.TabIndex = 0;
			// 
			// addButton
			// 
			this.addButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addButton.Location = new System.Drawing.Point(905, 61);
			this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(141, 37);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "新增用戶";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.合約與月租編輯ToolStripMenuItem,
            this.手機品牌與型號編輯ToolStripMenuItem,
            this.管理者編輯ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
			this.menuStrip1.Size = new System.Drawing.Size(1087, 31);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 合約與月租編輯ToolStripMenuItem
			// 
			this.合約與月租編輯ToolStripMenuItem.Name = "合約與月租編輯ToolStripMenuItem";
			this.合約與月租編輯ToolStripMenuItem.Size = new System.Drawing.Size(126, 23);
			this.合約與月租編輯ToolStripMenuItem.Text = "編輯合約與月租";
			this.合約與月租編輯ToolStripMenuItem.Click += new System.EventHandler(this.合約與月租編輯ToolStripMenuItem_Click);
			// 
			// 手機品牌與型號編輯ToolStripMenuItem
			// 
			this.手機品牌與型號編輯ToolStripMenuItem.Name = "手機品牌與型號編輯ToolStripMenuItem";
			this.手機品牌與型號編輯ToolStripMenuItem.Size = new System.Drawing.Size(156, 23);
			this.手機品牌與型號編輯ToolStripMenuItem.Text = "編輯手機品牌與型號";
			this.手機品牌與型號編輯ToolStripMenuItem.Click += new System.EventHandler(this.手機品牌與型號編輯ToolStripMenuItem_Click);
			// 
			// 管理者編輯ToolStripMenuItem
			// 
			this.管理者編輯ToolStripMenuItem.Name = "管理者編輯ToolStripMenuItem";
			this.管理者編輯ToolStripMenuItem.Size = new System.Drawing.Size(96, 23);
			this.管理者編輯ToolStripMenuItem.Text = "編輯管理者";
			this.管理者編輯ToolStripMenuItem.Click += new System.EventHandler(this.管理者編輯ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "姓名";
			this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 90;
			// 
			// identityNumberDataGridViewTextBoxColumn
			// 
			this.identityNumberDataGridViewTextBoxColumn.DataPropertyName = "IdentityNumber";
			this.identityNumberDataGridViewTextBoxColumn.HeaderText = "身分證字號";
			this.identityNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.identityNumberDataGridViewTextBoxColumn.Name = "identityNumberDataGridViewTextBoxColumn";
			this.identityNumberDataGridViewTextBoxColumn.ReadOnly = true;
			this.identityNumberDataGridViewTextBoxColumn.Width = 110;
			// 
			// phoneNumberDataGridViewTextBoxColumn
			// 
			this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
			this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "手機號碼";
			this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
			this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneNumberDataGridViewTextBoxColumn.Width = 110;
			// 
			// contractExpiredDataGridViewTextBoxColumn
			// 
			this.contractExpiredDataGridViewTextBoxColumn.DataPropertyName = "ContractExpired";
			this.contractExpiredDataGridViewTextBoxColumn.HeaderText = "合約到期日";
			this.contractExpiredDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.contractExpiredDataGridViewTextBoxColumn.Name = "contractExpiredDataGridViewTextBoxColumn";
			this.contractExpiredDataGridViewTextBoxColumn.ReadOnly = true;
			this.contractExpiredDataGridViewTextBoxColumn.Width = 110;
			// 
			// contractNameDataGridViewTextBoxColumn
			// 
			this.contractNameDataGridViewTextBoxColumn.DataPropertyName = "ContractName";
			this.contractNameDataGridViewTextBoxColumn.HeaderText = "合約名稱";
			this.contractNameDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.contractNameDataGridViewTextBoxColumn.Name = "contractNameDataGridViewTextBoxColumn";
			this.contractNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.contractNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// contractDataGridViewTextBoxColumn
			// 
			this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
			this.contractDataGridViewTextBoxColumn.HeaderText = "月租費";
			this.contractDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
			this.contractDataGridViewTextBoxColumn.ReadOnly = true;
			this.contractDataGridViewTextBoxColumn.Width = 110;
			// 
			// phoneBrandDataGridViewTextBoxColumn
			// 
			this.phoneBrandDataGridViewTextBoxColumn.DataPropertyName = "PhoneBrand";
			this.phoneBrandDataGridViewTextBoxColumn.HeaderText = "手機品牌";
			this.phoneBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.phoneBrandDataGridViewTextBoxColumn.Name = "phoneBrandDataGridViewTextBoxColumn";
			this.phoneBrandDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneBrandDataGridViewTextBoxColumn.Width = 110;
			// 
			// phoneModelDataGridViewTextBoxColumn
			// 
			this.phoneModelDataGridViewTextBoxColumn.DataPropertyName = "PhoneModel";
			this.phoneModelDataGridViewTextBoxColumn.HeaderText = "手機型號";
			this.phoneModelDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.phoneModelDataGridViewTextBoxColumn.Name = "phoneModelDataGridViewTextBoxColumn";
			this.phoneModelDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneModelDataGridViewTextBoxColumn.Width = 150;
			// 
			// memberIndexVMBindingSource
			// 
			this.memberIndexVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.MemberIndexVM);
			// 
			// Members
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(1087, 637);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Members";
			this.Text = "用戶資訊";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Members_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.memberIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.BindingSource memberIndexVMBindingSource;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 合約與月租編輯ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 手機品牌與型號編輯ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 管理者編輯ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn identityNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contractExpiredDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contractNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneBrandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneModelDataGridViewTextBoxColumn;
	}
}