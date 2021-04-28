using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel; // [Browsable(true)]

namespace CommonControlPlus
{
    /// <summary>
    /// ON/OFFボタン
    /// </summary>
    [DefaultEvent("ClickOn")]
    public class OnOffButton : Button
    {
        #region イベント

        /// <summary>
        /// ONボタンがおされたときのイベント
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event CancelEventHandler ClickOn = delegate { };
        /// <summary>
        /// OFFボタンがおされたときのイベント
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event CancelEventHandler ClickOff = delegate { };

        #endregion

        #region プロパティ

        // ボタンのテキスト
        [Browsable(false)] // プロパティグリッドに表示させない
        override public string Text
        {
            get
            {
                return TurnedOn ? _OffButtonText : _OnButtonText;
            }
            set
            {
                // Textへの直接代入は無効
            }
        }

        // ON/OFF状態
        public bool TurnedOn { get; private set; }

        /// <summary>
        /// ONボタンのテキスト
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public string OnButtonText
        {
            get
            {
                return _OnButtonText;
            }
            set
            {
                _OnButtonText = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// OFFボタンのテキスト
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public string OffButtonText
        {
            get
            {
                return _OffButtonText;
            }
            set
            {
                _OffButtonText = value;
                this.Invalidate();
            }
        }
        #endregion

        #region 公開メソッド

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public OnOffButton()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// ソフトでONする
        /// </summary>
        public void TurnOn()
        {
            if (!TurnedOn)
            {
                this.PerformClick();
            }
        }

        /// <summary>
        /// ソフトでOFFする
        /// </summary>
        public void TurnOff()
        {
            if (TurnedOn)
            {
                this.PerformClick();
            }
        }
        #endregion

        #region 内部処理

        // ONボタンのテキスト
        private string _OnButtonText = "ON";
        // OFFボタンのテキスト
        private string _OffButtonText = "OFF";

        // 初期化
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // OnOffButton
            // 
            this.Click += new System.EventHandler(this.OnOffButton_Click);
            this.ResumeLayout(false);
        }

        // クリックされたとき
        private void OnOffButton_Click(object sender, EventArgs e)
        {
            // イベント発行
            var result = new CancelEventArgs();
            if (TurnedOn)
            {
                ClickOff(this, result);
            }
            else
            {
                ClickOn(this, result);
            }

            // キャンセルでなければ状態をトグル
            if (!result.Cancel)
            {
                this.TurnedOn = !this.TurnedOn;
            }

            this.Invalidate();
        }

        #endregion
    }
}
