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
            // テスト1
            string[] stringItems = { "AAA", "BBB", "CCC" };
            // DataSourceにデータをセットすると、SelectOrAddItem()は使えない
            // comboBoxPlus1.DataSource = stringItems; 
            comboBoxPlus1.Items.AddRange(stringItems);
            comboBoxPlus1.SelectedIndex = 0;

            // テスト2
            Color[] colors = new Color[3];
            colors[0] = Color.Red;
            colors[1] = Color.Green;
            colors[2] = Color.Blue;
        }

        #region テスト1

        private void checkBox1_3_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPlus1.ErrorMessageBoxEnabled = checkBox1_3.Checked;
        }

        private void checkBox1_4_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxPlus1.ErrorOutputEnabled = checkBox1_3.Checked;
        }

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

        private void comboBoxPlus1_Changed(object sender, EventArgs e)
        {
            if (checkBox1_1.Checked)
            {
                MessageBox.Show("値が変化しました:" + comboBoxPlus1.Text, "テスト");
            }
        }

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
    }
}
