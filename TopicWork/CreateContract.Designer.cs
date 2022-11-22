namespace TopicWork
{
	partial class CreateContract
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
			this.saveButton = new System.Windows.Forms.Button();
			this.ContractTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ContractNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(346, 168);
			this.saveButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(138, 46);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// ContractTextBox
			// 
			this.ContractTextBox.Location = new System.Drawing.Point(159, 99);
			this.ContractTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.ContractTextBox.MaxLength = 10;
			this.ContractTextBox.Name = "ContractTextBox";
			this.ContractTextBox.Size = new System.Drawing.Size(323, 33);
			this.ContractTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 105);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "月租費:";
			// 
			// ContractNameTextBox
			// 
			this.ContractNameTextBox.Location = new System.Drawing.Point(159, 43);
			this.ContractNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.ContractNameTextBox.MaxLength = 20;
			this.ContractNameTextBox.Name = "ContractNameTextBox";
			this.ContractNameTextBox.Size = new System.Drawing.Size(323, 33);
			this.ContractNameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 49);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "合約名稱:";
			// 
			// CreateContract
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(505, 237);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.ContractTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ContractNameTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "CreateContract";
			this.Text = "新增月租品項";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox ContractTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox ContractNameTextBox;
		private System.Windows.Forms.Label label1;
	}
}