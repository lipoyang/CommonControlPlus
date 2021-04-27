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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericBox1 = new CommonControlPlus.NumericBox();
            this.toggleSwitch2 = new CommonControlPlus.ToggleSwitch();
            this.toggleSwitch1 = new CommonControlPlus.ToggleSwitch();
            this.numericBox2 = new CommonControlPlus.NumericBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(29, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // numericBox1
            // 
            this.numericBox1.FormatString = "";
            this.numericBox1.Location = new System.Drawing.Point(112, 247);
            this.numericBox1.MaxValue = null;
            this.numericBox1.MinValue = null;
            this.numericBox1.Name = "numericBox1";
            this.numericBox1.Size = new System.Drawing.Size(219, 21);
            this.numericBox1.StepValue = 1;
            this.numericBox1.TabIndex = 3;
            this.numericBox1.Value = 0;
            // 
            // toggleSwitch2
            // 
            this.toggleSwitch2.Checked = true;
            this.toggleSwitch2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleSwitch2.Location = new System.Drawing.Point(68, 382);
            this.toggleSwitch2.Name = "toggleSwitch2";
            this.toggleSwitch2.Size = new System.Drawing.Size(40, 20);
            this.toggleSwitch2.TabIndex = 0;
            this.toggleSwitch2.UseVisualStyleBackColor = true;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(68, 355);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Size = new System.Drawing.Size(40, 20);
            this.toggleSwitch1.TabIndex = 1;
            this.toggleSwitch1.UseVisualStyleBackColor = true;
            // 
            // numericBox2
            // 
            this.numericBox2.FormatString = "";
            this.numericBox2.Location = new System.Drawing.Point(136, 325);
            this.numericBox2.MaxValue = null;
            this.numericBox2.MinValue = null;
            this.numericBox2.Name = "numericBox2";
            this.numericBox2.Size = new System.Drawing.Size(111, 21);
            this.numericBox2.StepValue = 1;
            this.numericBox2.TabIndex = 4;
            this.numericBox2.Value = 0;
            // 
            // FormTest3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericBox2);
            this.Controls.Add(this.numericBox1);
            this.Controls.Add(this.toggleSwitch2);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.checkBox1);
            this.Name = "FormTest3";
            this.Text = "FormTest3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private CommonControlPlus.ToggleSwitch toggleSwitch1;
        private CommonControlPlus.ToggleSwitch toggleSwitch2;
        private CommonControlPlus.NumericBox numericBox1;
        private CommonControlPlus.NumericBox numericBox2;
    }
}