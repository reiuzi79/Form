namespace 身份证信息管理系统
{
    partial class UpdatePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePwd));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.acc = new System.Windows.Forms.TextBox();
            this.oldpwd = new System.Windows.Forms.TextBox();
            this.newpwd = new System.Windows.Forms.TextBox();
            this.sure = new System.Windows.Forms.TextBox();
            this.checkpic = new System.Windows.Forms.Label();
            this.checkcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "修改密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "原密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "新密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "确认密码";
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(83, 43);
            this.acc.MaxLength = 25;
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(88, 21);
            this.acc.TabIndex = 5;
            // 
            // oldpwd
            // 
            this.oldpwd.Location = new System.Drawing.Point(83, 75);
            this.oldpwd.MaxLength = 20;
            this.oldpwd.Name = "oldpwd";
            this.oldpwd.PasswordChar = '*';
            this.oldpwd.Size = new System.Drawing.Size(88, 21);
            this.oldpwd.TabIndex = 6;
            // 
            // newpwd
            // 
            this.newpwd.Location = new System.Drawing.Point(83, 108);
            this.newpwd.MaxLength = 20;
            this.newpwd.Name = "newpwd";
            this.newpwd.PasswordChar = '*';
            this.newpwd.Size = new System.Drawing.Size(88, 21);
            this.newpwd.TabIndex = 7;
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(83, 141);
            this.sure.MaxLength = 20;
            this.sure.Name = "sure";
            this.sure.PasswordChar = '*';
            this.sure.Size = new System.Drawing.Size(88, 21);
            this.sure.TabIndex = 8;
            // 
            // checkpic
            // 
            this.checkpic.AutoSize = true;
            this.checkpic.Font = new System.Drawing.Font("微软雅黑", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Strikeout))));
            this.checkpic.Image = ((System.Drawing.Image)(resources.GetObject("checkpic.Image")));
            this.checkpic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkpic.Location = new System.Drawing.Point(104, 196);
            this.checkpic.Name = "checkpic";
            this.checkpic.Size = new System.Drawing.Size(67, 25);
            this.checkpic.TabIndex = 17;
            this.checkpic.Text = "58139";
            this.checkpic.Click += new System.EventHandler(this.Checkpic_Click);
            // 
            // checkcode
            // 
            this.checkcode.Location = new System.Drawing.Point(83, 172);
            this.checkcode.MaxLength = 5;
            this.checkcode.Name = "checkcode";
            this.checkcode.Size = new System.Drawing.Size(88, 21);
            this.checkcode.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(26, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "验证码";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 21);
            this.button1.TabIndex = 18;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 21);
            this.button2.TabIndex = 19;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(21, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "点击图片刷新";
            // 
            // UpdatePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 257);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkpic);
            this.Controls.Add(this.checkcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.newpwd);
            this.Controls.Add(this.oldpwd);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdatePwd";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdatePwd_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdatePwd_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpdatePwd_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox acc;
        private System.Windows.Forms.TextBox oldpwd;
        private System.Windows.Forms.TextBox newpwd;
        private System.Windows.Forms.TextBox sure;
        private System.Windows.Forms.Label checkpic;
        private System.Windows.Forms.TextBox checkcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}