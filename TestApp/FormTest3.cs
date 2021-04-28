using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CommonControlPlus;

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
                MessageBox.Show("ON状態です", "テスト");
            }
            else
            {
                MessageBox.Show("OFF状態です", "テスト");
            }
        }

        private void onOffButton_ClickOn(object sender, CancelEventArgs e)
        {
            if (checkBox1_1.Checked)
            {
                MessageBox.Show("ONボタンが押されましたがキャンセルします", "テスト");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("ONボタンが押されました", "テスト");
            }
        }

        private void onOffButton_ClickOff(object sender, CancelEventArgs e)
        {
            if (checkBox1_2.Checked)
            {
                MessageBox.Show("OFFボタンが押されましたがキャンセルします", "テスト");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("OFFボタンが押されました", "テスト");
            }
        }
        #endregion

        #region OnOffButton2のテスト

        private void button2_1_Click(object sender, EventArgs e)
        {
            onOffButtonPair.TurnOn();
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            onOffButtonPair.TurnOff();
        }
        private void button2_3_Click(object sender, EventArgs e)
        {
            if (onOffButtonPair.TurnedOn)
            {
                MessageBox.Show("ON状態です", "テスト");
            }
            else
            {
                MessageBox.Show("OFF状態です", "テスト");
            }
        }

        private void onOffButtonPair_ClickOn(object sender, CancelEventArgs e)
        {
            if (checkBox2_1.Checked)
            {
                MessageBox.Show("ONボタンが押されましたがキャンセルします", "テスト");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("ONボタンが押されました", "テスト");
            }
        }

        private void onOffButtonPair_ClickOff(object sender, CancelEventArgs e)
        {
            if (checkBox2_2.Checked)
            {
                MessageBox.Show("OFFボタンが押されましたがキャンセルします", "テスト");
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("OFFボタンが押されました", "テスト");
            }
        }
        #endregion

        #region ToggleSwitchのテスト
        private void toggleSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var sw = (ToggleSwitch)sender;

            if (sw.Checked)
            {
                MessageBox.Show("チェックされました", "テスト");
            }
            else
            {
                MessageBox.Show("チェックがはずされました", "テスト");
            }
        }

        #endregion

        #region ToggleSwitchTextのテスト
        private void toggleSwitchText_CheckedChanged(object sender, EventArgs e)
        {
            var sw = (ToggleSwitchText)sender;

            if (sw.Checked)
            {
                MessageBox.Show("チェックされました", "テスト");
            }
            else
            {
                MessageBox.Show("チェックがはずされました", "テスト");
            }
        }

        #endregion

    }
}
