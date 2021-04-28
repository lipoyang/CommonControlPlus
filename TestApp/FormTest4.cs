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
    public partial class FormTest4 : Form
    {
        public FormTest4()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // NumericBoxIntegerのテスト
            numericBoxInteger.Value = 100;
            numericBoxInteger.MaxValue = 1000;
            numericBoxInteger.MinValue = -1000;
            numericBoxInteger.StepValue = 100;
            textBoxInteger1_1.Value = 1000;
            textBoxInteger1_2.Value = -1000;
            textBoxInteger1_3.Value = 100;
        }

        #region NumericBoxIntegerのテスト

        // 最大値の設定
        private void textBoxInteger1_1_Changed(object sender, EventArgs e)
        {
            numericBoxInteger.MaxValue = textBoxInteger1_1.Value;
        }

        // 最小値の設定
        private void textBoxInteger1_2_Changed(object sender, EventArgs e)
        {
            numericBoxInteger.MinValue = textBoxInteger1_2.Value;
        }

        // 変化幅の設定
        private void textBoxInteger1_3_Changed(object sender, EventArgs e)
        {
            numericBoxInteger.StepValue = textBoxInteger1_3.Value;
        }

        // 値の設定
        private void button1_1_Click(object sender, EventArgs e)
        {
            numericBoxInteger.Value = textBoxInteger1_4.Value;
        }

        // 値の取得
        private void button1_2_Click(object sender, EventArgs e)
        {
            textBoxInteger1_5.Value = numericBoxInteger.Value;
        }

        // 値の変化イベント
        private void numericBoxInteger_Changed(object sender, EventArgs e)
        {
            if (checkBox1_1.Checked)
            {
                MessageBox.Show("値が変化しました:" + numericBoxInteger.Text, "テスト");
            }
        }

        // エラーをメッセージボックスに出すか
        private void checkBox1_2_CheckedChanged(object sender, EventArgs e)
        {
            numericBoxInteger.ErrorMessageBoxEnabled = checkBox1_2.Checked;
        }

        // エラーをコンソール出力するか
        private void checkBox1_3_CheckedChanged(object sender, EventArgs e)
        {
            numericBoxInteger.ErrorOutputEnabled = checkBox1_3.Checked;
        }

        #endregion

        #region NumericBoxDoubleのテスト

        #endregion

        #region NumericBoxDecimalのテスト

        #endregion
    }
}
