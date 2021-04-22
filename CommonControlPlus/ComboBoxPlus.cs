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
        #region API

        /// <summary>
        /// 値の変更が確定したときに発生するイベント
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event EventHandler Changed = delegate { };

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
        /// ユーザー定義のエラーメッセージをここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public string UserErrorMessage { set; get; } = "";

        /// <summary>
        /// 入力チェック関数の型
        /// </summary>
        /// <param name="inputText">入力された文字列</param>
        /// <returns>OK(true)かNG(false)か</returns>
        public delegate bool InputCheckFunction(string inputText);

        /// <summary>
        /// ユーザー定義の入力チェック関数をここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public InputCheckFunction UserInputCheck = delegate { return true; };

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ComboBoxPlus()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// リストを検索して項目を選択する
        /// </summary>
        /// <param name="obj">選択したい項目</param>
        /// <returns>項目が存在したか</returns>
        public bool SelectItem(object obj)
        {
            this.SelectedItem = obj;

            if(this.SelectedItem == obj)
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
            this.SelectedItem = obj;

            if (this.SelectedItem == obj)
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

        #endregion

        #region 内部処理

        // 前回の選択値 (フォーカスが外れたときの判定用)
        private string OldText = "";

        // 初期化
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ComboBoxPlus
            // 
            this.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlus_SelectedIndexChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxPlus_KeyDown);
            this.Leave += new System.EventHandler(this.ComboBoxPlus_Leave);
            this.ResumeLayout(false);

        }

        // リスト選択が変更されたとき
        private void ComboBoxPlus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 前回の選択値を更新し、イベント発行
            OldText = this.Text;
            Changed(sender, e);
        }

        // キーが押されたとき
        private void ComboBoxPlus_KeyDown(object sender, KeyEventArgs e)
        {
            //Enterキーが押されたか？
            if (e.KeyCode == Keys.Enter)
            {
                // 入力チェック
                if (InputCheck() && UserInputCheck(this.Text))
                {
                    // 前回の選択値を更新し、イベント発行
                    OldText = this.Text;
                    Changed(sender, e);
                }
                else if (UserErrorMessage != "")
                {
                    if (ErrorMessageBoxEnabled)
                    {
                        ErrorMessageBox_Show(UserErrorMessage);
                    }
                    if (ErrorOutputEnabled)
                    {
                        Console.WriteLine(this.Name + ": " + UserErrorMessage);
                    }
                }
            }
        }

        // フォーカスが外れたとき
        private void ComboBoxPlus_Leave(object sender, EventArgs e)
        {
            // 前回の選択値から変更されているか？
            if (OldText != this.Text)
            {
                // 入力チェック
                if (InputCheck() && UserInputCheck(this.Text))
                {
                    // 前回の選択値を更新し、イベント発行
                    OldText = this.Text;
                    Changed(sender, e);
                }
                else if (UserErrorMessage != "")
                {
                    if (ErrorMessageBoxEnabled)
                    {
                        ErrorMessageBox_Show(UserErrorMessage);
                    }
                    if (ErrorOutputEnabled)
                    {
                        Console.WriteLine(this.Name + ": " + UserErrorMessage);
                    }
                }
            }
        }

        // エラーメッセージボックスの表示
        protected void ErrorMessageBox_Show(string message)
        {
            MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // 入力チェック (この基本クラスでは常にtrueを返す)
        protected virtual bool InputCheck()
        {
            return true;
        }

        #endregion
    }

}
