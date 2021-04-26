namespace TestApp
{
    partial class FormTest2
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
            this.checkBox1_4 = new System.Windows.Forms.CheckBox();
            this.checkBox1_3 = new System.Windows.Forms.CheckBox();
            this.checkBox1_2 = new System.Windows.Forms.CheckBox();
            this.checkBox1_1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3_1 = new System.Windows.Forms.Button();
            this.checkBox3_4 = new System.Windows.Forms.CheckBox();
            this.checkBox3_3 = new System.Windows.Forms.CheckBox();
            this.checkBox3_2 = new System.Windows.Forms.CheckBox();
            this.checkBox3_1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4_1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5_1 = new System.Windows.Forms.Button();
            this.textBoxDecimal = new CommonControlPlus.TextBoxDecimal();
            this.textBoxDouble = new CommonControlPlus.TextBoxDouble();
            this.textBoxInteger = new CommonControlPlus.TextBoxInteger();
            this.textBoxPlus = new CommonControlPlus.TextBoxPlus();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPlus);
            this.groupBox1.Controls.Add(this.checkBox1_4);
            this.groupBox1.Controls.Add(this.checkBox1_3);
            this.groupBox1.Controls.Add(this.checkBox1_2);
            this.groupBox1.Controls.Add(this.checkBox1_1);
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(283, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TextBoxPlusのテスト";
            // 
            // checkBox1_4
            // 
            this.checkBox1_4.AutoSize = true;
            this.checkBox1_4.Location = new System.Drawing.Point(11, 101);
            this.checkBox1_4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1_4.Name = "checkBox1_4";
            this.checkBox1_4.Size = new System.Drawing.Size(137, 16);
            this.checkBox1_4.TabIndex = 4;
            this.checkBox1_4.Text = "エラーをコンソールに出す";
            this.checkBox1_4.UseVisualStyleBackColor = true;
            this.checkBox1_4.CheckedChanged += new System.EventHandler(this.checkBox1_4_CheckedChanged);
            // 
            // checkBox1_3
            // 
            this.checkBox1_3.AutoSize = true;
            this.checkBox1_3.Location = new System.Drawing.Point(11, 82);
            this.checkBox1_3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1_3.Name = "checkBox1_3";
            this.checkBox1_3.Size = new System.Drawing.Size(170, 16);
            this.checkBox1_3.TabIndex = 3;
            this.checkBox1_3.Text = "エラーをメッセージボックスに出す";
            this.checkBox1_3.UseVisualStyleBackColor = true;
            this.checkBox1_3.CheckedChanged += new System.EventHandler(this.checkBox1_3_CheckedChanged);
            // 
            // checkBox1_2
            // 
            this.checkBox1_2.AutoSize = true;
            this.checkBox1_2.Location = new System.Drawing.Point(11, 63);
            this.checkBox1_2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1_2.Name = "checkBox1_2";
            this.checkBox1_2.Size = new System.Drawing.Size(277, 16);
            this.checkBox1_2.TabIndex = 2;
            this.checkBox1_2.Text = "ユーザー定義の入力チェックのテスト (4文字以内か？)";
            this.checkBox1_2.UseVisualStyleBackColor = true;
            // 
            // checkBox1_1
            // 
            this.checkBox1_1.AutoSize = true;
            this.checkBox1_1.Location = new System.Drawing.Point(11, 45);
            this.checkBox1_1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1_1.Name = "checkBox1_1";
            this.checkBox1_1.Size = new System.Drawing.Size(187, 16);
            this.checkBox1_1.TabIndex = 1;
            this.checkBox1_1.Text = "値が変化したときのイベントのテスト";
            this.checkBox1_1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxInteger);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button3_1);
            this.groupBox3.Controls.Add(this.checkBox3_4);
            this.groupBox3.Controls.Add(this.checkBox3_3);
            this.groupBox3.Controls.Add(this.checkBox3_2);
            this.groupBox3.Controls.Add(this.checkBox3_1);
            this.groupBox3.Location = new System.Drawing.Point(300, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(283, 170);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TextBoxIntegerのテスト";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 121);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 19);
            this.textBox3.TabIndex = 9;
            // 
            // button3_1
            // 
            this.button3_1.Location = new System.Drawing.Point(11, 120);
            this.button3_1.Margin = new System.Windows.Forms.Padding(2);
            this.button3_1.Name = "button3_1";
            this.button3_1.Size = new System.Drawing.Size(128, 19);
            this.button3_1.TabIndex = 7;
            this.button3_1.Text = "値設定のテスト";
            this.button3_1.UseVisualStyleBackColor = true;
            this.button3_1.Click += new System.EventHandler(this.button3_1_Click);
            // 
            // checkBox3_4
            // 
            this.checkBox3_4.AutoSize = true;
            this.checkBox3_4.Location = new System.Drawing.Point(11, 101);
            this.checkBox3_4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3_4.Name = "checkBox3_4";
            this.checkBox3_4.Size = new System.Drawing.Size(275, 16);
            this.checkBox3_4.TabIndex = 4;
            this.checkBox3_4.Text = "ユーザー定義の入力チェックのテスト (100の倍数か？)";
            this.checkBox3_4.UseVisualStyleBackColor = true;
            this.checkBox3_4.CheckedChanged += new System.EventHandler(this.checkBox3_4_CheckedChanged);
            // 
            // checkBox3_3
            // 
            this.checkBox3_3.AutoSize = true;
            this.checkBox3_3.Location = new System.Drawing.Point(11, 82);
            this.checkBox3_3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3_3.Name = "checkBox3_3";
            this.checkBox3_3.Size = new System.Drawing.Size(145, 16);
            this.checkBox3_3.TabIndex = 3;
            this.checkBox3_3.Text = "最小幅チェックのテスト (5)";
            this.checkBox3_3.UseVisualStyleBackColor = true;
            this.checkBox3_3.CheckedChanged += new System.EventHandler(this.checkBox3_3_CheckedChanged);
            // 
            // checkBox3_2
            // 
            this.checkBox3_2.AutoSize = true;
            this.checkBox3_2.Location = new System.Drawing.Point(11, 63);
            this.checkBox3_2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3_2.Name = "checkBox3_2";
            this.checkBox3_2.Size = new System.Drawing.Size(169, 16);
            this.checkBox3_2.TabIndex = 2;
            this.checkBox3_2.Text = "最小値チェックのテスト (-1000)";
            this.checkBox3_2.UseVisualStyleBackColor = true;
            this.checkBox3_2.CheckedChanged += new System.EventHandler(this.checkBox3_2_CheckedChanged);
            // 
            // checkBox3_1
            // 
            this.checkBox3_1.AutoSize = true;
            this.checkBox3_1.Location = new System.Drawing.Point(11, 45);
            this.checkBox3_1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3_1.Name = "checkBox3_1";
            this.checkBox3_1.Size = new System.Drawing.Size(163, 16);
            this.checkBox3_1.TabIndex = 1;
            this.checkBox3_1.Text = "最大値チェックのテスト (1000)";
            this.checkBox3_1.UseVisualStyleBackColor = true;
            this.checkBox3_1.CheckedChanged += new System.EventHandler(this.checkBox3_1_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDouble);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.button4_1);
            this.groupBox4.Location = new System.Drawing.Point(300, 190);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(283, 106);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TextBoxDoubleのテスト";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 56);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 19);
            this.textBox4.TabIndex = 9;
            // 
            // button4_1
            // 
            this.button4_1.Location = new System.Drawing.Point(11, 54);
            this.button4_1.Margin = new System.Windows.Forms.Padding(2);
            this.button4_1.Name = "button4_1";
            this.button4_1.Size = new System.Drawing.Size(128, 19);
            this.button4_1.TabIndex = 7;
            this.button4_1.Text = "値設定のテスト";
            this.button4_1.UseVisualStyleBackColor = true;
            this.button4_1.Click += new System.EventHandler(this.button4_1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxDecimal);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.button5_1);
            this.groupBox5.Location = new System.Drawing.Point(300, 311);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(283, 106);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TextBoxDecimalのテスト";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 56);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 19);
            this.textBox5.TabIndex = 9;
            // 
            // button5_1
            // 
            this.button5_1.Location = new System.Drawing.Point(11, 54);
            this.button5_1.Margin = new System.Windows.Forms.Padding(2);
            this.button5_1.Name = "button5_1";
            this.button5_1.Size = new System.Drawing.Size(128, 19);
            this.button5_1.TabIndex = 7;
            this.button5_1.Text = "値設定のテスト";
            this.button5_1.UseVisualStyleBackColor = true;
            this.button5_1.Click += new System.EventHandler(this.button5_1_Click);
            // 
            // textBoxDecimal
            // 
            this.textBoxDecimal.ErrorMessage = "";
            this.textBoxDecimal.ErrorMessageBoxEnabled = true;
            this.textBoxDecimal.ErrorOutputEnabled = false;
            this.textBoxDecimal.FormatString = "";
            this.textBoxDecimal.Location = new System.Drawing.Point(11, 20);
            this.textBoxDecimal.MaxValue = null;
            this.textBoxDecimal.MinValue = null;
            this.textBoxDecimal.Name = "textBoxDecimal";
            this.textBoxDecimal.Size = new System.Drawing.Size(92, 19);
            this.textBoxDecimal.StepValue = null;
            this.textBoxDecimal.TabIndex = 10;
            this.textBoxDecimal.Text = "0";
            this.textBoxDecimal.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // textBoxDouble
            // 
            this.textBoxDouble.ErrorMessage = "";
            this.textBoxDouble.ErrorMessageBoxEnabled = true;
            this.textBoxDouble.ErrorOutputEnabled = false;
            this.textBoxDouble.FormatString = "";
            this.textBoxDouble.Location = new System.Drawing.Point(11, 21);
            this.textBoxDouble.MaxValue = null;
            this.textBoxDouble.MinValue = null;
            this.textBoxDouble.Name = "textBoxDouble";
            this.textBoxDouble.Size = new System.Drawing.Size(92, 19);
            this.textBoxDouble.StepValue = null;
            this.textBoxDouble.TabIndex = 11;
            this.textBoxDouble.Text = "0";
            this.textBoxDouble.Value = 0D;
            // 
            // textBoxInteger
            // 
            this.textBoxInteger.ErrorMessage = "";
            this.textBoxInteger.ErrorMessageBoxEnabled = true;
            this.textBoxInteger.ErrorOutputEnabled = false;
            this.textBoxInteger.FormatString = "";
            this.textBoxInteger.Location = new System.Drawing.Point(11, 21);
            this.textBoxInteger.MaxValue = null;
            this.textBoxInteger.MinValue = null;
            this.textBoxInteger.Name = "textBoxInteger";
            this.textBoxInteger.Size = new System.Drawing.Size(92, 19);
            this.textBoxInteger.StepValue = null;
            this.textBoxInteger.TabIndex = 10;
            this.textBoxInteger.Text = "0";
            this.textBoxInteger.Value = 0;
            // 
            // textBoxPlus
            // 
            this.textBoxPlus.ErrorMessage = "";
            this.textBoxPlus.ErrorMessageBoxEnabled = false;
            this.textBoxPlus.ErrorOutputEnabled = false;
            this.textBoxPlus.Location = new System.Drawing.Point(11, 21);
            this.textBoxPlus.Name = "textBoxPlus";
            this.textBoxPlus.Size = new System.Drawing.Size(128, 19);
            this.textBoxPlus.TabIndex = 10;
            this.textBoxPlus.Changed += new System.EventHandler(this.textBoxPlus_Changed);
            this.textBoxPlus.InputTextCheck += new CommonControlPlus.TextBoxPlus.InputTextCheckFunction(this.textBoxPlus_InputTextCheck);
            // 
            // FormTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 437);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTest2";
            this.Text = "テスト";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1_4;
        private System.Windows.Forms.CheckBox checkBox1_3;
        private System.Windows.Forms.CheckBox checkBox1_2;
        private System.Windows.Forms.CheckBox checkBox1_1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3_1;
        private System.Windows.Forms.CheckBox checkBox3_4;
        private System.Windows.Forms.CheckBox checkBox3_3;
        private System.Windows.Forms.CheckBox checkBox3_2;
        private System.Windows.Forms.CheckBox checkBox3_1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4_1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5_1;
        private CommonControlPlus.TextBoxPlus textBoxPlus;
        private CommonControlPlus.TextBoxInteger textBoxInteger;
        private CommonControlPlus.TextBoxDouble textBoxDouble;
        private CommonControlPlus.TextBoxDecimal textBoxDecimal;
    }
}

