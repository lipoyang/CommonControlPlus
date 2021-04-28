﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControlPlus
{
    /// <summary>
    /// 数値ボックス (UP/DOWNボタン付き)
    /// </summary>
    /// <typeparam name="Type">数値の型 (int, double, decimal のいずれか)</typeparam>
    public class NumericBox<Type> : UserControl where Type : struct, IComparable, IFormattable
    {
        #region イベント

        /// <summary>
        /// 値の変更が確定したときに発生するイベント
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event EventHandler Changed = delegate { };

        /// <summary>
        /// 入力値チェック関数をここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public TextBoxNumeric<Type>.InputValueCheckFunction InputValueCheck
        {
            get => textBox.InputValueCheck;
            set => textBox.InputValueCheck = value;
        }

        #endregion

        #region プロパティ

        /// <summary>
        /// 入力できる最大値
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public Type? MaxValue {
            set => textBox.MaxValue = value;
            get => textBox.MaxValue;
        }

        /// <summary>
        /// 入力できる最小値
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public Type? MinValue
        {
            set => textBox.MinValue = value;
            get => textBox.MinValue;
        }

        /// <summary>
        /// 入力できる値の最小幅
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public Type? StepValue
        {
            set => textBox.StepValue = value;
            get => textBox.StepValue;
        }

        /// <summary>
        /// 数値
        /// </summary>
        public Type Value
        {
            set => textBox.Value = value;
            get => textBox.Value;
        }

        /// <summary>
        /// 数値書式指定文字列
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public string FormatString
        {
            set => textBox.FormatString = value;
            get => textBox.FormatString;
        }

        #endregion
 
        #region コンストラクタ
        public NumericBox()
        {
            InitializeComponent();

            // デフォルトの最小幅は1
            this.StepValue = (dynamic)1;
            // デフォルトのサイズ
            this.Height = 20;
            this.Width = 80;
            oldHeight = this.Height;
            // サイズ変化時の処理
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
        }

        #endregion

        #region 内部処理

        // 前回の高さを保持
        private int oldHeight;

        // ダウンボタンが押されたとき
        private void buttonDown_Click(object sender, EventArgs e)
        {
            Type val = (dynamic)textBox.Value - (Type)StepValue;
            if(MinValue != null)
            {
                if (val.CompareTo(MinValue) > 0)
                {
                    textBox.Value = val;
                }
                else
                {
                    textBox.Value = (Type)MinValue;
                }
            }
        }

        // アップボタンが押されたとき
        private void buttonUp_Click(object sender, EventArgs e)
        {
            Type val = (dynamic)textBox.Value + (Type)StepValue;
            if (MaxValue != null)
            {
                if (val.CompareTo(MaxValue) < 0)
                {
                    textBox.Value = val;
                }
                else
                {
                    textBox.Value = (Type)MaxValue;
                }
            }
        }

        // 値が変化したとき
        private void textBox_Changed(object sender, EventArgs e)
        {
            // イベント発行
            this.Changed(this, e);
        }

        // 入力チェック
        private bool textBox_InputValueCheck(Type inputVal)
        {
            return true;
        }

        // サイズ変化時の処理
        private void OnSizeChanged(object sender, System.EventArgs e)
        {
            if (this.Height != oldHeight)
            {
                this.Height = textBox.Height+2;
            }
            int h = this.Height;
            int w = this.Width;
            buttonDown.Width = h;
            buttonUp.Width = h;
            //textBox.Width = w - 2 * (h - 2);

            oldHeight = this.Height;

            // 再描画
            this.Refresh();
        }
        #endregion

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

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private TextBoxNumeric<Type> textBox;

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.textBox = new CommonControlPlus.TextBoxNumeric<Type>();
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
            this.textBox.Value = (dynamic)0;
            this.textBox.Changed += this.textBox_Changed;
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
    }

    /// <summary>
    /// double型数値用の数値ボックス
    /// </summary>
    public class NumericBoxDouble : NumericBox<double>
    {
    }

    /// <summary>
    /// decimal型数値用の数値ボックス
    /// </summary>
    public class NumericBoxDecimal : NumericBox<decimal>
    {
    }

    /// <summary>
    /// int型数値用の数値ボックス
    /// </summary>
    public class NumericBoxInteger : NumericBox<int>
    {
    }
}