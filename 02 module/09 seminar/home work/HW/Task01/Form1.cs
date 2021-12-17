using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DeepPink;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (label1.Text != "Кот уже ушёл")
            {
                if (label1.Text.Length != 0)
                {
                    StringBuilder newString = new StringBuilder();
                    for (int i = 0; i < label1.Text.Length - 1; ++i)
                    {
                        newString.Append(label1.Text[i]);
                    }
                    label1.Text = newString.ToString();
                }
                else if (Opacity > 0)
                {
                    Opacity -= 0.1;
                }
                else
                {
                    label1.Text = "Кот уже ушёл";
                }
            }
            else
            {
                Opacity += 0.1;
            }
        }
    }
}
