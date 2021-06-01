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
    /// 拡張版コンボボックス
    /// </summary>
    [DefaultEvent("Changed")]
    public class ComboBoxPlus : ComboBox
    {
        #region イベント

        /// <summary>
        /// 値の変更が確定したときに発生するイベント
        /// </summary>
        [Category("拡張機能")]
        [Description("値の変更が確定したときに発生します。")]
        [Browsable(true)]
        public event EventHandler Changed = delegate { };

        /// <summary>
        /// 入力文字列チェック関数の型
        /// </summary>
        /// <param name="inputText">入力された文字列</param>
        /// <returns>OK(true)かNG(false)か</returns>
        public delegate bool InputTextCheckFunction(string inputText);

        /// <summary>
        /// 入力文字列チェック関数をここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Description("入力文字列チェック関数をここに設定します。")]
        [Browsable(true)]
        public event InputTextCheckFunction InputTextCheck = null;

        #endregion

        #region プロパティ

        /// <summary>
        /// 入力エラー時にメッセージボックスでメッセージを出すか？
        /// </summary>
        [Category("拡張機能")]
        [Description("入力エラー時にメッセージボックスでメッセージを出すか？")]
        [Browsable(true)]
        public bool ErrorMessageBoxEnabled { set; get; } = false;

        /// <summary>
        /// 入力エラー時にコンソール出力にメッセージを出すか？
        /// </summary>
        [Category("拡張機能")]
        [Description("入力エラー時にコンソール出力にメッセージを出すか？")]
        [Browsable(true)]
        public bool ErrorOutputEnabled { set; get; } = false;

        /// <summary>
        /// エラーメッセージをここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Description("エラーメッセージをここに設定します。")]
        [Browsable(true)]
        public string ErrorMessage { set; get; } = "";

        #endregion

        #region 公開メソッド

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ComboBoxPlus()
        {
            this.CausesValidation = true; // 検証イベントを有効
        }

        /// <summary>
        /// リストを検索して項目を選択する
        /// </summary>
        /// <param name="obj">選択したい項目</param>
        /// <returns>項目が存在したか</returns>
        public bool SelectItem(object obj)
        {
            if (obj == null) return false;

            this.SelectedItem = obj;

            if((this.SelectedItem != null) &&
               (this.SelectedItem.ToString() == obj.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// リストを検索して項目を選択する。存在しなければ追加して選択する。
        /// </summary>
        /// <param name="obj">選択したい項目</param>
        /// <returns>項目が存在したか</returns>
        public bool SelectOrAddItem(object obj)
        {
            if (obj == null) return false;

            this.SelectedItem = obj;

            if ((this.SelectedItem != null) &&
               (this.SelectedItem.ToString() == obj.ToString()))
            {
                return true;
            }
            else
            {
                this.Items.Add(obj);
                this.SelectedItem = obj;
                return false;
            }
        }

        /// <summary>
        /// オブジェクトの配列をリストに追加する。int[]など、Items.AddRange()が使えない配列にも対応。
        /// </summary>
        /// <param name="arrayObject">追加するオブジェクトの配列</param>
        public void AddArray(object arrayObject)
        {
            Array array = (Array)arrayObject;
            foreach(object obj in array)
            {
                this.Items.Add(obj);
            }
        }

        #endregion

        #region 内部処理

        // 前回のテキスト (フォーカスが外れたときの判定用)
        protected string OldText = "";
        // 前回の選択アイテム (フォーカスが外れたときの判定用)
        protected object OldItem = null;

        // フォーカスが入ったとき
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);

            // 前回の値を更新
            OldText = this.Text;
        }

        // リスト選択が変更されたとき
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            // 前回の選択値を更新し、イベント発行
            OldItem = this.SelectedItem;
            OldText = this.Text;
            Changed(this, e);
        }

        // キーが押されたとき
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            
            //Enterキーが押されたか？
            if (e.KeyCode == Keys.Enter)
            {
                // 前回の値から変更されているか？
                if (OldText != this.Text)
                {
                    // 入力チェックと値の更新
                    if (InputCheckAndUpdate(this.Text))
                    {
                        Changed(this, e); // イベント発行
                    }
                }
            }
        }

        // フォーカスが外れたときの検証イベント
        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);

            // 前回の値から変更されているか？
            if (OldText != this.Text)
            {
                // 入力チェックと値の更新
                if (InputCheckAndUpdate(this.Text))
                {
                    Changed(this, e); // イベント発行
                }
                else
                {
                    e.Cancel = true; // 検証の結果、キャンセルを返す
                }
            }
        }

        // エラーメッセージの出力
        protected void ErrorMessageOutput()
        {
            if (ErrorMessage != "")
            {
                if (ErrorMessageBoxEnabled)
                {
                    MessageBox.Show(ErrorMessage, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ErrorOutputEnabled)
                {
                    Console.WriteLine(this.Name + ": " + ErrorMessage);
                }
            }
        }

        // 入力チェックと値の更新
        virtual protected bool InputCheckAndUpdate(string text)
        {
            bool result = true;
            if (InputTextCheck != null)
            {
                // ユーザー定義の入力チェック
                result = InputTextCheck(text);
            }
            if (result)
            {
            	// 前回の選択値を更新
                OldItem = this.SelectedItem;
                OldText = this.Text;
            }
            else
            {
                ErrorMessageOutput();

                // 前回の選択値に戻す
                this.SelectedItem = OldItem;
                if (OldItem == null) this.Text = OldText;
            }
            return result;
        }

        #endregion
    }
}
