using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task02
{
    public partial class Form1 : Form
    {
        string[] start = { "one", "two", "three", "four", "five", "six", "seven//" };

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < start.Length; ++i)
            {
                listBox1.Items.Add(start[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < start.Length; ++i)
            {
                listBox1.Items.Add(start[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                return;
            }
            MessageBox.Show("Список пуст или нет выделенного элемента!", "Как-то так");
        }
    }
}
