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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // ComboBoxPlusのテスト1 (文字列)
            string[] stringItems = { "AAA", "BBB", "CCC" };
            // ※ DataSourceにデータをセットすると、SelectOrAddItem()は使えない
            // comboBoxPlus1.DataSource = stringItems; 
            comboBoxPlus1.Items.AddRange(stringItems);
            comboBoxPlus1.SelectedIndex = 0;

            // ComboBoxPlusのテスト2 (Colorオブジェクト)
            Color[] colors = new Color[3];
            colors[0] = Color.Red;
            colors[1] = Color.Green;
            colors[2] = Color.Blue;
            // ※ DataSourceにデータをセットすると、SelectOrAddItem()は使えない
            // comboBoxPlus2.DataSource = colors;
            // ※ 値型の配列は、Items.AddRange()が使えない
            // comboBoxPlus2.Items.AddRange(colors);
            comboBoxPlus2.AddArray(colors);
            comboBoxPlus2.SelectedIndex = 0;
            comboBoxPlus2.Changed += comboBoxPlus2_Changed;

            // ComboBoxIntegerのテスト
            int[] intItems = { 111, 222, 333 };
            comboBoxInteger.AddArray(intItems);
            comboBoxInteger.SelectedIndex = 0;
            comboBoxInteger.Changed += comboBoxInteger_Changed;

            // ComboBoxDoubleのテスト
            double[] doubleItems = { 1.11, 22.2, 333 };
            comboBoxDouble.AddArray(doubleItems);
            comboBoxDouble.SelectedIndex = 0;
            comboBoxDouble.Changed += comboBoxDouble_Changed;

            // ComboBoxDecimalのテスト
            decimal[] decimalItems = { 1.11m, 22.2m, 333m };
            comboBoxDecimal.AddArray(decimalItems);
            comboBoxDecimal.SelectedIndex = 0;
            comboBoxDecimal.Changed += comboBoxDecimal_Changed;
        }

        #region ComboBoxPlusのテスト1 (文字列)

        // エラーメッセージをメッセージボックスに出す
        private void checkBox1_3_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPlus1.ErrorMessageBoxEnabled = checkBox1_3.Checked;
        }

        // エラーメッセージをコンソールに出す
        private void checkBox1_4_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPlus1.ErrorOutputEnabled = checkBox1_3.Checked;
        }

        // 項目選択のテスト
        private void button1_1_Click(object sender, EventArgs e)
        {
            if (comboBoxPlus1.SelectItem(textBox1.Text))
            {
                MessageBox.Show("見つかりました", "テスト");
            }
            else
            {
                MessageBox.Show("見つかりませんでした", "テスト");
            }
        }

        // 項目選択/追加のテスト
        private void button1_2_Click(object sender, EventArgs e)
        {
            if(comboBoxPlus1.SelectOrAddItem(textBox1.Text))
            {
                MessageBox.Show("見つかりました", "テスト");
            }
            else
            {
                MessageBox.Show("追加しました", "テスト");
            }
        }

        // 値が変化した時のイベントのテスト
        private void comboBoxPlus1_Changed(object sender, EventArgs e)
        {
            if (checkBox1_1.Checked)
            {
                MessageBox.Show("値が変化しました:" + comboBoxPlus1.Text, "テスト");
            }
        }

        // ユーザー定義の入力チェックのテスト
        private bool comboBoxPlus1_InputCheck(string inputText)
        {
            if (checkBox1_2.Checked)
            {
                if(inputText.Length > 4)
                {
                    comboBoxPlus1.ErrorMessage = "4文字以内の文字列を入力してください";
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region ComboBoxPlusのテスト2 (Colorオブジェクト)

        // 項目選択のテスト
        private void button2_1_Click(object sender, EventArgs e)
        {
            if(!Enum.IsDefined(typeof(KnownColor), textBox2.Text))
            {
                MessageBox.Show("そんな色ないです", "テスト");
                return; 
            }
            Color color = Color.FromName(textBox2.Text);

            if (comboBoxPlus2.SelectItem(color))
            {
                MessageBox.Show("見つかりました", "テスト");
            }
            else
            {
                MessageBox.Show("見つかりませんでした", "テスト");
            }
        }

        // 項目選択/追加のテスト
        private void button2_2_Click(object sender, EventArgs e)
        {
            if (!Enum.IsDefined(typeof(KnownColor), textBox2.Text))
            {
                MessageBox.Show("そんな色ないです", "テスト");
                return;
            }
            Color color = Color.FromName(textBox2.Text);

            if (comboBoxPlus2.SelectOrAddItem(color))
            {
                MessageBox.Show("見つかりました", "テスト");
            }
            else
            {
                MessageBox.Show("追加しました", "テスト");
            }
        }

        // 値が変化した時のイベントのテスト
        private void comboBoxPlus2_Changed(object sender, EventArgs e)
        {
            // 色名が入力された場合はColorオブジェクトをリストに追加
            if(comboBoxPlus2.SelectedItem == null)
            {
                if (!Enum.IsDefined(typeof(KnownColor), comboBoxPlus2.Text))
                {
                    MessageBox.Show("あれれ？", "テスト");
                    return;
                }
                Color new_color = Color.FromName(comboBoxPlus2.Text);
                comboBoxPlus2.SelectOrAddItem(new_color);
            }
            else
            {
                Color color = (Color)comboBoxPlus2.SelectedItem;
                MessageBox.Show(color.Name + "=(" +
                                color.R + ", " +
                                color.G + ", " +
                                color.B + ")", "テスト");
            }
        }

        // ユーザー定義の入力チェックのテスト
        private bool comboBoxPlus2_InputCheck(string inputText)
        {
            if (!Enum.IsDefined(typeof(KnownColor), inputText))
            {
                comboBoxPlus2.ErrorMessage = "未定義の色名です";
                return false;
            }
            return true;
        }
        #endregion

        #region ComboBoxIntegerのテスト

        // 最大値のチェックのテスト
        private void checkBox3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_1.Checked)
            {
　              comboBoxInteger.MaxValue = 1000;
            }
            else
            {
                comboBoxInteger.MaxValue = null;
            }
        }

        // 最小値のチェックのテスト
        private void checkBox3_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_2.Checked)
            {
                comboBoxInteger.MinValue = -1000;
            }
            else
            {
                comboBoxInteger.MinValue = null;
            }
        }

        // 最小幅のチェックのテスト
        private void checkBox3_3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_3.Checked)
            {
                comboBoxInteger.StepValue = 5;
            }
            else
            {
                comboBoxInteger.StepValue = null;
            }
        }

        // ユーザー定義のチェック関数のON/OFF
        private void checkBox3_4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_4.Checked)
            {
                comboBoxInteger.InputCheck += comboBoxInteger_InputCheck;
            }
            else
            {
                comboBoxInteger.InputCheck -= comboBoxInteger_InputCheck;
            }
        }

        // 項目選択のテスト
        private void button3_1_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(textBox3.Text);

                if (comboBoxInteger.SelectItem(val))
                {
                    MessageBox.Show("見つかりました", "テスト");
                }
                else
                {
                    MessageBox.Show("見つかりませんでした", "テスト");
                }
            }
            catch
            {
                MessageBox.Show("数値を指定してね！", "テスト");
            }
        }
        // 項目選択/追加のテスト
        private void button3_2_Click(object sender, EventArgs e)
        {
            try
            {
                int val = int.Parse(textBox3.Text);

                if (comboBoxInteger.SelectOrAddItem(val))
                {
                    MessageBox.Show("見つかりました", "テスト");
                }
                else
                {
                    MessageBox.Show("追加しました", "テスト");
                }
            }
            catch
            {
                MessageBox.Show("数値を指定してね！", "テスト");
            }
        }
        // 値が変化した時のイベント
        private void comboBoxInteger_Changed(object sender, EventArgs e)
        {
            int? val = comboBoxInteger.Value;

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
        private bool comboBoxInteger_InputCheck(string text)
        {
            try
            {
                int val = int.Parse(text);

                if(val % 100 != 0)
                {
                    comboBoxInteger.ErrorMessage = "100で割り切れないよ！";
                    return false;
                }
                return true;
            }
            catch
            {
                comboBoxInteger.ErrorMessage = "数値じゃないよ！";
                return false;
            }
        }
        #endregion

        #region ComboBoxDoubleのテスト

        // 項目選択のテスト
        private void button4_1_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(textBox4.Text);

                if (comboBoxDouble.SelectItem(val))
                {
                    MessageBox.Show("見つかりました", "テスト");
                }
                else
                {
                    MessageBox.Show("見つかりませんでした", "テスト");
                }
            }
            catch
            {
                MessageBox.Show("数値を指定してね！", "テスト");
            }
        }

        // 項目選択/追加のテスト
        private void button4_2_Click(object sender, EventArgs e)
        {
            try
            {
                double val = double.Parse(textBox4.Text);

                if (comboBoxDouble.SelectOrAddItem(val))
                {
                    MessageBox.Show("見つかりました", "テスト");
                }
                else
                {
                    MessageBox.Show("追加しました", "テスト");
                }
            }
            catch
            {
                MessageBox.Show("数値を指定してね！", "テスト");
            }
        }

        // 値が変化した時のイベント
        private void comboBoxDouble_Changed(object sender, EventArgs e)
        {
            double? val = comboBoxDouble.Value;

            if (val == null)
            {
                MessageBox.Show("無効な値です", "テスト");
            }
            else
            {
                MessageBox.Show("整数値が変化しました: " + val.ToString(), "テスト");
            }
        }
        #endregion

        #region ComboBoxDecimalのテスト

        // 項目選択のテスト
        private void button5_1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal val = decimal.Parse(textBox5.Text);

                if (comboBoxDecimal.SelectItem(val))
                {
                    MessageBox.Show("見つかりました", "テスト");
                }
                else
                {
                    MessageBox.Show("見つかりませんでした", "テスト");
                }
            }
            catch
            {
                MessageBox.Show("数値を指定してね！", "テスト");
            }
        }

        // 項目選択/追加のテスト
        private void button5_2_Click(object sender, EventArgs e)
        {
            try
            {
                decimal val = decimal.Parse(textBox5.Text);

                if (comboBoxDecimal.SelectOrAddItem(val))
                {
                    MessageBox.Show("見つかりました", "テスト");
                }
                else
                {
                    MessageBox.Show("追加しました", "テスト");
                }
            }
            catch
            {
                MessageBox.Show("数値を指定してね！", "テスト");
            }
        }

        // 値が変化した時のイベント
        private void comboBoxDecimal_Changed(object sender, EventArgs e)
        {
            decimal? val = comboBoxDecimal.Value;

            if (val == null)
            {
                MessageBox.Show("無効な値です", "テスト");
            }
            else
            {
                MessageBox.Show("整数値が変化しました: " + val.ToString(), "テスト");
            }
        }
        #endregion
    }
}
