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
    /// トグルスイッチ型のチェックボックス (文字あり)
    /// </summary>
    public partial class ToggleSwitchText : UserControl
    {
        #region イベント

        /// <summary>
        /// Checkedの値が変更したときに発生するイベント
        /// </summary>
        [Browsable(true)]
        public event EventHandler CheckedChanged = delegate { };

        #endregion

        #region プロパティ

        /// <summary>
        /// コントロールに関連付けられたテキストです。
        /// </summary>
        [Category("表示")]
        [Browsable(true)]
        override public string Text
        {
            get => this.label.Text;
            set => this.label.Text = value;
        }

        /// <summary>
        /// コントロールがチェックされた状態かどうかを示します。
        /// </summary>
        [Category("表示")]
        [Browsable(true)]
        public bool Checked
        {
            get => this.toggleSwitch.Checked;
            set => this.toggleSwitch.Checked = value;
        }

        #endregion

        #region コンストラクタ
        public ToggleSwitchText()
        {
            InitializeComponent();
            this.Height = 20;
        }
        #endregion

        #region 内部処理

        // チェックが変化したとき
        private void toggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            // イベント発行
            this.CheckedChanged(this, e);
        }
        #endregion
    }
}
