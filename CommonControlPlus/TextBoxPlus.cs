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
    /// 拡張版テキストボックス
    /// </summary>
    [DefaultEvent("Changed")]
    public class TextBoxPlus : TextBox
    {
        #region イベント

        /// <summary>
        /// 値の変更が確定したときに発生するイベント
        /// </summary>
        [Category("拡張機能")]
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
        [Browsable(true)]
        event InputTextCheckFunction InputTextCheck = null;

        #endregion

        #region プロパティ

        /// <summary>
        /// 入力エラー時にメッセージボックスでメッセージを出すか？
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public bool ErrorMessageBoxEnabled { set; get; } = false;

        /// <summary>
        /// 入力エラー時にコンソール出力にメッセージを出すか？
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public bool ErrorOutputEnabled { set; get; } = false;

        /// <summary>
        /// エラーメッセージをここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public string ErrorMessage { set; get; } = "";
        #endregion

        #region コンストラクタ
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TextBoxPlus()
        {
            this.InitializeComponent();
            this.CausesValidation = true; // 検証イベントを有効
        }
        #endregion

        #region 内部処理

        // 前回のテキスト (フォーカスが外れたときの判定用)
        private string OldText = "";

        // 初期化
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // TextBoxPlus
            // 
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPlus_KeyDown);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxPlus_Validating);
            this.ResumeLayout(false);

        }

        // キーが押されたとき
        private void TextBoxPlus_KeyDown(object sender, KeyEventArgs e)
        {
            //Enterキーが押されたか？
            if (e.KeyCode == Keys.Enter)
            {
                // 前回の値から変更されているか？
                if (OldText != this.Text)
                {
                    // 入力チェックと値の更新
                    if (InputCheckAndUpdate(this.Text))
                    {
                        Changed(sender, e); // イベント発行
                    }
                }
            }
        }

        // フォーカスが外れたときの検証イベント
        private void TextBoxPlus_Validating(object sender, CancelEventArgs e)
        {
            // 前回の値から変更されているか？
            if (OldText != this.Text)
            {
                // 入力チェックと値の更新
                if (InputCheckAndUpdate(this.Text))
                {
                    Changed(sender, e); // イベント発行
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
                OldText = this.Text; // 前回のテキストを更新
            }
            else
            {
                ErrorMessageOutput();
                this.Text = OldText; // 前回のテキストに戻す
            }
            return result;
        }

        #endregion
    }
}
