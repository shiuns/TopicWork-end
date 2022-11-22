namespace TopicWork
{
	partial class Contracts
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
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.searchButton = new System.Windows.Forms.Button();
			this.addButton = new System.Windows.Forms.Button();
			this.contractNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contractsAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contractsAllBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Azure;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractNameDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.contractsAllBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(77, 128);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(347, 384);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(77, 62);
			this.searchTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.searchTextBox.MaxLength = 20;
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(172, 33);
			this.searchTextBox.TabIndex = 0;
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.searchButton.Location = new System.Drawing.Point(301, 60);
			this.searchButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(123, 41);
			this.searchButton.TabIndex = 1;
			this.searchButton.Text = "搜尋月租費";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// addButton
			// 
			this.addButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.addButton.Location = new System.Drawing.Point(226, 546);
			this.addButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(198, 62);
			this.addButton.TabIndex = 2;
			this.addButton.Text = "新增合約品項";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// contractNameDataGridViewTextBoxColumn
			// 
			this.contractNameDataGridViewTextBoxColumn.DataPropertyName = "ContractName";
			this.contractNameDataGridViewTextBoxColumn.HeaderText = "合約名稱";
			this.contractNameDataGridViewTextBoxColumn.Name = "contractNameDataGridViewTextBoxColumn";
			this.contractNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.contractNameDataGridViewTextBoxColumn.Width = 150;
			// 
			// contractDataGridViewTextBoxColumn
			// 
			this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
			this.contractDataGridViewTextBoxColumn.HeaderText = "月租費";
			this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
			this.contractDataGridViewTextBoxColumn.ReadOnly = true;
			this.contractDataGridViewTextBoxColumn.Width = 150;
			// 
			// contractsAllBindingSource
			// 
			this.contractsAllBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.ContractsAll);
			// 
			// Contracts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(475, 623);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Contracts";
			this.Text = "合約品項";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contractsAllBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.BindingSource contractsAllBindingSource;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn contractNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
	}
}