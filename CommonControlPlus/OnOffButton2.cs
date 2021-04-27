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
    /// ON/OFFボタン (ボタン2個)
    /// </summary>
    public partial class OnOffButton2 : UserControl
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

        // Textは意味を持たない
        [Browsable(false)] // プロパティグリッドに表示させない
        override public string Text
        {
            get; set;
        }

        [Browsable(true)]
        override public Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                buttonOn.Font = base.Font;
                buttonOff.Font = base.Font;
                this.Invalidate();
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
                return buttonOn.Text;
            }
            set
            {
                buttonOn.Text = value;
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
                return buttonOff.Text;
            }
            set
            {
                buttonOff.Text = value;
                this.Invalidate();
            }
        }

        #endregion

        #region 公開メソッド

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public OnOffButton2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ソフトでONする
        /// </summary>
        public void TurnOn()
        {
            if (!TurnedOn)
            {
                buttonOn.PerformClick();
            }
        }

        /// <summary>
        /// ソフトでOFFする
        /// </summary>
        public void TurnOff()
        {
            if (TurnedOn)
            {
                buttonOff.PerformClick();
            }
        }

        #endregion

        #region 内部処理

        // ON/OFF状態
        private bool _TurnedOn = false;

        // ONボタンが押されたとき
        private void buttonOn_Click(object sender, EventArgs e)
        {
            // イベント発行
            var result = new CancelEventArgs();
            ClickOn(this, result);

            // キャンセルされたとき
            if (result.Cancel)
            {
                TurnedOn = false;
                buttonOn.Enabled = true;
                buttonOff.Enabled = false;
            }
            else
            {
                TurnedOn = true;
                buttonOn.Enabled = false;
                buttonOff.Enabled = true;
            }

            this.Invalidate();
        }

        // Offボタンが押されたとき
        private void buttonOff_Click(object sender, EventArgs e)
        {
            // イベント発行
            var result = new CancelEventArgs();
            ClickOff(this, result);

            // キャンセルされたとき
            if (result.Cancel)
            {
                TurnedOn = true;
                buttonOn.Enabled = false;
                buttonOff.Enabled = true;
            }
            else
            {
                TurnedOn = false;
                buttonOn.Enabled = true;
                buttonOff.Enabled = false;
            }

            this.Invalidate();
        }
        #endregion
    }
}
