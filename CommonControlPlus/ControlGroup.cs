using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommonControlPlus
{
    /// <summary>
    /// コントロールをまとめて有効/無効にするためのグループ。
    /// GroupBox等のコンテナを用いずにグループ化するためのクラス。
    /// </summary>
    public class ControlGroup
    {
        #region プロパティ

        /// <summary>
        /// コントロールの有効/無効
        /// </summary>
        public bool Enabled
        {
            get => _Enabled;

            set
            {
                // 登録されたコントロールをまとめて有効/無効
                foreach(var control in Controls)
                {
                    control.Enabled = value;
                }
                _Enabled = value;
            }
        }

        #endregion

        #region 公開メソッド

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ControlGroup()
        {
            Controls.Clear();
        }

        /// <summary>
        /// コントロールをグループに追加します
        /// </summary>
        /// <param name="control">追加するコントロール</param>
        public void Add(Control control)
        {
            Controls.Add(control);
        }

        #endregion

        #region 内部処理

        // 有効/無効
        private bool _Enabled = false;
        
        // 登録されたコントロール
        private readonly List<Control> Controls = new List<Control>();
        
        #endregion

    }
}
