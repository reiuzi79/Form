namespace 身份证信息管理系统
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.account = new System.Windows.Forms.TextBox();
            this.psw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.regist = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(118, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用身份证信息管理系统";
            // 
            // account
            // 
            this.account.Location = new System.Drawing.Point(117, 67);
            this.account.MaxLength = 30;
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(198, 21);
            this.account.TabIndex = 1;
            // 
            // psw
            // 
            this.psw.Location = new System.Drawing.Point(117, 107);
            this.psw.MaxLength = 50;
            this.psw.Name = "psw";
            this.psw.PasswordChar = '*';
            this.psw.Size = new System.Drawing.Size(198, 21);
            this.psw.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(66, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "验证码";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(66, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(66, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "账号";
            // 
            // checkcode
            // 
            this.checkcode.Location = new System.Drawing.Point(117, 148);
            this.checkcode.Name = "checkcode";
            this.checkcode.Size = new System.Drawing.Size(87, 21);
            this.checkcode.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(293, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "看不清点击图片";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(41, 197);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 6;
            this.login.Text = "登录";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // regist
            // 
            this.regist.Location = new System.Drawing.Point(142, 197);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(75, 23);
            this.regist.TabIndex = 7;
            this.regist.Text = "注册";
            this.regist.UseVisualStyleBackColor = true;
            this.regist.Click += new System.EventHandler(this.regist_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(318, 197);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "取消";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // check
            // 
            this.check.Font = new System.Drawing.Font("黑体", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check.Image = ((System.Drawing.Image)(resources.GetObject("check.Image")));
            this.check.Location = new System.Drawing.Point(220, 148);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(67, 23);
            this.check.TabIndex = 4;
            this.check.Text = "12345";
            this.check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.regist);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkcode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.psw);
            this.groupBox1.Controls.Add(this.account);
            this.groupBox1.Location = new System.Drawing.Point(119, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请登录";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "修改密码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(650, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox account;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox checkcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button regist;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}