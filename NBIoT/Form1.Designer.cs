namespace NBIoT
{
    partial class Form1
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
            this.JiLu_ListView = new System.Windows.Forms.ListView();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Field1_TextBox = new System.Windows.Forms.TextBox();
            this.JieDian_ListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // JiLu_ListView
            // 
            this.JiLu_ListView.Location = new System.Drawing.Point(40, 197);
            this.JiLu_ListView.Name = "JiLu_ListView";
            this.JiLu_ListView.Size = new System.Drawing.Size(566, 420);
            this.JiLu_ListView.TabIndex = 1;
            this.JiLu_ListView.UseCompatibleStateImageBehavior = false;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(625, 118);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "button1";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Field1_TextBox
            // 
            this.Field1_TextBox.Location = new System.Drawing.Point(625, 159);
            this.Field1_TextBox.Name = "Field1_TextBox";
            this.Field1_TextBox.Size = new System.Drawing.Size(100, 21);
            this.Field1_TextBox.TabIndex = 3;
            // 
            // JieDian_ListView
            // 
            this.JieDian_ListView.Location = new System.Drawing.Point(625, 197);
            this.JieDian_ListView.Name = "JieDian_ListView";
            this.JieDian_ListView.Size = new System.Drawing.Size(663, 413);
            this.JieDian_ListView.TabIndex = 4;
            this.JieDian_ListView.UseCompatibleStateImageBehavior = false;
            this.JieDian_ListView.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 701);
            this.Controls.Add(this.JieDian_ListView);
            this.Controls.Add(this.Field1_TextBox);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.JiLu_ListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView JiLu_ListView;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.TextBox Field1_TextBox;
        private System.Windows.Forms.ListView JieDian_ListView;
    }
}

