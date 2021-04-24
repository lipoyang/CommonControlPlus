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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1_2 = new System.Windows.Forms.Button();
            this.button1_1 = new System.Windows.Forms.Button();
            this.checkBox1_4 = new System.Windows.Forms.CheckBox();
            this.checkBox1_3 = new System.Windows.Forms.CheckBox();
            this.checkBox1_2 = new System.Windows.Forms.CheckBox();
            this.checkBox1_1 = new System.Windows.Forms.CheckBox();
            this.comboBoxPlus1 = new CommonControlPlus.ComboBoxPlus();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2_2 = new System.Windows.Forms.Button();
            this.button2_1 = new System.Windows.Forms.Button();
            this.comboBoxPlus2 = new CommonControlPlus.ComboBoxPlus();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1_2);
            this.groupBox1.Controls.Add(this.button1_1);
            this.groupBox1.Controls.Add(this.checkBox1_4);
            this.groupBox1.Controls.Add(this.checkBox1_3);
            this.groupBox1.Controls.Add(this.checkBox1_2);
            this.groupBox1.Controls.Add(this.checkBox1_1);
            this.groupBox1.Controls.Add(this.comboBoxPlus1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 255);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBoxPlusのテスト1 (文字列)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 25);
            this.textBox1.TabIndex = 9;
            // 
            // button1_2
            // 
            this.button1_2.Location = new System.Drawing.Point(18, 214);
            this.button1_2.Name = "button1_2";
            this.button1_2.Size = new System.Drawing.Size(213, 28);
            this.button1_2.TabIndex = 8;
            this.button1_2.Text = "項目選択/追加のテスト";
            this.button1_2.UseVisualStyleBackColor = true;
            this.button1_2.Click += new System.EventHandler(this.button1_2_Click);
            // 
            // button1_1
            // 
            this.button1_1.Location = new System.Drawing.Point(18, 180);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(213, 28);
            this.button1_1.TabIndex = 7;
            this.button1_1.Text = "項目選択のテスト";
            this.button1_1.UseVisualStyleBackColor = true;
            this.button1_1.Click += new System.EventHandler(this.button1_1_Click);
            // 
            // checkBox1_4
            // 
            this.checkBox1_4.AutoSize = true;
            this.checkBox1_4.Location = new System.Drawing.Point(18, 151);
            this.checkBox1_4.Name = "checkBox1_4";
            this.checkBox1_4.Size = new System.Drawing.Size(205, 22);
            this.checkBox1_4.TabIndex = 4;
            this.checkBox1_4.Text = "エラーをコンソールに出す";
            this.checkBox1_4.UseVisualStyleBackColor = true;
            this.checkBox1_4.CheckedChanged += new System.EventHandler(this.checkBox1_4_CheckedChanged);
            // 
            // checkBox1_3
            // 
            this.checkBox1_3.AutoSize = true;
            this.checkBox1_3.Location = new System.Drawing.Point(18, 123);
            this.checkBox1_3.Name = "checkBox1_3";
            this.checkBox1_3.Size = new System.Drawing.Size(254, 22);
            this.checkBox1_3.TabIndex = 3;
            this.checkBox1_3.Text = "エラーをメッセージボックスに出す";
            this.checkBox1_3.UseVisualStyleBackColor = true;
            this.checkBox1_3.CheckedChanged += new System.EventHandler(this.checkBox1_3_CheckedChanged);
            // 
            // checkBox1_2
            // 
            this.checkBox1_2.AutoSize = true;
            this.checkBox1_2.Location = new System.Drawing.Point(18, 95);
            this.checkBox1_2.Name = "checkBox1_2";
            this.checkBox1_2.Size = new System.Drawing.Size(284, 22);
            this.checkBox1_2.TabIndex = 2;
            this.checkBox1_2.Text = "ユーザー定義の入力チェックのテスト";
            this.checkBox1_2.UseVisualStyleBackColor = true;
            // 
            // checkBox1_1
            // 
            this.checkBox1_1.AutoSize = true;
            this.checkBox1_1.Location = new System.Drawing.Point(18, 67);
            this.checkBox1_1.Name = "checkBox1_1";
            this.checkBox1_1.Size = new System.Drawing.Size(280, 22);
            this.checkBox1_1.TabIndex = 1;
            this.checkBox1_1.Text = "値が変化したときのイベントのテスト";
            this.checkBox1_1.UseVisualStyleBackColor = true;
            // 
            // comboBoxPlus1
            // 
            this.comboBoxPlus1.ErrorMessage = "";
            this.comboBoxPlus1.ErrorMessageBoxEnabled = false;
            this.comboBoxPlus1.ErrorOutputEnabled = false;
            this.comboBoxPlus1.FormattingEnabled = true;
            this.comboBoxPlus1.Location = new System.Drawing.Point(18, 34);
            this.comboBoxPlus1.Name = "comboBoxPlus1";
            this.comboBoxPlus1.Size = new System.Drawing.Size(166, 26);
            this.comboBoxPlus1.TabIndex = 0;
            this.comboBoxPlus1.Changed += new System.EventHandler(this.comboBoxPlus1_Changed);
            this.comboBoxPlus1.InputCheck += new CommonControlPlus.ComboBoxPlus.InputCheckFunction(this.comboBoxPlus1_InputCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button2_2);
            this.groupBox2.Controls.Add(this.button2_1);
            this.groupBox2.Controls.Add(this.comboBoxPlus2);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 159);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ComboBoxPlusのテスト2 (Colorオブジェクト)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 25);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Blue";
            // 
            // button2_2
            // 
            this.button2_2.Location = new System.Drawing.Point(18, 116);
            this.button2_2.Name = "button2_2";
            this.button2_2.Size = new System.Drawing.Size(213, 28);
            this.button2_2.TabIndex = 8;
            this.button2_2.Text = "項目選択/追加のテスト";
            this.button2_2.UseVisualStyleBackColor = true;
            this.button2_2.Click += new System.EventHandler(this.button2_2_Click);
            // 
            // button2_1
            // 
            this.button2_1.Location = new System.Drawing.Point(18, 82);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(213, 28);
            this.button2_1.TabIndex = 7;
            this.button2_1.Text = "項目選択のテスト";
            this.button2_1.UseVisualStyleBackColor = true;
            this.button2_1.Click += new System.EventHandler(this.button2_1_Click);
            // 
            // comboBoxPlus2
            // 
            this.comboBoxPlus2.ErrorMessage = "";
            this.comboBoxPlus2.ErrorMessageBoxEnabled = true;
            this.comboBoxPlus2.ErrorOutputEnabled = false;
            this.comboBoxPlus2.FormattingEnabled = true;
            this.comboBoxPlus2.Location = new System.Drawing.Point(18, 34);
            this.comboBoxPlus2.Name = "comboBoxPlus2";
            this.comboBoxPlus2.Size = new System.Drawing.Size(166, 26);
            this.comboBoxPlus2.TabIndex = 0;
            this.comboBoxPlus2.InputCheck += new CommonControlPlus.ComboBoxPlus.InputCheckFunction(this.comboBoxPlus2_InputCheck);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 675);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain";
            this.Text = "テスト";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private CommonControlPlus.ComboBoxPlus comboBoxPlus1;
        private System.Windows.Forms.CheckBox checkBox1_4;
        private System.Windows.Forms.CheckBox checkBox1_3;
        private System.Windows.Forms.CheckBox checkBox1_2;
        private System.Windows.Forms.CheckBox checkBox1_1;
        private System.Windows.Forms.Button button1_1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1_2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2_2;
        private System.Windows.Forms.Button button2_1;
        private CommonControlPlus.ComboBoxPlus comboBoxPlus2;
    }
}

