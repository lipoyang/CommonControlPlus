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
    [DefaultEvent("OnOffChanged")]
    public class OnOffButton : Button
    {
        #region イベント

        /// <summary>
        /// ON/OFF状態が変化したときのイベント
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event CancelEventHandler OnOffChanged = delegate { };

        #endregion

        #region プロパティ

        // ボタンのテキスト
        [Browsable(false)] // プロパティグリッドに表示させない
        override public string Text
        {
            get
            {
                return _TurnedOn ? _OffButtonText : _OnButtonText;
            }
            set
            {
                // Textへの直接代入は無効
            }
        }

        [Category("拡張機能")]
        [Browsable(true)]
        // ON/OFF状態
        public bool TurnedOn
        {
            get
            {
                return _TurnedOn;
            }
            set
            {
                _TurnedOn = value;
            }
        }

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

        // ON/OFF状態
        private bool _TurnedOn = false;
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
            OnOffChanged(this, result);

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
