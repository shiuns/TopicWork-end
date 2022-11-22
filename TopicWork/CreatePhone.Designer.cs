namespace TopicWork
{
	partial class CreatePhone
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
			this.PhoneModelTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.PhoneBrandTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.saveButton.Location = new System.Drawing.Point(282, 175);
			this.saveButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(138, 46);
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// PhoneModelTextBox
			// 
			this.PhoneModelTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PhoneModelTextBox.Location = new System.Drawing.Point(152, 105);
			this.PhoneModelTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.PhoneModelTextBox.MaxLength = 20;
			this.PhoneModelTextBox.Name = "PhoneModelTextBox";
			this.PhoneModelTextBox.Size = new System.Drawing.Size(266, 33);
			this.PhoneModelTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(39, 111);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "手機型號:";
			// 
			// PhoneBrandTextBox
			// 
			this.PhoneBrandTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PhoneBrandTextBox.Location = new System.Drawing.Point(154, 41);
			this.PhoneBrandTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.PhoneBrandTextBox.MaxLength = 20;
			this.PhoneBrandTextBox.Name = "PhoneBrandTextBox";
			this.PhoneBrandTextBox.Size = new System.Drawing.Size(266, 33);
			this.PhoneBrandTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(41, 47);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "手機品牌:";
			// 
			// CreatePhone
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(449, 245);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.PhoneModelTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PhoneBrandTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "CreatePhone";
			this.Text = "新增手機品項";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TextBox PhoneModelTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PhoneBrandTextBox;
		private System.Windows.Forms.Label label1;
	}
}