namespace CommonControlPlus
{
    partial class OnOffButton2
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
            this.buttonOn = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.buttonOn, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonOff, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(160, 23);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // buttonOn
            // 
            this.buttonOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOn.Location = new System.Drawing.Point(0, 0);
            this.buttonOn.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonOn.Name = "buttonOn";
            this.buttonOn.Size = new System.Drawing.Size(77, 23);
            this.buttonOn.TabIndex = 0;
            this.buttonOn.Text = "ON";
            this.buttonOn.UseVisualStyleBackColor = true;
            this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
            // 
            // buttonOff
            // 
            this.buttonOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOff.Location = new System.Drawing.Point(83, 0);
            this.buttonOff.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(77, 23);
            this.buttonOff.TabIndex = 1;
            this.buttonOff.Text = "OFF";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
            // 
            // OnOffButton2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "OnOffButton2";
            this.Size = new System.Drawing.Size(160, 23);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonOn;
        private System.Windows.Forms.Button buttonOff;
    }
}
