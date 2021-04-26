namespace TestApp
{
    partial class FormTest1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2_2 = new System.Windows.Forms.Button();
            this.button2_1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3_2 = new System.Windows.Forms.Button();
            this.button3_1 = new System.Windows.Forms.Button();
            this.checkBox3_4 = new System.Windows.Forms.CheckBox();
            this.checkBox3_3 = new System.Windows.Forms.CheckBox();
            this.checkBox3_2 = new System.Windows.Forms.CheckBox();
            this.checkBox3_1 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4_2 = new System.Windows.Forms.Button();
            this.button4_1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button5_2 = new System.Windows.Forms.Button();
            this.button5_1 = new System.Windows.Forms.Button();
            this.comboBoxDecimal = new CommonControlPlus.ComboBoxDecimal();
            this.comboBoxDouble = new CommonControlPlus.ComboBoxDouble();
            this.comboBoxInteger = new CommonControlPlus.ComboBoxInteger();
            this.comboBoxPlus2 = new CommonControlPlus.ComboBoxPlus();
            this.comboBoxPlus1 = new CommonControlPlus.ComboBoxPlus();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(7, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(283, 170);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBoxPlusのテスト1 (文字列)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 121);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 19);
            this.textBox1.TabIndex = 9;
            // 
            // button1_2
            // 
            this.button1_2.Location = new System.Drawing.Point(11, 143);
            this.button1_2.Margin = new System.Windows.Forms.Padding(2);
            this.button1_2.Name = "button1_2";
            this.button1_2.Size = new System.Drawing.Size(128, 19);
            this.button1_2.TabIndex = 8;
            this.button1_2.Text = "項目選択/追加のテスト";
            this.button1_2.UseVisualStyleBackColor = true;
            this.button1_2.Click += new System.EventHandler(this.button1_2_Click);
            // 
            // button1_1
            // 
            this.button1_1.Location = new System.Drawing.Point(11, 120);
            this.button1_1.Margin = new System.Windows.Forms.Padding(2);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(128, 19);
            this.button1_1.TabIndex = 7;
            this.button1_1.Text = "項目選択のテスト";
            this.button1_1.UseVisualStyleBackColor = true;
            this.button1_1.Click += new System.EventHandler(this.button1_1_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button2_2);
            this.groupBox2.Controls.Add(this.button2_1);
            this.groupBox2.Controls.Add(this.comboBoxPlus2);
            this.groupBox2.Location = new System.Drawing.Point(7, 190);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(283, 106);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ComboBoxPlusのテスト2 (Colorオブジェクト)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 19);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Blue";
            // 
            // button2_2
            // 
            this.button2_2.Location = new System.Drawing.Point(11, 77);
            this.button2_2.Margin = new System.Windows.Forms.Padding(2);
            this.button2_2.Name = "button2_2";
            this.button2_2.Size = new System.Drawing.Size(128, 19);
            this.button2_2.TabIndex = 8;
            this.button2_2.Text = "項目選択/追加のテスト";
            this.button2_2.UseVisualStyleBackColor = true;
            this.button2_2.Click += new System.EventHandler(this.button2_2_Click);
            // 
            // button2_1
            // 
            this.button2_1.Location = new System.Drawing.Point(11, 55);
            this.button2_1.Margin = new System.Windows.Forms.Padding(2);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(128, 19);
            this.button2_1.TabIndex = 7;
            this.button2_1.Text = "項目選択のテスト";
            this.button2_1.UseVisualStyleBackColor = true;
            this.button2_1.Click += new System.EventHandler(this.button2_1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxInteger);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.button3_2);
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
            this.groupBox3.Text = "ComboBoxIntegerのテスト";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(151, 121);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(97, 19);
            this.textBox3.TabIndex = 9;
            // 
            // button3_2
            // 
            this.button3_2.Location = new System.Drawing.Point(11, 143);
            this.button3_2.Margin = new System.Windows.Forms.Padding(2);
            this.button3_2.Name = "button3_2";
            this.button3_2.Size = new System.Drawing.Size(128, 19);
            this.button3_2.TabIndex = 8;
            this.button3_2.Text = "項目選択/追加のテスト";
            this.button3_2.UseVisualStyleBackColor = true;
            this.button3_2.Click += new System.EventHandler(this.button3_2_Click);
            // 
            // button3_1
            // 
            this.button3_1.Location = new System.Drawing.Point(11, 120);
            this.button3_1.Margin = new System.Windows.Forms.Padding(2);
            this.button3_1.Name = "button3_1";
            this.button3_1.Size = new System.Drawing.Size(128, 19);
            this.button3_1.TabIndex = 7;
            this.button3_1.Text = "項目選択のテスト";
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
            this.groupBox4.Controls.Add(this.comboBoxDouble);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.button4_2);
            this.groupBox4.Controls.Add(this.button4_1);
            this.groupBox4.Location = new System.Drawing.Point(300, 190);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(283, 106);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ComboBoxDoubleのテスト";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 56);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 19);
            this.textBox4.TabIndex = 9;
            // 
            // button4_2
            // 
            this.button4_2.Location = new System.Drawing.Point(11, 77);
            this.button4_2.Margin = new System.Windows.Forms.Padding(2);
            this.button4_2.Name = "button4_2";
            this.button4_2.Size = new System.Drawing.Size(128, 19);
            this.button4_2.TabIndex = 8;
            this.button4_2.Text = "項目選択/追加のテスト";
            this.button4_2.UseVisualStyleBackColor = true;
            this.button4_2.Click += new System.EventHandler(this.button4_2_Click);
            // 
            // button4_1
            // 
            this.button4_1.Location = new System.Drawing.Point(11, 54);
            this.button4_1.Margin = new System.Windows.Forms.Padding(2);
            this.button4_1.Name = "button4_1";
            this.button4_1.Size = new System.Drawing.Size(128, 19);
            this.button4_1.TabIndex = 7;
            this.button4_1.Text = "項目選択のテスト";
            this.button4_1.UseVisualStyleBackColor = true;
            this.button4_1.Click += new System.EventHandler(this.button4_1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxDecimal);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.button5_2);
            this.groupBox5.Controls.Add(this.button5_1);
            this.groupBox5.Location = new System.Drawing.Point(300, 311);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(283, 106);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ComboBoxDecimalのテスト";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 56);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 19);
            this.textBox5.TabIndex = 9;
            // 
            // button5_2
            // 
            this.button5_2.Location = new System.Drawing.Point(11, 77);
            this.button5_2.Margin = new System.Windows.Forms.Padding(2);
            this.button5_2.Name = "button5_2";
            this.button5_2.Size = new System.Drawing.Size(128, 19);
            this.button5_2.TabIndex = 8;
            this.button5_2.Text = "項目選択/追加のテスト";
            this.button5_2.UseVisualStyleBackColor = true;
            this.button5_2.Click += new System.EventHandler(this.button5_2_Click);
            // 
            // button5_1
            // 
            this.button5_1.Location = new System.Drawing.Point(11, 54);
            this.button5_1.Margin = new System.Windows.Forms.Padding(2);
            this.button5_1.Name = "button5_1";
            this.button5_1.Size = new System.Drawing.Size(128, 19);
            this.button5_1.TabIndex = 7;
            this.button5_1.Text = "項目選択のテスト";
            this.button5_1.UseVisualStyleBackColor = true;
            this.button5_1.Click += new System.EventHandler(this.button5_1_Click);
            // 
            // comboBoxDecimal
            // 
            this.comboBoxDecimal.ErrorMessage = "";
            this.comboBoxDecimal.ErrorMessageBoxEnabled = true;
            this.comboBoxDecimal.ErrorOutputEnabled = false;
            this.comboBoxDecimal.FormattingEnabled = true;
            this.comboBoxDecimal.Location = new System.Drawing.Point(11, 23);
            this.comboBoxDecimal.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDecimal.MaxValue = null;
            this.comboBoxDecimal.MinValue = null;
            this.comboBoxDecimal.Name = "comboBoxDecimal";
            this.comboBoxDecimal.Size = new System.Drawing.Size(92, 20);
            this.comboBoxDecimal.StepValue = null;
            this.comboBoxDecimal.TabIndex = 10;
            this.comboBoxDecimal.Value = null;
            // 
            // comboBoxDouble
            // 
            this.comboBoxDouble.ErrorMessage = "";
            this.comboBoxDouble.ErrorMessageBoxEnabled = true;
            this.comboBoxDouble.ErrorOutputEnabled = false;
            this.comboBoxDouble.FormattingEnabled = true;
            this.comboBoxDouble.Location = new System.Drawing.Point(11, 23);
            this.comboBoxDouble.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDouble.MaxValue = null;
            this.comboBoxDouble.MinValue = null;
            this.comboBoxDouble.Name = "comboBoxDouble";
            this.comboBoxDouble.Size = new System.Drawing.Size(92, 20);
            this.comboBoxDouble.StepValue = null;
            this.comboBoxDouble.TabIndex = 10;
            this.comboBoxDouble.Value = null;
            // 
            // comboBoxInteger
            // 
            this.comboBoxInteger.ErrorMessage = "";
            this.comboBoxInteger.ErrorMessageBoxEnabled = true;
            this.comboBoxInteger.ErrorOutputEnabled = false;
            this.comboBoxInteger.FormattingEnabled = true;
            this.comboBoxInteger.Location = new System.Drawing.Point(11, 23);
            this.comboBoxInteger.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxInteger.MaxValue = null;
            this.comboBoxInteger.MinValue = null;
            this.comboBoxInteger.Name = "comboBoxInteger";
            this.comboBoxInteger.Size = new System.Drawing.Size(92, 20);
            this.comboBoxInteger.StepValue = null;
            this.comboBoxInteger.TabIndex = 9;
            this.comboBoxInteger.Value = null;
            // 
            // comboBoxPlus2
            // 
            this.comboBoxPlus2.ErrorMessage = "";
            this.comboBoxPlus2.ErrorMessageBoxEnabled = true;
            this.comboBoxPlus2.ErrorOutputEnabled = false;
            this.comboBoxPlus2.FormattingEnabled = true;
            this.comboBoxPlus2.Location = new System.Drawing.Point(11, 23);
            this.comboBoxPlus2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPlus2.Name = "comboBoxPlus2";
            this.comboBoxPlus2.Size = new System.Drawing.Size(101, 20);
            this.comboBoxPlus2.TabIndex = 0;
            this.comboBoxPlus2.InputTextCheck += new CommonControlPlus.ComboBoxPlus.InputTextCheckFunction(this.comboBoxPlus2_InputCheck);
            // 
            // comboBoxPlus1
            // 
            this.comboBoxPlus1.ErrorMessage = "";
            this.comboBoxPlus1.ErrorMessageBoxEnabled = false;
            this.comboBoxPlus1.ErrorOutputEnabled = false;
            this.comboBoxPlus1.FormattingEnabled = true;
            this.comboBoxPlus1.Location = new System.Drawing.Point(11, 23);
            this.comboBoxPlus1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPlus1.Name = "comboBoxPlus1";
            this.comboBoxPlus1.Size = new System.Drawing.Size(101, 20);
            this.comboBoxPlus1.TabIndex = 0;
            this.comboBoxPlus1.Changed += new System.EventHandler(this.comboBoxPlus1_Changed);
            this.comboBoxPlus1.InputTextCheck += new CommonControlPlus.ComboBoxPlus.InputTextCheckFunction(this.comboBoxPlus1_InputCheck);
            // 
            // FormTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 437);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTest1";
            this.Text = "テスト";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3_2;
        private System.Windows.Forms.Button button3_1;
        private System.Windows.Forms.CheckBox checkBox3_4;
        private System.Windows.Forms.CheckBox checkBox3_3;
        private System.Windows.Forms.CheckBox checkBox3_2;
        private System.Windows.Forms.CheckBox checkBox3_1;
        private CommonControlPlus.ComboBoxInteger comboBoxInteger;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4_2;
        private System.Windows.Forms.Button button4_1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5_2;
        private System.Windows.Forms.Button button5_1;
        private CommonControlPlus.ComboBoxDouble comboBoxDouble;
        private CommonControlPlus.ComboBoxDecimal comboBoxDecimal;
    }
}

