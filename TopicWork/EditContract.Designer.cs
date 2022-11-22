namespace TopicWork
{
	partial class EditContract
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
			this.updateButton = new System.Windows.Forms.Button();
			this.deleteButton = new System.Windows.Forms.Button();
			this.contractTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.contractNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updateButton.Location = new System.Drawing.Point(143, 172);
			this.updateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(138, 46);
			this.updateButton.TabIndex = 2;
			this.updateButton.Text = "修改";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deleteButton.Location = new System.Drawing.Point(328, 172);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(138, 46);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
			// 
			// contractTextBox
			// 
			this.contractTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.contractTextBox.Location = new System.Drawing.Point(143, 111);
			this.contractTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.contractTextBox.MaxLength = 20;
			this.contractTextBox.Name = "contractTextBox";
			this.contractTextBox.Size = new System.Drawing.Size(323, 33);
			this.contractTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(47, 114);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "月租費:";
			// 
			// contractNameTextBox
			// 
			this.contractNameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.contractNameTextBox.Location = new System.Drawing.Point(143, 36);
			this.contractNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.contractNameTextBox.MaxLength = 20;
			this.contractNameTextBox.Name = "contractNameTextBox";
			this.contractNameTextBox.Size = new System.Drawing.Size(323, 33);
			this.contractNameTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(28, 39);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 24);
			this.label1.TabIndex = 11;
			this.label1.Text = "合約名稱:";
			// 
			// EditContract
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(505, 245);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.contractTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.contractNameTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "EditContract";
			this.Text = "編輯合約品項";
			this.Load += new System.EventHandler(this.EditContract_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox contractTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox contractNameTextBox;
		private System.Windows.Forms.Label label1;
	}
}