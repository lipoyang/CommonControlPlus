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
    public partial class FormTest3 : Form
    {
        public FormTest3()
        {
            InitializeComponent();
        }

        #region OnOffButtonのテスト
        private void button1_1_Click(object sender, EventArgs e)
        {
            onOffButton.TurnOn();
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            onOffButton.TurnOff();
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            if (onOffButton.TurnedOn)
            {
                MessageBox.Show("ON状態です");
            }
            else
            {
                MessageBox.Show("OFF状態です");
            }
        }

        private void onOffButton_ClickOn(object sender, CancelEventArgs e)
        {
            if (checkBox1_1.Checked)
            {
                MessageBox.Show("ONボタンが押されましたがキャンセルします");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("ONボタンが押されました");
            }
        }

        private void onOffButton_ClickOff(object sender, CancelEventArgs e)
        {
            if (checkBox1_2.Checked)
            {
                MessageBox.Show("OFFボタンが押されましたがキャンセルします");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("OFFボタンが押されました");
            }
        }
        #endregion

        #region OnOffButton2のテスト

        private void button2_1_Click(object sender, EventArgs e)
        {
            onOffButton2.TurnOn();
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            onOffButton2.TurnOff();
        }
        private void button2_3_Click(object sender, EventArgs e)
        {
            if (onOffButton2.TurnedOn)
            {
                MessageBox.Show("ON状態です");
            }
            else
            {
                MessageBox.Show("OFF状態です");
            }
        }

        private void onOffButton2_ClickOn(object sender, CancelEventArgs e)
        {
            if (checkBox2_1.Checked)
            {
                MessageBox.Show("ONボタンが押されましたがキャンセルします");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("ONボタンが押されました");
            }
        }

        private void onOffButton2_ClickOff(object sender, CancelEventArgs e)
        {
            if (checkBox2_2.Checked)
            {
                MessageBox.Show("OFFボタンが押されましたがキャンセルします");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("OFFボタンが押されました");
            }
        }
        #endregion

    }
}
