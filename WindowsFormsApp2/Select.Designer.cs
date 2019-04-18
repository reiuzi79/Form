namespace 身份证信息管理系统
{
    partial class Select
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.RadioButton();
            this.id = new System.Windows.Forms.RadioButton();
            this.tel = new System.Windows.Forms.RadioButton();
            this.age = new System.Windows.Forms.RadioButton();
            this.birth = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 20);
            this.button1.TabIndex = 12;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(293, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Checked = true;
            this.name.Location = new System.Drawing.Point(22, 36);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 16);
            this.name.TabIndex = 14;
            this.name.TabStop = true;
            this.name.Text = "姓名";
            this.name.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(78, 36);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(59, 16);
            this.id.TabIndex = 15;
            this.id.Text = "身份证";
            this.id.UseVisualStyleBackColor = true;
            // 
            // tel
            // 
            this.tel.AutoSize = true;
            this.tel.Location = new System.Drawing.Point(143, 36);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(47, 16);
            this.tel.TabIndex = 16;
            this.tel.Text = "电话";
            this.tel.UseVisualStyleBackColor = true;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(196, 36);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(47, 16);
            this.age.TabIndex = 17;
            this.age.Text = "年龄";
            this.age.UseVisualStyleBackColor = true;
            // 
            // birth
            // 
            this.birth.AutoSize = true;
            this.birth.Location = new System.Drawing.Point(249, 36);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(71, 16);
            this.birth.TabIndex = 18;
            this.birth.Text = "出生日期";
            this.birth.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 21);
            this.textBox1.TabIndex = 19;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(326, 36);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(47, 16);
            this.sex.TabIndex = 20;
            this.sex.Text = "性别";
            this.sex.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(394, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 116);
            this.label2.TabIndex = 21;
            this.label2.Text = "注：如输入年龄段，格式为形如11-23；出生日期为形如2018年或2018年6月或2018年6月20日";
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.age);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Select";
            this.Text = "Select";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Select_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Select_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Select_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton name;
        private System.Windows.Forms.RadioButton id;
        private System.Windows.Forms.RadioButton tel;
        private System.Windows.Forms.RadioButton age;
        private System.Windows.Forms.RadioButton birth;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton sex;
        private System.Windows.Forms.Label label2;
    }
}