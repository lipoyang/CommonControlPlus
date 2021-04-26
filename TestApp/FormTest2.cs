using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class FormTest2 : Form
    {
        public FormTest2()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TextBoxPlusのテスト1
            textBoxPlus.Text = "AAA";

            // TextBoxIntegerのテスト
            textBoxInteger.Value = 111;
            textBoxInteger.Changed += textBoxInteger_Changed;

            // TextBoxDoubleのテスト
            textBoxDouble.Value = 1.11;
            textBoxDouble.FormatString = "F2";
            textBoxDouble.Changed += textBoxDouble_Changed;

            // TextBoxDecimalのテスト
            textBoxDecimal.Value = 1.11m;
            textBoxDecimal.FormatString = "F3";
            textBoxDecimal.Changed += textBoxDecimal_Changed;
        }

        #region TextBoxPlusのテスト

        // エラーメッセージをメッセージボックスに出す
        private void checkBox1_3_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlus.ErrorMessageBoxEnabled = checkBox1_3.Checked;
        }

        // エラーメッセージをコンソールに出す
        private void checkBox1_4_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlus.ErrorOutputEnabled = checkBox1_3.Checked;
        }

        // 値が変化した時のイベントのテスト
        private void textBoxPlus_Changed(object sender, EventArgs e)
        {
            if (checkBox1_1.Checked)
            {
                MessageBox.Show("値が変化しました:" + textBoxPlus.Text, "テスト");
            }
        }

        // ユーザー定義の入力チェックのテスト
        private bool textBoxPlus_InputTextCheck(string inputText)
        {
            if (checkBox1_2.Checked)
            {
                if(inputText.Length > 4)
                {
                    textBoxPlus.ErrorMessage = "4文字以内の文字列を入力してください";
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region TextBoxIntegerのテスト

        // 最大値のチェックのテスト
        private void checkBox3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_1.Checked)
            {
                textBoxInteger.MaxValue = 1000;
            }
            else
            {
                textBoxInteger.MaxValue = null;
            }
        }

        // 最小値のチェックのテスト
        private void checkBox3_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_2.Checked)
            {
                textBoxInteger.MinValue = -1000;
            }
            else
            {
                textBoxInteger.MinValue = null;
            }
        }

        // 最小幅のチェックのテスト
        private void checkBox3_3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_3.Checked)
            {
                textBoxInteger.StepValue = 5;
            }
            else
            {
                textBoxInteger.StepValue = null;
            }
        }

        // ユーザー定義のチェック関数のON/OFF
        private void checkBox3_4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_4.Checked)
            {
                textBoxInteger.InputValueCheck += textBoxInteger_InputCheck;
            }
            else
            {
                textBoxInteger.InputValueCheck -= textBoxInteger_InputCheck;
            }
        }

        // 項目選択のテスト
        private void button3_1_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(textBox3.Text);

                textBoxInteger.Value = val;
            }
            catch
            {
                MessageBox.Show("整数値を指定してね！", "テスト");
            }
        }

        // 値が変化した時のイベント
        private void textBoxInteger_Changed(object sender, EventArgs e)
        {
            int? val = textBoxInteger.Value;

            if(val == null)
            {
                MessageBox.Show("無効な値です","テスト");
            }
            else
            {
                MessageBox.Show("整数値が変化しました: " + val.ToString(), "テスト");
            }
        }

        // ユーザー定義の入力チェック関数
        private bool textBoxInteger_InputCheck(int val)
        {
            if(val % 100 != 0)
            {
                textBoxInteger.ErrorMessage = "100で割り切れないよ！";
                return false;
            }
            return true;
        }
        #endregion

        #region TextBoxDoubleのテスト

        // 値設定のテスト
        private void button4_1_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(textBox4.Text);

                textBoxDouble.Value = val;
            }
            catch
            {
                MessageBox.Show("数値を指定してね！", "テスト");
            }
        }

        // 値が変化した時のイベント
        private void textBoxDouble_Changed(object sender, EventArgs e)
        {
            double? val = textBoxDouble.Value;

            if (val == null)
            {
                MessageBox.Show("無効な値です", "テスト");
            }
            else
            {
                MessageBox.Show("数値が変化しました: " + val.ToString(), "テスト");
            }
        }
        #endregion

        #region textBoxDecimalのテスト

        // 項目選択のテスト
        private void button5_1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal val = decimal.Parse(textBox5.Text);

                textBoxDecimal.Value = val;
            }
            catch
            {
                MessageBox.Show("数値を指定してね！", "テスト");
            }
        }

        // 値が変化した時のイベント
        private void textBoxDecimal_Changed(object sender, EventArgs e)
        {
            decimal? val = textBoxDecimal.Value;

            if (val == null)
            {
                MessageBox.Show("無効な値です", "テスト");
            }
            else
            {
                MessageBox.Show("数値が変化しました: " + val.ToString(), "テスト");
            }
        }
        #endregion
    }
}
