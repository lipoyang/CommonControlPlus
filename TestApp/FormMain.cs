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
        delegate string EventHoge();

        event EventHoge eventHoge;

        string Func1()
        {
            return "AAA";
        }
        string Func2()
        {
            return "BBB";
        }


        public FormMain()
        {
            InitializeComponent();
        }

        Hoge[] hoges = new Hoge[3];

        private void FormMain_Load(object sender, EventArgs e)
        {
            string[] items = {"AAA", "BBB", "CCC" };
            for (int i = 0; i < hoges.Length; i++)
            {
                hoges[i] = new Hoge(items[i]);
            }

            Color[] colors = new Color[3];
            colors[0] = Color.Red;
            colors[1] = Color.Green;
            colors[2] = Color.Blue;

            int[] iData = { 111, 222, 333 };

            comboBox1.DataSource = colors;


            eventHoge += Func1;
            eventHoge += Func2;

            //comboBox1.Items.AddRange(items);
            //comboBox1.Items.Add(iData[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedItem = Color.Green;
            comboBox1.SelectedItem = Color.Black;
            //comboBox1.SelectedItem = hoges[2];// new Hoge("BBB");

            //MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private bool comboBoxPlus2_UserInputCheck(string inputText)
        {
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ret = eventHoge();

            MessageBox.Show(ret);
        }
    }

    public class Hoge : object
    {
        private string Name;
        public Hoge(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
    }


}
