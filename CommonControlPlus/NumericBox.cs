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
    public partial class NumericBox : UserControl
    {
        #region イベント

        /// <summary>
        /// 値の変更が確定したときに発生するイベント
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event EventHandler Changed = delegate { };

        /// <summary>
        /// 入力値チェック関数の型
        /// </summary>
        /// <param name="inputVal">入力された数値</param>
        /// <returns>OK(true)かNG(false)か</returns>
        public delegate bool InputValueCheckFunction(Type inputVal);

        /// <summary>
        /// 入力値チェック関数をここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event InputValueCheckFunction InputValueCheck = null;

        #endregion

        #region プロパティ

        /// <summary>
        /// 入力できる最大値
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public int? MaxValue {
            set => textBox.MaxValue = value;
            get => textBox.MaxValue;
        }

        /// <summary>
        /// 入力できる最小値
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public int? MinValue
        {
            set => textBox.MinValue = value;
            get => textBox.MinValue;
        }

        /// <summary>
        /// 入力できる値の最小幅
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public int? StepValue
        {
            set => textBox.StepValue = value;
            get => textBox.StepValue;
        }

        /// <summary>
        /// 数値
        /// </summary>
        public int Value
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
            int val = textBox.Value - (int)StepValue;
            if(MinValue != null)
            {
                if (val > (int)MinValue)
                {
                    textBox.Value = val;
                }
                else
                {
                    textBox.Value = (int)MinValue;
                }
            }
        }

        // アップボタンが押されたとき
        private void buttonUp_Click(object sender, EventArgs e)
        {
            int val = textBox.Value + (int)StepValue;
            if (MaxValue != null)
            {
                if (val < (int)MaxValue)
                {
                    textBox.Value = val;
                }
                else
                {
                    textBox.Value = (int)MaxValue;
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
        private bool textBox_InputValueCheck(int inputVal)
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
    }
}
