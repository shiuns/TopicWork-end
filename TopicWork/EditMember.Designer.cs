namespace TopicWork
{
    partial class EditMember
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
			this.deleteButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.IdentityTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// deleteButton
			// 
			this.deleteButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deleteButton.Location = new System.Drawing.Point(344, 244);
			this.deleteButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(138, 46);
			this.deleteButton.TabIndex = 4;
			this.deleteButton.Text = "解約";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.updateButton.Location = new System.Drawing.Point(154, 244);
			this.updateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(138, 46);
			this.updateButton.TabIndex = 3;
			this.updateButton.Text = "資料修改";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(50, 186);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 24);
			this.label2.TabIndex = 10;
			this.label2.Text = "電話號碼:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(50, 121);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 24);
			this.label3.TabIndex = 8;
			this.label3.Text = "證號:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(50, 58);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 24);
			this.label1.TabIndex = 9;
			this.label1.Text = "姓名:";
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.PhoneTextBox.Location = new System.Drawing.Point(154, 183);
			this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.PhoneTextBox.MaxLength = 10;
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(326, 33);
			this.PhoneTextBox.TabIndex = 2;
			// 
			// IdentityTextBox
			// 
			this.IdentityTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.IdentityTextBox.Location = new System.Drawing.Point(154, 118);
			this.IdentityTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.IdentityTextBox.MaxLength = 10;
			this.IdentityTextBox.Name = "IdentityTextBox";
			this.IdentityTextBox.Size = new System.Drawing.Size(326, 33);
			this.IdentityTextBox.TabIndex = 1;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.NameTextBox.Location = new System.Drawing.Point(154, 49);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.NameTextBox.MaxLength = 15;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(326, 33);
			this.NameTextBox.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// EditMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(522, 328);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PhoneTextBox);
			this.Controls.Add(this.IdentityTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "EditMember";
			this.Text = "編輯用戶資料";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox IdentityTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}