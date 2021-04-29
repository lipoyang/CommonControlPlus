using System;
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
    [DefaultEvent("Changed")]
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
        /// 入力エラー時にメッセージボックスでメッセージを出すか？
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public bool ErrorMessageBoxEnabled
        {
            set => textBox.ErrorMessageBoxEnabled = value;
            get => textBox.ErrorMessageBoxEnabled;
        }
        /// <summary>
        /// 入力エラー時にコンソール出力にメッセージを出すか？
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public bool ErrorOutputEnabled
        {
            set => textBox.ErrorOutputEnabled = value;
            get => textBox.ErrorOutputEnabled;
        }
        /// <summary>
        /// エラーメッセージをここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public string ErrorMessage
        {
            set => textBox.ErrorMessage = value;
            get => textBox.ErrorMessage;
        }

        /// <summary>
        /// +/-のオートリピート開始までの時間[ミリ秒]
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public int AutoRepeatDelay { set; get; } = 500;

        /// <summary>
        /// +/-のオートリピート周期[ミリ秒]
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public int AutoRepeatInterval { set; get; } = 200;

        /// <summary>
        /// テキストの水平配置
        /// </summary>
        [Category("表示")]
        [Browsable(true)]
        public HorizontalAlignment TextAlign
        {
            get => textBox.TextAlign;
            set => textBox.TextAlign = value;
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
        /// 表示される文字列
        /// </summary>
        [Browsable(false)] // デザイナのプロパティグリッドには非表示
        override public string Text
        {
            set { /* 握りつぶす */ }
            get
            {
                return this.textBox.Text;
            }
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

            // デフォルトは右詰め
            this.TextAlign = HorizontalAlignment.Right;

            // サイズ変化時の処理
            oldHeight = this.Height;
            oldTextBoxHeight = this.textBox.Height;
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
            this.textBox.SizeChanged += new System.EventHandler(this.OnSizeChanged);

            // オートリピート用タイマ
            autoRepeatTimer = new Timer(this.components); // リソース解放のための引数を用いる
            autoRepeatTimer.Tick += AutoRepeatHandler;
            autoRepeatTimer.Stop();
        }

        #endregion

        #region 内部処理

        // 前回の高さを保持
        private int oldHeight;
        private int oldTextBoxHeight;

        // オートリピート状態
        private enum AutoRepeatState { Stop, Start, Repeat };
        private AutoRepeatState autoRepeatState = AutoRepeatState.Stop;
        // オートリピートのステップ
        private Type autoRepeatStep = (dynamic)0;
        // オートリピート用タイマ
        private readonly Timer autoRepeatTimer;
        // オートリピートの排他制御用
        private readonly object autoRepeatLock = new object();
        // オートリピートの開始前の値
        private Type oldValue;

        // オートリピート用タイマハンドラ
        private void AutoRepeatHandler(object sender, EventArgs e)
        {
            lock (autoRepeatLock)
            {
                // オートリピート開始
                if (autoRepeatState == AutoRepeatState.Start)
                {
                    autoRepeatTimer.Stop();
                    autoRepeatState = AutoRepeatState.Repeat;
                    autoRepeatTimer.Interval = AutoRepeatInterval;
                    autoRepeatTimer.Start();
                }
                // カウントアップダウン
                CountUpDown();
            }
        }

        // アップ・ダウンボタンが押されたとき
        private void buttons_MouseDown(object sender, MouseEventArgs e)
        {
            lock (autoRepeatLock)
            {
                oldValue = textBox.Value; // 元の値を保持

                if ((Button)sender == buttonDown)
                {
                    autoRepeatStep = -(dynamic)StepValue; // ダウンボタン
                }
                else
                {
                    autoRepeatStep = +(dynamic)StepValue; // アップボタン
                }
                // タイマの開始
                autoRepeatState = AutoRepeatState.Start;
                autoRepeatTimer.Interval = AutoRepeatDelay;
                autoRepeatTimer.Start();
            }
        }

        // アップ・ダウンボタンが離されたとき
        private void buttons_MouseUp(object sender, MouseEventArgs e)
        {
            lock (autoRepeatLock)
            {
                // タイマの停止
                autoRepeatTimer.Stop();

                // 通常の短いクリックのときは1回ぶんだけ増減
                if (autoRepeatState == AutoRepeatState.Start) CountUpDown();
                autoRepeatState = 0;
            }
            // 値が変化していたらイベント発行
            if(textBox.Value != (dynamic)oldValue)
            {
                this.Changed(this, e);
            }
        }

        // カウントアップ/ダウン
        private void CountUpDown()
        {
            Type newVal = (dynamic)textBox.Value + autoRepeatStep;

            if ((MaxValue != null) && (newVal.CompareTo(MaxValue) > 0))
            {
                newVal = (Type)MaxValue;
            }
            if ((MinValue != null) && (newVal.CompareTo(MinValue) < 0))
            {
                newVal = (Type)MinValue;
            }
            textBox.Value = newVal;
        }

        // 入力されたテキストの変更が確定したとき
        private void textBox_Changed(object sender, EventArgs e)
        {
            // イベント発行
            this.Changed(this, e);
        }

        // サイズ変化時の処理
        private void OnSizeChanged(object sender, System.EventArgs e)
        {
            if ((this.Height != oldHeight) || 
                (this.textBox.Height != oldTextBoxHeight))
            {
                this.Height = textBox.Height+2;
            }
            int h = this.Height;
            buttonDown.Width = h;
            buttonUp.Width = h;

            oldHeight = this.Height;
            oldTextBoxHeight = this.textBox.Height;

            // 再描画
            this.Refresh();
        }

        // デザイナでフォントをいじると位置がずれる問題の対策
        protected override void OnFontChanged(EventArgs e)
        {
            Point location = this.Location;
            //Rectangle bounds = this.Bounds;
            //Padding margin = this.Margin;

            base.OnFontChanged(e);

            this.Location = location;
            //this.Bounds = bounds;
            //this.Margin = margin;
        }
#endregion

#region コンポーネント デザイナーで生成されたコードを流用

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private TextBoxNumeric<Type> textBox;

        // リソースの管理用
        private System.ComponentModel.IContainer components = null;

        // 使用中のリソースをすべてクリーンアップします。
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // 初期化処理
        private void InitializeComponent()
        {
            // デフォルトの高さ・ボタンの幅
            const int H = 20;
            // デフォルトの幅
            const int W = 110;

            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.textBox = new CommonControlPlus.TextBoxNumeric<Type>();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();

            // tableLayoutPanel
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.buttonDown, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonUp, 2, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(W, H);
            this.tableLayoutPanel.TabIndex = 0;

            // buttonDown
            this.buttonDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDown.Location = new System.Drawing.Point(0, 0);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(H, H);
            this.buttonDown.TabIndex = 0;
            this.buttonDown.Text = "-";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.MouseDown += buttons_MouseDown;
            this.buttonDown.MouseUp += buttons_MouseUp;
            
            // buttonUp
            this.buttonUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(H, H);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.Text = "+";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.MouseDown += buttons_MouseDown;
            this.buttonUp.MouseUp += buttons_MouseUp;
            
            // textBox
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.ErrorMessage = "";
            this.textBox.ErrorMessageBoxEnabled = false;
            this.textBox.ErrorOutputEnabled = false;
            this.textBox.FormatString = "";
            this.textBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.textBox.MaxValue = null;
            this.textBox.MinValue = null;
            this.textBox.Name = "textBox";
            this.textBox.StepValue = (dynamic)1;
            this.textBox.TabIndex = 1;
            this.textBox.Text = "0";
            this.textBox.Value = (dynamic)0;
            this.textBox.Changed += this.textBox_Changed;
            
            // NumericBox
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "NumericBox";
            this.Size = new System.Drawing.Size(W, H);
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
