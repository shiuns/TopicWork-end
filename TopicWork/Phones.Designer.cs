namespace TopicWork
{
	partial class Phones
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
			this.addButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phonesAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phonesAllBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// addButton
			// 
			this.addButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addButton.Location = new System.Drawing.Point(251, 566);
			this.addButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(238, 57);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "新增手機品項";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(42, 29);
			this.searchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(280, 33);
			this.searchTextBox.TabIndex = 0;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(355, 29);
			this.searchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(134, 38);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "搜尋手機品牌";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.phoneBrandDataGridViewTextBoxColumn,
            this.phoneModelDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.phonesAllBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(42, 92);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(447, 442);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// pidDataGridViewTextBoxColumn
			// 
			this.pidDataGridViewTextBoxColumn.DataPropertyName = "Pid";
			this.pidDataGridViewTextBoxColumn.HeaderText = "序號";
			this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
			this.pidDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneBrandDataGridViewTextBoxColumn
			// 
			this.phoneBrandDataGridViewTextBoxColumn.DataPropertyName = "PhoneBrand";
			this.phoneBrandDataGridViewTextBoxColumn.HeaderText = "手機品牌";
			this.phoneBrandDataGridViewTextBoxColumn.Name = "phoneBrandDataGridViewTextBoxColumn";
			this.phoneBrandDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneBrandDataGridViewTextBoxColumn.Width = 150;
			// 
			// phoneModelDataGridViewTextBoxColumn
			// 
			this.phoneModelDataGridViewTextBoxColumn.DataPropertyName = "PhoneModel";
			this.phoneModelDataGridViewTextBoxColumn.HeaderText = "手機型號";
			this.phoneModelDataGridViewTextBoxColumn.Name = "phoneModelDataGridViewTextBoxColumn";
			this.phoneModelDataGridViewTextBoxColumn.ReadOnly = true;
			this.phoneModelDataGridViewTextBoxColumn.Width = 150;
			// 
			// phonesAllBindingSource
			// 
			this.phonesAllBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.PhonesAll);
			// 
			// Phones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(527, 638);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Phones";
			this.Text = "手機品項管理";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phonesAllBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource phonesAllBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneBrandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneModelDataGridViewTextBoxColumn;
	}
}