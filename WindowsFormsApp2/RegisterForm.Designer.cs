namespace 身份证信息管理系统
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.account = new System.Windows.Forms.Label();
            this.psw = new System.Windows.Forms.Label();
            this.sure = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.surepwd = new System.Windows.Forms.TextBox();
            this.nick = new System.Windows.Forms.TextBox();
            this.checkcode = new System.Windows.Forms.TextBox();
            this.checkpic = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regist = new System.Windows.Forms.Button();
            this.okCheckbox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.BackColor = System.Drawing.Color.Transparent;
            this.account.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.account.Location = new System.Drawing.Point(73, 82);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(37, 20);
            this.account.TabIndex = 0;
            this.account.Text = "账号";
            // 
            // psw
            // 
            this.psw.AutoSize = true;
            this.psw.BackColor = System.Drawing.Color.Transparent;
            this.psw.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.psw.Location = new System.Drawing.Point(73, 118);
            this.psw.Name = "psw";
            this.psw.Size = new System.Drawing.Size(37, 20);
            this.psw.TabIndex = 1;
            this.psw.Text = "密码";
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.BackColor = System.Drawing.Color.Transparent;
            this.sure.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sure.Location = new System.Drawing.Point(45, 154);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(65, 20);
            this.sure.TabIndex = 2;
            this.sure.Text = "确认密码";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name.Location = new System.Drawing.Point(73, 189);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 20);
            this.name.TabIndex = 3;
            this.name.Text = "昵称";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(59, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "验证码";
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(116, 82);
            this.acc.MaxLength = 25;
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(160, 21);
            this.acc.TabIndex = 5;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(116, 118);
            this.pwd.MaxLength = 25;
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = '*';
            this.pwd.Size = new System.Drawing.Size(160, 21);
            this.pwd.TabIndex = 6;
            // 
            // surepwd
            // 
            this.surepwd.Location = new System.Drawing.Point(116, 154);
            this.surepwd.MaxLength = 25;
            this.surepwd.Name = "surepwd";
            this.surepwd.PasswordChar = '*';
            this.surepwd.Size = new System.Drawing.Size(160, 21);
            this.surepwd.TabIndex = 7;
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(116, 189);
            this.nick.MaxLength = 25;
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(160, 21);
            this.nick.TabIndex = 8;
            // 
            // checkcode
            // 
            this.checkcode.Location = new System.Drawing.Point(116, 224);
            this.checkcode.MaxLength = 25;
            this.checkcode.Name = "checkcode";
            this.checkcode.Size = new System.Drawing.Size(77, 21);
            this.checkcode.TabIndex = 9;
            // 
            // checkpic
            // 
            this.checkpic.AutoSize = true;
            this.checkpic.Font = new System.Drawing.Font("微软雅黑", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkpic.Image = ((System.Drawing.Image)(resources.GetObject("checkpic.Image")));
            this.checkpic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkpic.Location = new System.Drawing.Point(199, 220);
            this.checkpic.Name = "checkpic";
            this.checkpic.Size = new System.Drawing.Size(72, 26);
            this.checkpic.TabIndex = 14;
            this.checkpic.Text = "56423";
            this.checkpic.Click += new System.EventHandler(this.Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(179, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "看不清点击图片";
            // 
            // regist
            // 
            this.regist.Enabled = false;
            this.regist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.regist.Location = new System.Drawing.Point(99, 312);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(75, 23);
            this.regist.TabIndex = 16;
            this.regist.Text = "注册";
            this.regist.UseVisualStyleBackColor = true;
            this.regist.Click += new System.EventHandler(this.Regist_Click);
            // 
            // okCheckbox
            // 
            this.okCheckbox.AutoSize = true;
            this.okCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.okCheckbox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.okCheckbox.Location = new System.Drawing.Point(99, 271);
            this.okCheckbox.Name = "okCheckbox";
            this.okCheckbox.Size = new System.Drawing.Size(140, 24);
            this.okCheckbox.TabIndex = 17;
            this.okCheckbox.Text = "同意《用户协议》";
            this.okCheckbox.UseVisualStyleBackColor = false;
            this.okCheckbox.CheckedChanged += new System.EventHandler(this.OkCheckbox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(201, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(338, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okCheckbox);
            this.Controls.Add(this.regist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkpic);
            this.Controls.Add(this.checkcode);
            this.Controls.Add(this.nick);
            this.Controls.Add(this.surepwd);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.psw);
            this.Controls.Add(this.account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.Text = "注册";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label psw;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox acc;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.TextBox surepwd;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.TextBox checkcode;
        private System.Windows.Forms.Label checkpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regist;
        private System.Windows.Forms.CheckBox okCheckbox;
        private System.Windows.Forms.Button button1;
    }
}