namespace TopicWork
{
	partial class UsersForm
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
			this.addNewButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.uidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.accountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// addNewButton
			// 
			this.addNewButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addNewButton.Location = new System.Drawing.Point(274, 15);
			this.addNewButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.addNewButton.Name = "addNewButton";
			this.addNewButton.Size = new System.Drawing.Size(187, 46);
			this.addNewButton.TabIndex = 3;
			this.addNewButton.Text = "新增管理者";
			this.addNewButton.UseVisualStyleBackColor = true;
			this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uidDataGridViewTextBoxColumn,
            this.accountDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.userIndexVMBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(193, 85);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(268, 384);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(14, 183);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(168, 138);
			this.pictureBox2.TabIndex = 4;
			this.pictureBox2.TabStop = false;
			// 
			// uidDataGridViewTextBoxColumn
			// 
			this.uidDataGridViewTextBoxColumn.DataPropertyName = "Uid";
			this.uidDataGridViewTextBoxColumn.HeaderText = "序別";
			this.uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
			this.uidDataGridViewTextBoxColumn.ReadOnly = true;
			this.uidDataGridViewTextBoxColumn.Width = 90;
			// 
			// accountDataGridViewTextBoxColumn
			// 
			this.accountDataGridViewTextBoxColumn.DataPropertyName = "Account";
			this.accountDataGridViewTextBoxColumn.HeaderText = "管理者帳號";
			this.accountDataGridViewTextBoxColumn.Name = "accountDataGridViewTextBoxColumn";
			this.accountDataGridViewTextBoxColumn.ReadOnly = true;
			this.accountDataGridViewTextBoxColumn.Width = 130;
			// 
			// userIndexVMBindingSource
			// 
			this.userIndexVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.UserIndexVM);
			// 
			// UsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(512, 505);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.addNewButton);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "UsersForm";
			this.Text = "使用者管理";
			this.Load += new System.EventHandler(this.UsersForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addNewButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.BindingSource userIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn;
	}
}