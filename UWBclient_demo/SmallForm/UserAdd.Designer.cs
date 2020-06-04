namespace UWBclient_demo
{
    partial class UserAdd
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
            this.UA_tb_name = new System.Windows.Forms.TextBox();
            this.UA_tb_username = new System.Windows.Forms.TextBox();
            this.UA_tb_password = new System.Windows.Forms.TextBox();
            this.UA_tb_description = new System.Windows.Forms.TextBox();
            this.UA_cb_right = new System.Windows.Forms.ComboBox();
            this.UA_btn_Cancel = new System.Windows.Forms.Button();
            this.UA_btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UA_tb_name
            // 
            this.UA_tb_name.Location = new System.Drawing.Point(129, 50);
            this.UA_tb_name.Name = "UA_tb_name";
            this.UA_tb_name.Size = new System.Drawing.Size(122, 21);
            this.UA_tb_name.TabIndex = 0;
            // 
            // UA_tb_username
            // 
            this.UA_tb_username.Location = new System.Drawing.Point(129, 102);
            this.UA_tb_username.Name = "UA_tb_username";
            this.UA_tb_username.Size = new System.Drawing.Size(122, 21);
            this.UA_tb_username.TabIndex = 0;
            // 
            // UA_tb_password
            // 
            this.UA_tb_password.Location = new System.Drawing.Point(129, 147);
            this.UA_tb_password.Name = "UA_tb_password";
            this.UA_tb_password.Size = new System.Drawing.Size(122, 21);
            this.UA_tb_password.TabIndex = 0;
            // 
            // UA_tb_description
            // 
            this.UA_tb_description.Location = new System.Drawing.Point(129, 190);
            this.UA_tb_description.Multiline = true;
            this.UA_tb_description.Name = "UA_tb_description";
            this.UA_tb_description.Size = new System.Drawing.Size(167, 52);
            this.UA_tb_description.TabIndex = 0;
            this.UA_tb_description.Text = "无";
            // 
            // UA_cb_right
            // 
            this.UA_cb_right.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UA_cb_right.FormattingEnabled = true;
            this.UA_cb_right.Items.AddRange(new object[] {
            "Root",
            "Administrator",
            "Guest"});
            this.UA_cb_right.Location = new System.Drawing.Point(129, 271);
            this.UA_cb_right.Name = "UA_cb_right";
            this.UA_cb_right.Size = new System.Drawing.Size(143, 20);
            this.UA_cb_right.TabIndex = 1;
            // 
            // UA_btn_Cancel
            // 
            this.UA_btn_Cancel.Location = new System.Drawing.Point(208, 332);
            this.UA_btn_Cancel.Name = "UA_btn_Cancel";
            this.UA_btn_Cancel.Size = new System.Drawing.Size(75, 24);
            this.UA_btn_Cancel.TabIndex = 4;
            this.UA_btn_Cancel.Text = "取消";
            this.UA_btn_Cancel.UseVisualStyleBackColor = true;
            this.UA_btn_Cancel.Click += new System.EventHandler(this.btn_UserAdd_Cancel_Click);
            // 
            // UA_btn_Save
            // 
            this.UA_btn_Save.Location = new System.Drawing.Point(60, 332);
            this.UA_btn_Save.Name = "UA_btn_Save";
            this.UA_btn_Save.Size = new System.Drawing.Size(75, 24);
            this.UA_btn_Save.TabIndex = 5;
            this.UA_btn_Save.Text = "保存";
            this.UA_btn_Save.UseVisualStyleBackColor = true;
            this.UA_btn_Save.Click += new System.EventHandler(this.UA_btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "角色名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "描述";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "权限等级";
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UA_tb_name);
            this.Controls.Add(this.UA_tb_username);
            this.Controls.Add(this.UA_tb_password);
            this.Controls.Add(this.UA_tb_description);
            this.Controls.Add(this.UA_cb_right);
            this.Controls.Add(this.UA_btn_Save);
            this.Controls.Add(this.UA_btn_Cancel);
            this.Name = "UserAdd";
            this.Text = "UserAdd";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UA_tb_name;
        private System.Windows.Forms.TextBox UA_tb_username;
        private System.Windows.Forms.TextBox UA_tb_password;
        private System.Windows.Forms.TextBox UA_tb_description;
        private System.Windows.Forms.ComboBox UA_cb_right;
        private System.Windows.Forms.Button UA_btn_Cancel;
        private System.Windows.Forms.Button UA_btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}