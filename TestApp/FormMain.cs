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

        // 拡張版ComboBoxのテスト
        private void button1_Click(object sender, EventArgs e)
        {
            var form = new FormTest1();
            form.Show();
        }

        // 拡張版TextBoxのテスト
        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FormTest2();
            form.Show();
        }

        // ボタン・スイッチ類のテスト
        private void button3_Click(object sender, EventArgs e)
        {
            var form = new FormTest3();
            form.Show();
        }

        // NumericBox類のテスト
        private void button4_Click(object sender, EventArgs e)
        {
            var form = new FormTest4();
            form.Show();
        }

        // ControlGroupのテスト
        private void button5_Click(object sender, EventArgs e)
        {
            var form = new FormTest5();
            form.Show();
        }
    }
}
