namespace TopicWork
{
	partial class EditPhone
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
			this.PhoneModelTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.PhoneBrandTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updateButton.Location = new System.Drawing.Point(124, 181);
			this.updateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(88, 31);
			this.updateButton.TabIndex = 2;
			this.updateButton.Text = "修改";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deleteButton.Location = new System.Drawing.Point(243, 181);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(88, 31);
			this.deleteButton.TabIndex = 3;
			this.deleteButton.Text = "刪除";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// PhoneModelTextBox
			// 
			this.PhoneModelTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PhoneModelTextBox.Location = new System.Drawing.Point(124, 108);
			this.PhoneModelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PhoneModelTextBox.MaxLength = 15;
			this.PhoneModelTextBox.Name = "PhoneModelTextBox";
			this.PhoneModelTextBox.Size = new System.Drawing.Size(207, 33);
			this.PhoneModelTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(26, 97);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 24);
			this.label2.TabIndex = 16;
			this.label2.Text = "手機型號:";
			// 
			// PhoneBrandTextBox
			// 
			this.PhoneBrandTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PhoneBrandTextBox.Location = new System.Drawing.Point(124, 50);
			this.PhoneBrandTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.PhoneBrandTextBox.MaxLength = 15;
			this.PhoneBrandTextBox.Name = "PhoneBrandTextBox";
			this.PhoneBrandTextBox.Size = new System.Drawing.Size(207, 33);
			this.PhoneBrandTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(26, 53);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "手機品牌:";
			// 
			// EditPhone
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(364, 233);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.PhoneModelTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PhoneBrandTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "EditPhone";
			this.Text = "編輯手機品項";
			this.Load += new System.EventHandler(this.EditPhone_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button deleteButton;
		private System.Windows.Forms.TextBox PhoneModelTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PhoneBrandTextBox;
		private System.Windows.Forms.Label label1;
	}
}