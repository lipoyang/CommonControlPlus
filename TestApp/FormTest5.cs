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
    public partial class FormTest5 : Form
    {
        // グループA
        ControlGroup controlGroupA = new ControlGroup();
        // グループB
        ControlGroup controlGroupB = new ControlGroup();

        public FormTest5()
        {
            InitializeComponent();

            // グループA
            controlGroupA.Add(buttonA);
            controlGroupA.Add(checkBoxA);
            controlGroupA.Add(comboBoxA);
            controlGroupA.Enabled = false;

            // グループB
            controlGroupB.Add(buttonB);
            controlGroupB.Add(checkBoxB);
            controlGroupB.Add(comboBoxB);
            controlGroupB.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            controlGroupA.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            controlGroupB.Enabled = checkBox2.Checked;
        }
    }
}
