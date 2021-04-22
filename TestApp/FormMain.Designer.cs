namespace TestApp
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxPlus2 = new CommonControlPlus.ComboBoxPlus();
            this.comboBoxPlus1 = new CommonControlPlus.ComboBoxPlus();
            this.comboBoxPlus3 = new CommonControlPlus.ComboBoxPlus();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBoxPlus2
            // 
            this.comboBoxPlus2.ErrorMessageBoxEnabled = false;
            this.comboBoxPlus2.ErrorOutputEnabled = false;
            this.comboBoxPlus2.FormattingEnabled = true;
            this.comboBoxPlus2.Location = new System.Drawing.Point(510, 234);
            this.comboBoxPlus2.Name = "comboBoxPlus2";
            this.comboBoxPlus2.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPlus2.TabIndex = 3;
            this.comboBoxPlus2.UserErrorMessage = "";
            // 
            // comboBoxPlus1
            // 
            this.comboBoxPlus1.ErrorMessageBoxEnabled = false;
            this.comboBoxPlus1.ErrorOutputEnabled = false;
            this.comboBoxPlus1.FormattingEnabled = true;
            this.comboBoxPlus1.Location = new System.Drawing.Point(271, 129);
            this.comboBoxPlus1.Name = "comboBoxPlus1";
            this.comboBoxPlus1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPlus1.TabIndex = 2;
            this.comboBoxPlus1.UserErrorMessage = "";
            // 
            // comboBoxPlus3
            // 
            this.comboBoxPlus3.ErrorMessageBoxEnabled = false;
            this.comboBoxPlus3.ErrorOutputEnabled = false;
            this.comboBoxPlus3.FormattingEnabled = true;
            this.comboBoxPlus3.Location = new System.Drawing.Point(271, 59);
            this.comboBoxPlus3.Name = "comboBoxPlus3";
            this.comboBoxPlus3.Size = new System.Drawing.Size(121, 20);
            this.comboBoxPlus3.TabIndex = 4;
            this.comboBoxPlus3.UserErrorMessage = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxPlus3);
            this.Controls.Add(this.comboBoxPlus2);
            this.Controls.Add(this.comboBoxPlus1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CommonControlPlus.ComboBoxPlus comboBoxPlus1;
        private CommonControlPlus.ComboBoxPlus comboBoxPlus2;
        private CommonControlPlus.ComboBoxPlus comboBoxPlus3;
    }
}

