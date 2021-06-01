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
    [DefaultEvent("CheckedChanged")]
    public partial class ToggleSwitchText : UserControl
    {
        #region イベント

        /// <summary>
        /// Checkedの値が変更したときに発生するイベント
        /// </summary>
        [Browsable(true)]
        [Description("Checkedの値が変更したときに発生します。")]
        public event EventHandler CheckedChanged = delegate { };

        #endregion

        #region プロパティ

        /// <summary>
        /// コントロールに関連付けられたテキストです。
        /// </summary>
        [Category("表示")]
        [Description("コントロールに関連付けられたテキストです。")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // これが無いとビルド時にデザイナでの設定が消える！
        override public string Text
        {
            get
            {
                return this.label.Text;
            }
            set
            {
                this.label.Text = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// コントロールがチェックされた状態かどうかを示します。
        /// </summary>
        [Category("表示")]
        [Description("コントロールがチェックされた状態かどうかを示します。")]
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
    }
}
