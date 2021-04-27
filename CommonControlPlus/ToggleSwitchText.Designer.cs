namespace CommonControlPlus
{
    partial class ToggleSwitchText
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
            this.label = new System.Windows.Forms.Label();
            this.toggleSwitch = new CommonControlPlus.ToggleSwitch();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.label, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.toggleSwitch, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(147, 20);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(43, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(25, 20);
            this.label.TabIndex = 1;
            this.label.Text = "text";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toggleSwitch
            // 
            this.toggleSwitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleSwitch.Location = new System.Drawing.Point(0, 0);
            this.toggleSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.toggleSwitch.Name = "toggleSwitch";
            this.toggleSwitch.Size = new System.Drawing.Size(40, 20);
            this.toggleSwitch.TabIndex = 0;
            this.toggleSwitch.UseVisualStyleBackColor = true;
            this.toggleSwitch.CheckedChanged += new System.EventHandler(this.toggleSwitch_CheckedChanged);
            // 
            // ToggleSwitchText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "ToggleSwitchText";
            this.Size = new System.Drawing.Size(147, 20);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private ToggleSwitch toggleSwitch;
        private System.Windows.Forms.Label label;
    }
}
