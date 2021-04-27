using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel; // [Browsable(true)]

namespace CommonControlPlus
{
    /// <summary>
    /// トグルスイッチ型のチェックボックス (文字なし)
    /// </summary>
    public class ToggleSwitch : CheckBox
    {
        #region プロパティ


        // AutoSizeは無効にする
        [Browsable(false)] // プロパティグリッドに表示させない
        public override bool AutoSize
        {
            get{ return false; }
            set{ ; /* もみ消す */ }
        }

        // Textは意味を持たない
        [Browsable(false)] // プロパティグリッドに表示させない
        override public string Text
        {
            get { return ""; }
            set {; /* もみ消す */ }
        }

        #endregion

        #region コンストラクタ

        // コンストラクタ
        public ToggleSwitch()
        {
            // 自前で描画に設定
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            // AutoSizeにしない
            base.AutoSize = false;
            // 文字は無し
            base.Text = "";
            // デフォルトのサイズ
            this.Height = 20;
            this.Width = 40;
            oldHeight = this.Height;
            // サイズ変化時の処理
            this.SizeChanged += new System.EventHandler(this.OnSizeChanged);
        }
#endregion

        #region 内部処理
        
        // 前回の高さを保持
        private int oldHeight;

        // 描画処理
        protected override void OnPaint(PaintEventArgs e)
        {
            // 背景の描画
            this.OnPaintBackground(e);
            
            // アンチエイリアスの設定
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = new GraphicsPath())
            {
                // 穴の高さ
                var h = this.Height-1;
                // 穴の幅
                var w = h * 2;
                // 穴の描画
                path.AddArc(0, 0, h, h, 90, 180);
                path.AddArc(w - h, 0, h, h, -90, 180);
                path.CloseFigure();
                e.Graphics.FillPath(Checked ? SystemBrushes.Highlight : SystemBrushes.Control, path);
                e.Graphics.DrawPath(SystemPens.ButtonShadow, path);
                // ボタンの半径
                var r = this.Height - 3;
                var rect = Checked ? new Rectangle(w - h + 1, 1, r, r)
                                   : new Rectangle(1, 1, r, r);
                e.Graphics.FillEllipse(Brushes.White, rect);
                e.Graphics.DrawEllipse(SystemPens.ButtonShadow, rect);
            }
        }

        // サイズ変化時の処理
        private void OnSizeChanged(object sender, System.EventArgs e)
        {
            if(this.Height != oldHeight)
            {
                this.Width = this.Height * 2;
            }
            
            if(this.Width != this.Height * 2)
            {
                this.Width = this.Height * 2;
            }
            oldHeight = this.Height;

            // 再描画
            this.Refresh();
        }
        #endregion
    }
}
