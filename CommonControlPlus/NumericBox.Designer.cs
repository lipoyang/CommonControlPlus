namespace CommonControlPlus
{
    partial class NumericBox
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.textBox = new CommonControlPlus.TextBoxInteger();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.buttonDown, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonUp, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(124, 23);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonDown
            // 
            this.buttonDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDown.Location = new System.Drawing.Point(0, 0);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(23, 23);
            this.buttonDown.TabIndex = 0;
            this.buttonDown.Text = "-";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUp.Location = new System.Drawing.Point(101, 0);
            this.buttonUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(23, 23);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Text = "+";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.ErrorMessage = "";
            this.textBox.ErrorMessageBoxEnabled = false;
            this.textBox.ErrorOutputEnabled = false;
            this.textBox.FormatString = "";
            this.textBox.Location = new System.Drawing.Point(23, 1);
            this.textBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.textBox.MaxValue = null;
            this.textBox.MinValue = null;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(78, 19);
            this.textBox.StepValue = null;
            this.textBox.TabIndex = 3;
            this.textBox.Text = "0";
            this.textBox.Value = 0;
            this.textBox.InputValueCheck += new CommonControlPlus.TextBoxNumeric<int>.InputValueCheckFunction(this.textBox_InputValueCheck);
            this.textBox.Changed += new System.EventHandler(this.textBox_Changed);
            // 
            // NumericBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "NumericBox";
            this.Size = new System.Drawing.Size(124, 23);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private TextBoxInteger textBox;
    }
}
