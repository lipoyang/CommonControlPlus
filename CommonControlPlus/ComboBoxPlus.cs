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
        [Browsable(true)]
        public event EventHandler Changed = delegate { };

        /// <summary>
        /// 入力チェック関数の型
        /// </summary>
        /// <param name="inputText">入力された文字列</param>
        /// <returns>OK(true)かNG(false)か</returns>
        public delegate bool InputCheckFunction(string inputText);

        /// <summary>
        /// 入力チェック関数をここに設定します
        /// </summary>
        [Category("拡張機能")]
        [Browsable(true)]
        public event InputCheckFunction InputCheck = null;

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

        #region 公開メソッド

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ComboBoxPlus()
        {
            this.InitializeComponent();
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
        private string OldText = "";
        // 前回の選択アイテム (フォーカスが外れたときの判定用)
        private object OldItem = null;

        // 初期化
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ComboBoxPlus
            // 
            this.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPlus_SelectedIndexChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxPlus_KeyDown);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxPlus_Validating);
            this.ResumeLayout(false);

        }

        // リスト選択が変更されたとき
        private void ComboBoxPlus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 前回の選択値を更新し、イベント発行
            OldItem = this.SelectedItem;
            OldText = this.Text;
            Changed(sender, e);
        }

        // キーが押されたとき
        private void ComboBoxPlus_KeyDown(object sender, KeyEventArgs e)
        {
            // 前回の選択値から変更されているか？
            if (OldText != this.Text)
            {
                //Enterキーが押されたか？
                if (e.KeyCode == Keys.Enter)
                {
                    // 入力チェック
                    if (_InputCheck(this.Text))
                    {
                        // 前回の選択値を更新し、イベント発行
                        OldItem = this.SelectedItem;
                        OldText = this.Text;
                        Changed(sender, e);
                    }
                    else
                    {
                        ErrorMessageOutput();

                        // 前回の選択値に戻す
                        this.SelectedItem = OldItem;
                        if (OldItem == null) this.Text = OldText;
                    }
                }
            }
        }

        // フォーカスが外れたとき
        //private void ComboBoxPlus_Leave(object sender, EventArgs e)

        // フォーカスが外れたときの検証イベント
        private void ComboBoxPlus_Validating(object sender, CancelEventArgs e)
        {
            // 前回の選択値から変更されているか？
            if (OldText != this.Text)
            {
                // 入力チェック
                if (_InputCheck(this.Text))
                {
                    // 前回の選択値を更新し、イベント発行
                    OldItem = this.SelectedItem;
                    OldText = this.Text;
                    Changed(sender, e);
                }
                else
                {
                    ErrorMessageOutput();

                    // 前回の選択値に戻す
                    this.SelectedItem = OldItem;
                    if (OldItem == null) this.Text = OldText;

                    e.Cancel = true; // 検証の結果、キャンセルを返す
                }
            }
        }

        // エラーメッセージの出力
        private void ErrorMessageOutput()
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

        // 入力チェック関数 (ユーザー定義または既定の入力チェック関数を評価)
        private bool _InputCheck(string text)
        {
            // ユーザー定義の入力チェック関数
            if(InputCheck != null)
            {
                return InputCheck(text);
            }
            // 既定の入力チェック関数
            else
            {
                return DefaultInputCheck(text);
            }
        }

        // 既定の入力チェック関数
        virtual protected bool DefaultInputCheck(string text)
        {
            // 常にtrue
            return true;
        }
        #endregion
    }
}
