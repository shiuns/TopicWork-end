namespace TopicWork
{
    partial class CreateMember
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
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.phoneModelVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.phoneBrandVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ContractpaycomboBox = new System.Windows.Forms.ComboBox();
			this.contractVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ContractNamecomboBox = new System.Windows.Forms.ComboBox();
			this.contractNameVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.saveButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DateTextBox = new System.Windows.Forms.TextBox();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.IdentityTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.phoneModelVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneBrandVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contractVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contractNameVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox5
			// 
			this.comboBox5.DataSource = this.phoneModelVMBindingSource;
			this.comboBox5.DisplayMember = "PhoneModel";
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(532, 243);
			this.comboBox5.Margin = new System.Windows.Forms.Padding(5);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(179, 27);
			this.comboBox5.TabIndex = 7;
			this.comboBox5.ValueMember = "Pid";
			this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
			// 
			// phoneModelVMBindingSource
			// 
			this.phoneModelVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.PhoneModelVM);
			// 
			// comboBox4
			// 
			this.comboBox4.DataSource = this.phoneBrandVMBindingSource;
			this.comboBox4.DisplayMember = "PhoneBrand";
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(532, 180);
			this.comboBox4.Margin = new System.Windows.Forms.Padding(5);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(179, 27);
			this.comboBox4.TabIndex = 6;
			this.comboBox4.ValueMember = "Pid";
			this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
			// 
			// phoneBrandVMBindingSource
			// 
			this.phoneBrandVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.PhoneBrandVM);
			// 
			// ContractpaycomboBox
			// 
			this.ContractpaycomboBox.DataSource = this.contractVMBindingSource;
			this.ContractpaycomboBox.DisplayMember = "Contract";
			this.ContractpaycomboBox.FormattingEnabled = true;
			this.ContractpaycomboBox.Location = new System.Drawing.Point(532, 108);
			this.ContractpaycomboBox.Margin = new System.Windows.Forms.Padding(5);
			this.ContractpaycomboBox.Name = "ContractpaycomboBox";
			this.ContractpaycomboBox.Size = new System.Drawing.Size(179, 27);
			this.ContractpaycomboBox.TabIndex = 5;
			this.ContractpaycomboBox.ValueMember = "Cid";
			this.ContractpaycomboBox.SelectedIndexChanged += new System.EventHandler(this.ContractpaycomboBox_SelectedIndexChanged);
			// 
			// contractVMBindingSource
			// 
			this.contractVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.ContractVM);
			// 
			// ContractNamecomboBox
			// 
			this.ContractNamecomboBox.DataSource = this.contractNameVMBindingSource;
			this.ContractNamecomboBox.DisplayMember = "ContractName";
			this.ContractNamecomboBox.FormattingEnabled = true;
			this.ContractNamecomboBox.Location = new System.Drawing.Point(532, 34);
			this.ContractNamecomboBox.Margin = new System.Windows.Forms.Padding(5);
			this.ContractNamecomboBox.Name = "ContractNamecomboBox";
			this.ContractNamecomboBox.Size = new System.Drawing.Size(179, 27);
			this.ContractNamecomboBox.TabIndex = 4;
			this.ContractNamecomboBox.ValueMember = "Cid";
			this.ContractNamecomboBox.SelectedIndexChanged += new System.EventHandler(this.ContractNamecomboBox_SelectedIndexChanged);
			// 
			// contractNameVMBindingSource
			// 
			this.contractNameVMBindingSource.DataSource = typeof(TopicWork.Models.ViewModels.ContractNameVM);
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.saveButton.Location = new System.Drawing.Point(273, 298);
			this.saveButton.Margin = new System.Windows.Forms.Padding(5);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(224, 49);
			this.saveButton.TabIndex = 8;
			this.saveButton.Text = "儲存";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(44, 251);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 19);
			this.label4.TabIndex = 23;
			this.label4.Text = "合約到期日:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(44, 180);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 19);
			this.label2.TabIndex = 24;
			this.label2.Text = "電話號碼:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(44, 113);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 19);
			this.label3.TabIndex = 17;
			this.label3.Text = "身分證號碼:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(436, 247);
			this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 19);
			this.label8.TabIndex = 22;
			this.label8.Text = "手機型號:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(436, 184);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 19);
			this.label7.TabIndex = 21;
			this.label7.Text = "手機品牌:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(451, 112);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 19);
			this.label6.TabIndex = 20;
			this.label6.Text = "月租費:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(436, 43);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 19);
			this.label5.TabIndex = 19;
			this.label5.Text = "合約名稱:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(44, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 19);
			this.label1.TabIndex = 18;
			this.label1.Text = "姓名:";
			// 
			// DateTextBox
			// 
			this.DateTextBox.Location = new System.Drawing.Point(156, 241);
			this.DateTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.DateTextBox.MaxLength = 10;
			this.DateTextBox.Name = "DateTextBox";
			this.DateTextBox.Size = new System.Drawing.Size(214, 27);
			this.DateTextBox.TabIndex = 3;
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(138, 176);
			this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.PhoneTextBox.MaxLength = 10;
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(232, 27);
			this.PhoneTextBox.TabIndex = 2;
			// 
			// IdentityTextBox
			// 
			this.IdentityTextBox.Location = new System.Drawing.Point(156, 108);
			this.IdentityTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.IdentityTextBox.MaxLength = 10;
			this.IdentityTextBox.Name = "IdentityTextBox";
			this.IdentityTextBox.Size = new System.Drawing.Size(214, 27);
			this.IdentityTextBox.TabIndex = 1;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(102, 37);
			this.NameTextBox.Margin = new System.Windows.Forms.Padding(5);
			this.NameTextBox.MaxLength = 20;
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(268, 27);
			this.NameTextBox.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreateMember
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AntiqueWhite;
			this.ClientSize = new System.Drawing.Size(773, 361);
			this.Controls.Add(this.comboBox5);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.ContractpaycomboBox);
			this.Controls.Add(this.ContractNamecomboBox);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DateTextBox);
			this.Controls.Add(this.PhoneTextBox);
			this.Controls.Add(this.IdentityTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "CreateMember";
			this.Text = "新增用戶";
			((System.ComponentModel.ISupportInitialize)(this.phoneModelVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneBrandVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contractVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contractNameVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox ContractpaycomboBox;
        private System.Windows.Forms.ComboBox ContractNamecomboBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox IdentityTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource phoneModelVMBindingSource;
        private System.Windows.Forms.BindingSource phoneBrandVMBindingSource;
        private System.Windows.Forms.BindingSource contractVMBindingSource;
        private System.Windows.Forms.BindingSource contractNameVMBindingSource;
    }
}