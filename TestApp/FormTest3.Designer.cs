namespace TestApp
{
    partial class FormTest3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1_3 = new System.Windows.Forms.Button();
            this.checkBox1_2 = new System.Windows.Forms.CheckBox();
            this.checkBox1_1 = new System.Windows.Forms.CheckBox();
            this.button1_2 = new System.Windows.Forms.Button();
            this.button1_1 = new System.Windows.Forms.Button();
            this.onOffButton = new CommonControlPlus.OnOffButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.button2_3 = new System.Windows.Forms.Button();
            this.checkBox2_2 = new System.Windows.Forms.CheckBox();
            this.checkBox2_1 = new System.Windows.Forms.CheckBox();
            this.button2_2 = new System.Windows.Forms.Button();
            this.button2_1 = new System.Windows.Forms.Button();
            this.onOffButtonPair = new CommonControlPlus.OnOffButtonPair();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toggleSwitch1 = new CommonControlPlus.ToggleSwitch();
            this.toggleSwitch = new CommonControlPlus.ToggleSwitch();
            this.toggleSwitch4 = new CommonControlPlus.ToggleSwitch();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toggleSwitchText1 = new CommonControlPlus.ToggleSwitchText();
            this.toggleSwitchText2 = new CommonControlPlus.ToggleSwitchText();
            this.groupBox1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1_3);
            this.groupBox1.Controls.Add(this.checkBox1_2);
            this.groupBox1.Controls.Add(this.checkBox1_1);
            this.groupBox1.Controls.Add(this.button1_2);
            this.groupBox1.Controls.Add(this.button1_1);
            this.groupBox1.Controls.Add(this.onOffButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 194);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OnOffButtonのテスト";
            // 
            // button1_3
            // 
            this.button1_3.Location = new System.Drawing.Point(6, 163);
            this.button1_3.Name = "button1_3";
            this.button1_3.Size = new System.Drawing.Size(104, 23);
            this.button1_3.TabIndex = 11;
            this.button1_3.Text = "TurnedOnのテスト";
            this.button1_3.UseVisualStyleBackColor = true;
            this.button1_3.Click += new System.EventHandler(this.button1_3_Click);
            // 
            // checkBox1_2
            // 
            this.checkBox1_2.AutoSize = true;
            this.checkBox1_2.Location = new System.Drawing.Point(6, 83);
            this.checkBox1_2.Name = "checkBox1_2";
            this.checkBox1_2.Size = new System.Drawing.Size(103, 16);
            this.checkBox1_2.TabIndex = 7;
            this.checkBox1_2.Text = "OFFのキャンセル";
            this.checkBox1_2.UseVisualStyleBackColor = true;
            // 
            // checkBox1_1
            // 
            this.checkBox1_1.AutoSize = true;
            this.checkBox1_1.Location = new System.Drawing.Point(6, 61);
            this.checkBox1_1.Name = "checkBox1_1";
            this.checkBox1_1.Size = new System.Drawing.Size(97, 16);
            this.checkBox1_1.TabIndex = 6;
            this.checkBox1_1.Text = "ONのキャンセル";
            this.checkBox1_1.UseVisualStyleBackColor = true;
            // 
            // button1_2
            // 
            this.button1_2.Location = new System.Drawing.Point(5, 134);
            this.button1_2.Name = "button1_2";
            this.button1_2.Size = new System.Drawing.Size(104, 23);
            this.button1_2.TabIndex = 5;
            this.button1_2.Text = "TurnOffのテスト";
            this.button1_2.UseVisualStyleBackColor = true;
            this.button1_2.Click += new System.EventHandler(this.button1_2_Click);
            // 
            // button1_1
            // 
            this.button1_1.Location = new System.Drawing.Point(6, 105);
            this.button1_1.Name = "button1_1";
            this.button1_1.Size = new System.Drawing.Size(104, 23);
            this.button1_1.TabIndex = 4;
            this.button1_1.Text = "TurnOn()のテスト";
            this.button1_1.UseVisualStyleBackColor = true;
            this.button1_1.Click += new System.EventHandler(this.button1_1_Click);
            // 
            // onOffButton
            // 
            this.onOffButton.Location = new System.Drawing.Point(6, 18);
            this.onOffButton.Name = "onOffButton";
            this.onOffButton.OffButtonText = "切断します";
            this.onOffButton.OnButtonText = "接続します";
            this.onOffButton.Size = new System.Drawing.Size(75, 23);
            this.onOffButton.TabIndex = 3;
            this.onOffButton.Text = "接続します";
            this.onOffButton.UseVisualStyleBackColor = true;
            this.onOffButton.ClickOn += new System.ComponentModel.CancelEventHandler(this.onOffButton_ClickOn);
            this.onOffButton.ClickOff += new System.ComponentModel.CancelEventHandler(this.onOffButton_ClickOff);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.button2_3);
            this.groupBox.Controls.Add(this.checkBox2_2);
            this.groupBox.Controls.Add(this.checkBox2_1);
            this.groupBox.Controls.Add(this.button2_2);
            this.groupBox.Controls.Add(this.button2_1);
            this.groupBox.Controls.Add(this.onOffButtonPair);
            this.groupBox.Location = new System.Drawing.Point(12, 227);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(184, 198);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "OnOffButtonPairのテスト";
            // 
            // button2_3
            // 
            this.button2_3.Location = new System.Drawing.Point(5, 168);
            this.button2_3.Name = "button2_3";
            this.button2_3.Size = new System.Drawing.Size(104, 23);
            this.button2_3.TabIndex = 12;
            this.button2_3.Text = "TurnedOnのテスト";
            this.button2_3.UseVisualStyleBackColor = true;
            this.button2_3.Click += new System.EventHandler(this.button2_3_Click);
            // 
            // checkBox2_2
            // 
            this.checkBox2_2.AutoSize = true;
            this.checkBox2_2.Location = new System.Drawing.Point(6, 88);
            this.checkBox2_2.Name = "checkBox2_2";
            this.checkBox2_2.Size = new System.Drawing.Size(103, 16);
            this.checkBox2_2.TabIndex = 7;
            this.checkBox2_2.Text = "OFFのキャンセル";
            this.checkBox2_2.UseVisualStyleBackColor = true;
            // 
            // checkBox2_1
            // 
            this.checkBox2_1.AutoSize = true;
            this.checkBox2_1.Location = new System.Drawing.Point(6, 66);
            this.checkBox2_1.Name = "checkBox2_1";
            this.checkBox2_1.Size = new System.Drawing.Size(97, 16);
            this.checkBox2_1.TabIndex = 6;
            this.checkBox2_1.Text = "ONのキャンセル";
            this.checkBox2_1.UseVisualStyleBackColor = true;
            // 
            // button2_2
            // 
            this.button2_2.Location = new System.Drawing.Point(5, 139);
            this.button2_2.Name = "button2_2";
            this.button2_2.Size = new System.Drawing.Size(104, 23);
            this.button2_2.TabIndex = 5;
            this.button2_2.Text = "TurnOffのテスト";
            this.button2_2.UseVisualStyleBackColor = true;
            this.button2_2.Click += new System.EventHandler(this.button2_2_Click);
            // 
            // button2_1
            // 
            this.button2_1.Location = new System.Drawing.Point(5, 110);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(104, 23);
            this.button2_1.TabIndex = 4;
            this.button2_1.Text = "TurnOn()のテスト";
            this.button2_1.UseVisualStyleBackColor = true;
            this.button2_1.Click += new System.EventHandler(this.button2_1_Click);
            // 
            // onOffButtonPair
            // 
            this.onOffButtonPair.Location = new System.Drawing.Point(6, 18);
            this.onOffButtonPair.Name = "onOffButtonPair";
            this.onOffButtonPair.OffButtonText = "切断します";
            this.onOffButtonPair.OnButtonText = "接続します";
            this.onOffButtonPair.Size = new System.Drawing.Size(160, 23);
            this.onOffButtonPair.TabIndex = 4;
            this.onOffButtonPair.ClickOn += new System.ComponentModel.CancelEventHandler(this.onOffButtonPair_ClickOn);
            this.onOffButtonPair.ClickOff += new System.ComponentModel.CancelEventHandler(this.onOffButtonPair_ClickOff);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toggleSwitch1);
            this.groupBox2.Controls.Add(this.toggleSwitch);
            this.groupBox2.Controls.Add(this.toggleSwitch4);
            this.groupBox2.Location = new System.Drawing.Point(208, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 118);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ToggleSwitchのテスト";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(120, 72);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Size = new System.Drawing.Size(20, 10);
            this.toggleSwitch1.TabIndex = 8;
            this.toggleSwitch1.UseVisualStyleBackColor = true;
            this.toggleSwitch1.CheckedChanged += new System.EventHandler(this.toggleSwitch_CheckedChanged);
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Location = new System.Drawing.Point(6, 21);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.Size = new System.Drawing.Size(40, 20);
            this.toggleSwitch.TabIndex = 5;
            this.toggleSwitch.UseVisualStyleBackColor = true;
            this.toggleSwitch.CheckedChanged += new System.EventHandler(this.toggleSwitch_CheckedChanged);
            // 
            // toggleSwitch4
            // 
            this.toggleSwitch4.Location = new System.Drawing.Point(6, 56);
            this.toggleSwitch4.Name = "toggleSwitch4";
            this.toggleSwitch4.Size = new System.Drawing.Size(86, 43);
            this.toggleSwitch4.TabIndex = 7;
            this.toggleSwitch4.UseVisualStyleBackColor = true;
            this.toggleSwitch4.CheckedChanged += new System.EventHandler(this.toggleSwitch_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toggleSwitchText2);
            this.groupBox3.Controls.Add(this.toggleSwitchText1);
            this.groupBox3.Location = new System.Drawing.Point(208, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 105);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ToggleSwitchTextのテスト";
            // 
            // toggleSwitchText1
            // 
            this.toggleSwitchText1.Checked = false;
            this.toggleSwitchText1.Location = new System.Drawing.Point(7, 25);
            this.toggleSwitchText1.Name = "toggleSwitchText1";
            this.toggleSwitchText1.Size = new System.Drawing.Size(173, 20);
            this.toggleSwitchText1.TabIndex = 0;
            this.toggleSwitchText1.Text = "文字つきのトグルスイッチ";
            this.toggleSwitchText1.CheckedChanged += new System.EventHandler(this.toggleSwitchText_CheckedChanged);
            // 
            // toggleSwitchText2
            // 
            this.toggleSwitchText2.Checked = false;
            this.toggleSwitchText2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toggleSwitchText2.Location = new System.Drawing.Point(6, 53);
            this.toggleSwitchText2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleSwitchText2.Name = "toggleSwitchText2";
            this.toggleSwitchText2.Size = new System.Drawing.Size(207, 37);
            this.toggleSwitchText2.TabIndex = 1;
            this.toggleSwitchText2.Text = "大きい文字";
            this.toggleSwitchText2.CheckedChanged += new System.EventHandler(this.toggleSwitchText_CheckedChanged);
            // 
            // FormTest3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTest3";
            this.Text = "FormTest3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CommonControlPlus.OnOffButton onOffButton;
        private CommonControlPlus.OnOffButtonPair onOffButtonPair;
        private CommonControlPlus.ToggleSwitch toggleSwitch;
        private CommonControlPlus.ToggleSwitch toggleSwitch4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1_2;
        private System.Windows.Forms.Button button1_1;
        private System.Windows.Forms.CheckBox checkBox1_2;
        private System.Windows.Forms.CheckBox checkBox1_1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox checkBox2_2;
        private System.Windows.Forms.CheckBox checkBox2_1;
        private System.Windows.Forms.Button button2_2;
        private System.Windows.Forms.Button button2_1;
        private System.Windows.Forms.Button button1_3;
        private System.Windows.Forms.Button button2_3;
        private System.Windows.Forms.GroupBox groupBox2;
        private CommonControlPlus.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.GroupBox groupBox3;
        private CommonControlPlus.ToggleSwitchText toggleSwitchText1;
        private CommonControlPlus.ToggleSwitchText toggleSwitchText2;
    }
}