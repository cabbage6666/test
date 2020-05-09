namespace HTTPRequestTools
{
    partial class HTTP请求工具
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoPost = new System.Windows.Forms.RadioButton();
            this.rdoGet = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.txtRequ = new System.Windows.Forms.TextBox();
            this.txtReponse = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.rdoPut = new System.Windows.Forms.RadioButton();
            this.rdoDel = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "请求";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Request:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Respones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Method:";
            // 
            // rdoPost
            // 
            this.rdoPost.AutoSize = true;
            this.rdoPost.Checked = true;
            this.rdoPost.Location = new System.Drawing.Point(123, 82);
            this.rdoPost.Name = "rdoPost";
            this.rdoPost.Size = new System.Drawing.Size(47, 16);
            this.rdoPost.TabIndex = 4;
            this.rdoPost.TabStop = true;
            this.rdoPost.Text = "POST";
            this.rdoPost.UseVisualStyleBackColor = true;
            // 
            // rdoGet
            // 
            this.rdoGet.AutoSize = true;
            this.rdoGet.Location = new System.Drawing.Point(182, 82);
            this.rdoGet.Name = "rdoGet";
            this.rdoGet.Size = new System.Drawing.Size(41, 16);
            this.rdoGet.TabIndex = 4;
            this.rdoGet.Text = "GET";
            this.rdoGet.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "ContentType:";
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(457, 81);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(122, 21);
            this.txtContentType.TabIndex = 7;
            this.txtContentType.Text = "application/json";
            // 
            // txtRequ
            // 
            this.txtRequ.Location = new System.Drawing.Point(108, 109);
            this.txtRequ.Multiline = true;
            this.txtRequ.Name = "txtRequ";
            this.txtRequ.Size = new System.Drawing.Size(471, 167);
            this.txtRequ.TabIndex = 10;
            // 
            // txtReponse
            // 
            this.txtReponse.Location = new System.Drawing.Point(108, 329);
            this.txtReponse.Multiline = true;
            this.txtReponse.Name = "txtReponse";
            this.txtReponse.Size = new System.Drawing.Size(471, 172);
            this.txtReponse.TabIndex = 11;
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUrl.Location = new System.Drawing.Point(108, 38);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrl.Size = new System.Drawing.Size(471, 29);
            this.txtUrl.TabIndex = 12;
            // 
            // rdoPut
            // 
            this.rdoPut.AutoSize = true;
            this.rdoPut.Location = new System.Drawing.Point(239, 82);
            this.rdoPut.Name = "rdoPut";
            this.rdoPut.Size = new System.Drawing.Size(41, 16);
            this.rdoPut.TabIndex = 14;
            this.rdoPut.TabStop = true;
            this.rdoPut.Text = "PUT";
            this.rdoPut.UseVisualStyleBackColor = true;
            // 
            // rdoDel
            // 
            this.rdoDel.AutoSize = true;
            this.rdoDel.Location = new System.Drawing.Point(286, 82);
            this.rdoDel.Name = "rdoDel";
            this.rdoDel.Size = new System.Drawing.Size(41, 16);
            this.rdoDel.TabIndex = 14;
            this.rdoDel.TabStop = true;
            this.rdoDel.Text = "DEL";
            this.rdoDel.UseVisualStyleBackColor = true;
            // 
            // HTTP请求工具
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 513);
            this.Controls.Add(this.rdoDel);
            this.Controls.Add(this.rdoPut);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtReponse);
            this.Controls.Add(this.txtRequ);
            this.Controls.Add(this.txtContentType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoGet);
            this.Controls.Add(this.rdoPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "HTTP请求工具";
            this.Text = "HTTP请求工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoPost;
        private System.Windows.Forms.RadioButton rdoGet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.TextBox txtRequ;
        private System.Windows.Forms.TextBox txtReponse;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.RadioButton rdoPut;
        private System.Windows.Forms.RadioButton rdoDel;
    }
}

